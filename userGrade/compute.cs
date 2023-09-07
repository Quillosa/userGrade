using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class compute
    {
        private double add;

        public void setadd(double var1, double var2, double var3, double var4)
        {

            add = (var1*0.2) + (var2*0.2) + (var3 * 0.2) + (var4 * 0.4);
        }
        public double getadd()
        {
            return add;
        }
    }
}
