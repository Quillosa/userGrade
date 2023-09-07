using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class final
    {
        private double fin;
        ArrayList finals = new ArrayList();

        public void setfin(double var1)
        {
           
            finals.Add(var1);
           
        }
        public double getfin(int index)
        {
            double grade = Convert.ToDouble(finals[index]);
            return grade;
        }
    }
}
