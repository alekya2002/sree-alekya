

using System;


namespace student
{
    class details
    {


        public static void Main(string[] args)
        {
            string userinput;
            string Uid;
            string Name;
            int Sem;
            string Email;

            Console.Write("Enter Uid: ");
            userinput = Console.ReadLine();
            Uid = Convert.ToString(userinput);
            Console.WriteLine("You entered Uid :{0}", Uid);

            Console.Write("Enter Name: ");
            userinput = Console.ReadLine();
            Name = Convert.ToString(userinput);
            Console.WriteLine("You entered Name: {0}", Name);

            try
            {

                Console.Write("Enter Sem: ");
                userinput = Console.ReadLine();
                Sem = Convert.ToInt32(userinput);
                Console.WriteLine("You entered Sem: {0}", Sem);
            }
            catch
            {
                Console.WriteLine("invalid input!! try again");
            }


            try
            {

                Console.Write("Enter Email: ");
                userinput = Console.ReadLine();
                Email = Convert.ToString(userinput);
                Console.WriteLine("You entered Email: {^[A-Z]+@[a-z]+.[a-z]} is {^[A-Z]+@[a-z]+.[a-z]}", Email);

            }


            catch (Exception)
            {
                Console.WriteLine("invalid email");
                Console.WriteLine("try again");
            }

            Console.ReadLine();
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace studentdetails
{
    class DisplayData
    {
       
       
        public DisplayData(string Uid, string Name, int Sem, string Email)
        {
            Console.Write("Uid.... ");
            Uid = Console.ReadLine();
            Console.Write("Name.... ");
            Name = Console.ReadLine();
            Console.Write("Sem.... ");
            Sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email.........");
            Email = Console.ReadLine();
        }
        public void GetData()
        {
        
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            DisplayData obj = new DisplayData(FiName, Laname, FName, Addr, Gend, Ema);
            //DisplayData ob = new DisplayData();
            //ob.GetData();
            Console.ReadLine();
        }
    }
}*/





