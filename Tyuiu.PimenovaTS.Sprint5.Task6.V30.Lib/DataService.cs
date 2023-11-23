using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PimenovaTS.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string tut = line.Replace(" ", "*");
                    for ( int i = 0; i < tut.Length; i ++)
                    {
                        if (tut[i] != '*')
                        {
                            count++;
                        }
                        else
                        {
                            if (count == 8)
                            {
                                res++;
                                count = 0;
                            }
                            else
                            {
                                count = 0;
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
