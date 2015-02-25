using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project
{
    class Program
    {
        static void Main()
        {
            var s = new Stadi();
            s.AddObj();
            s.ShowObj();
        }

        class Stadi
        {
            private readonly Firm [] _obj = new Firm[3];
            //private Empl[] _obj = new Empl[5];
            public Stadi ()
            {
                
            }

            public void AddObj()
            {
                for(var i = 0;i<3;++i)
                {
                    _obj[i]=new Firm(Console.ReadLine());
                    _obj[i].AddEmls();
                }
                
            }

            public void ShowObj()
            {
                for (var i = 0; i < 3; ++i)
                //foreach (int i in _obj)
                {
                    _obj[i].ShowEmpl();
                }
            }
        }
    }
}
