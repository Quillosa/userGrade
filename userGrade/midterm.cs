using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class midterm
    {
        
        ArrayList midterms = new ArrayList();

        public void setmid(double var1)
        {
           
            midterms.Add(var1);
            
        }
        public double getmid(int index)
        {
            double grade = Convert.ToDouble(midterms[index]);
            return grade;
        }
    }
}
