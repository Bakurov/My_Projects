using System;

namespace My_Project
{
    public abstract class Empl
    {
        
        protected Empl(string p)
        {
            _post = p;
        }

        public string _post;

        public virtual void ShowEmpl()
        {
            Console.WriteLine("Сотрудник");
        }
    }
}