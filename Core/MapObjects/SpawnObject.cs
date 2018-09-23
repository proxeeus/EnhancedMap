using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using EnhancedMap.Properties;

namespace EnhancedMap.Core.MapObjects
{
    public class SpawnObject : RenderObject
    {
        public Image Image { get; set; }
        private static readonly Pen _pen = new Pen(Color.White) { DashStyle = DashStyle.Dot, DashPattern = new float[] { 9, 4, 3, 4, 3, 4 } };
        public UserObject Parent { get; }
        public bool IsMouseOver { get; private set; }
        private readonly LabelObject _label = new LabelObject { Background = ColorsCache["transparent"], Hue = ColorsCache["stamina"] };

        public bool HasFocus { get; private set; }

        public int NPCCount { get; set; }
        public int HomeRange { get; set; }
        public bool TotalRespawn { get; set; }
        public string MinTime { get; set; }
        public string MaxTime { get; set; }
        public int Team { get; set; }
        public string SpawnerName { get; set; }
        public List<string> Mobiles { get; set; }

        public SpawnObject(UserObject parent, int x, int y) : base("marker")
        {
            Parent = parent;
            UpdatePosition(x, y);

            /// TODO: unhardcode this
            Image = new Bitmap(Image.FromFile(@"C:\Users\LENOVO\Desktop\Nouveau dossier\src\bin\Debug\Icon\GEM.png"), 16, 16);
        }

        #region Rendering
        public override bool Render(Graphics g, int x, int y, int canvasW, int canvasH)
        {
            if (Parent == null || Parent.IsDisposing)
                Dispose();

            if (IsDisposing || Map != Global.Facet)
                return false;

            int gameX = RelativePosition.X;
            int gameY = RelativePosition.Y;

            (gameX, gameY) = Geometry.RotatePoint(gameX, gameY, Global.Zoom, 1, Global.Angle);
            AdjustPosition(gameX, gameY, x - 4, y - 4, out int relativeX, out int relativeY);

            gameX = relativeX;
            gameY = relativeY;

            relativeX = gameX + x;
            relativeY = gameY + y;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.ResetTransform();

            g.DrawImage(Image, relativeX - Image.Width / 2, relativeY - Image.Height, Image.Width, Image.Height);

            int wx = Image.Width / 2;
            int wy = Image.Height / 2;

            if (MouseManager.Location.X >= Position.X - wx && MouseManager.Location.X <= Position.X + wx && MouseManager.Location.Y >= Position.Y - wy && MouseManager.Location.Y <= Position.Y + wy && MouseManager.IsEnter)
            {
                if (!IsMouseOver)
                {
                    IsMouseOver = true;
                    HasFocus = true;
                }
                    
                if (!_label.IsVisible)
                {
                    _label.IsVisible = true;
                    _label.UpdatePosition(MouseManager.Location.X, MouseManager.Location.Y);
                    _label.Text = "Spawner";

                }

                _label.Render(g, x, y, canvasW, canvasH);
                return true;
            }

            if (IsMouseOver)
            {
                IsMouseOver = false;
                HasFocus = false;
            }
                
            return false;
        }
        #endregion
    }
}
