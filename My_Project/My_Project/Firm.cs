using System;
namespace My_Project
{
    public class Firm:Empl
    {
        public string Fname;
        public string Lname;
        public string Age;
        public Firm(string post):base("Сотрудник")
        {
            Fname = "None";
            Lname = "None";
            Age = "None";
            //Post = "None";
        }

        public void AddEmls()
        {
            //Console.WriteLine("");
            Fname = Console.ReadLine();
            Lname = Console.ReadLine();
            Age = Console.ReadLine();
        }

        public override void ShowEmpl()
        {
            Console.WriteLine("\t"+_post);
            Console.WriteLine("\t" + Fname);
            Console.WriteLine("\t" + Lname);
            Console.WriteLine("\t" + Age+"\n");
        }
    }

}