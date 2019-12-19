using System.Drawing;

namespace SUDO_MUSIC
{
    public class CustomPopupPlacement
    {
        private Point point;
        private object vertical;

        public CustomPopupPlacement(Point point, object vertical)
        {
            this.point = point;
            this.vertical = vertical;
        }
    }
}