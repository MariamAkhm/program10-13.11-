using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10_13._11_
{
    interface IPoint
    {
        void Moving (MovingLine movingType, int position);
        void IsVisible();
        void ChangeColor(Color color);
    }
}
