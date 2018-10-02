using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
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

        public Guid Id { get; set; }
        public int NPCCount { get; set; }
        public int HomeRange { get; set; }
        public bool BringToHome { get; set; }
        public string MinTime { get; set; }
        public string MaxTime { get; set; }
        public int Team { get; set; }
        public string SpawnerName { get; set; }
        public List<string> Mobiles { get; set; }
        public bool UniqueSpawn { get; set; }
        public string MapId { get; set; }
        public string FacetId { get; set; }
        
        public SpawnObject(UserObject parent, int x, int y, SpawnDefinition spawnDefinition) : base("marker")
        {
            Parent = parent;
            UpdatePosition(x, y);

            Id = Guid.NewGuid();
            NPCCount = Convert.ToInt32(spawnDefinition.NPCCount);
            HomeRange = Convert.ToInt32(spawnDefinition.HomeRange);
            BringToHome = spawnDefinition.BringToHome;
            MinTime = spawnDefinition.MinTime;
            MaxTime = spawnDefinition.MaxTime;
            Team = Convert.ToInt32(spawnDefinition.Team);
            SpawnerName = spawnDefinition.SpawnerName;
            Mobiles = spawnDefinition.Mobiles;
            UniqueSpawn = spawnDefinition.UniqueSpawn;

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
                    _label.Text = SpawnerName;

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

        public override string ToString()
        {
            return this.SpawnerName + " [" + this.Position.X + ", " + this.Position.Y + "]";
        }

        public string ToText()
        {
            var line = string.Empty;

            // Basic format
            // +name [MobileTypeA, MobileTypeB, etc]: X Y MapID NPCCount HomeRange BringToHome MinTime MaxTime Team Description
            // "," can also be "|" depending on spawn being unique or not

            var template = @"+{0} [{1}]: {2} {3} {4} {5} {6} {7} {8} {9} {10}";

            var mobBuilder = new StringBuilder();
            var separator = string.Empty;
            if (UniqueSpawn)
                separator = ", ";
            else
                separator = "| ";
            var mobIndex = 1;
            for(var i = 0; i < Mobiles.Count; i++)
            {
                mobBuilder.Append(Mobiles[i]);
                if (mobIndex < Mobiles.Count)
                {
                    mobBuilder.Append(separator);
                    mobIndex++;
                }  
            }

            line = string.Format(template, SpawnerName.ToLower(),
                mobBuilder.ToString(), Position.X, Position.Y, Global.PlayerInstance.Map, NPCCount, HomeRange, BringToHome, MinTime, MaxTime, Team);

            return line;
        }
    }

}
