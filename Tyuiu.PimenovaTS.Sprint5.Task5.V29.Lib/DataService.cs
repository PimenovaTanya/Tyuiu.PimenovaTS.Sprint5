using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PimenovaTS.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 100;
            using (StreamReader reader = new StreamReader(path))
            {
                double c = 0;
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    c = Convert.ToDouble(line);
                    if (10 <= c && c < 100)
                    {
                        
                        if (res > Convert.ToDouble(line))
                        {
                            res = Convert.ToDouble(line);
                        }
                        
                    }
                    c = 0;
                }
            }
            return res;
        }
    }
}
