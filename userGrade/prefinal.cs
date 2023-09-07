using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class prefinal
    {
        
        ArrayList prefinals = new ArrayList();
       
        public void setpref(double var1)
        {
           
            prefinals.Add(var1);
            

        }
        public double getpref(int index)
        {
            double grade = Convert.ToDouble(prefinals[index]);
            return grade;
        }
    }
}
