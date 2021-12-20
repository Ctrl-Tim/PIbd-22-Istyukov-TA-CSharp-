using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    class AirComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            else
            {
                if (x.GetType().Name == "WarPlane" && y.GetType().Name == "WarPlane")
                {
                    return ComparerWarPlane((WarPlane)x, (WarPlane)y);
                }
                else if (x.GetType().Name == "FighterPlane" && y.GetType().Name == "FighterPlane")
                {
                    return ComparerFighterPlane((FighterPlane)x, (FighterPlane)y);
                }
            }
            return 0;
        }


        private int ComparerWarPlane(WarPlane x, WarPlane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerFighterPlane(FighterPlane x, FighterPlane y)
        {
            var res = ComparerWarPlane(x, y);

            if (res != 0)
            {
                return res;
            }

            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontPlane != y.FrontPlane)
            {
                return x.FrontPlane.CompareTo(y.FrontPlane);
            }
            if (x.SideBombs != y.SideBombs)
            {
                return x.SideBombs.CompareTo(y.SideBombs);
            }
            if (x.BigBombs != y.BigBombs)
            {
                return x.BigBombs.CompareTo(y.BigBombs);
            }
            if (x.MiniBombs != y.MiniBombs)
            {
                return x.MiniBombs.CompareTo(y.MiniBombs);
            }

            return 0;
        }
    }
}
