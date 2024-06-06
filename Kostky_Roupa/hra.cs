using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Kostky_Roupa
{
    public class hra
    {
        public List<kostky> GameObjects { get; set; }
        public hra()
        {
            GameObjects = new List<kostky>();
        }
        public void Draw(Canvas canvas)
        {
            foreach (kostky obj in GameObjects)
            {

                if (obj != null)
                {

                    obj.Draw(canvas);
                }
            }
        }
    }
}
