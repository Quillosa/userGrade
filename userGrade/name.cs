using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace userGrade
{
    internal class name
    {
        
        
        ArrayList names = new ArrayList();

        public void setname(string username)
        {
            names.Add(username);
            
        }
        public string getname(int index)
        {
            string grade = names[index].ToString();
            return grade;
        }
       
        public int getindex(string name)
        {
            if (names.Contains(name))
            {
                int index = names.IndexOf(name);
                return index;
            }
            else
            {
                return -1;
            }
        }
        
    }
}
