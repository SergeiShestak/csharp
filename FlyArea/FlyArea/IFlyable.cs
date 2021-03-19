using System;
using System.Collections.Generic;
using System.Text;

namespace FlyArea
{
    interface IFlyable
    {
        public long FlyTo(Coordinate coordinate);

        public TimeSpan GetFlyTime(Coordinate coordinate);
    }
}
