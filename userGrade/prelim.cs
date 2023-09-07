using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class prelim
    {
        
        ArrayList prelims = new ArrayList();

        public void setpre(double var1)
        {
            
            prelims.Add(var1);
            
            

        }
        public double getpre(int index)
        {
            double grade = Convert.ToDouble(prelims[index]);
            return grade;
        }
    }
}
