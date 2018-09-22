using EnhancedMap.Core.MapObjects;

namespace EnhancedMap.Core
{
    public static class MouseManager
    {
        public static Position Location { get; set; } = new Position();
        public static bool IsEnter { get; set; }
        public static bool LeftIsPressed { get; set; }
        public static bool RightIsPressed { get; set; }
        public static bool IsMove { get; set; }
        public static bool IsDragging => LeftIsPressed && IsMove;

        public static bool IsOverAnObject { get; set; }

        /// <summary>
        /// Gets or sets the current Location (X,Y) clicked on.
        /// </summary>
        public static string LocationXY { get; set; }
    }
}