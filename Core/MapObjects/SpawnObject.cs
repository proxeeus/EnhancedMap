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

        public SpawnObject(string name) : base(name)
        {
        }

        public SpawnObject(UserObject parent, int x, int y) : base("marker")
        {
            Parent = parent;
            UpdatePosition(x, y);

            Image = new Bitmap(Image.FromFile(@"C:\Users\LENOVO\Desktop\Nouveau dossier\src\bin\Debug\Icon\GEM.png"), 16, 16);
        }

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


            int playerX = Global.PlayerInstance.RelativePosition.X;
            int playerY = Global.PlayerInstance.RelativePosition.Y;

            (playerX, playerY) = Geometry.RotatePoint(playerX, playerY, Global.Zoom, 1, Global.Angle);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.ResetTransform();

            g.DrawImage(Image, relativeX - Image.Width / 2, relativeY - Image.Height, Image.Width, Image.Height);

            return false;
        }
    }
}
