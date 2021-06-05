using System;

namespace home6
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("ORDER FOOD ONLINE");
            Console.WriteLine();
            Console.WriteLine(" push 1 => Hungry   ");
            Console.WriteLine(" push in addition => Not hungry ");
            Console.WriteLine();
            Console.Write("Can input 1 and 2 only :");
            
            int chooseapp;
            int Hungry;
            int i = 0;

            while (i != 1)
            {
                int.TryParse(Console.ReadLine(), out Hungry);

                if (Hungry == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("App Food panda => Push 1");
                    Console.WriteLine("App Line man => Push 2");
                    Console.WriteLine("App Uber Eats => Push 3");
                    Console.WriteLine("App Grab food => Push 4");
                    Console.WriteLine("App Get food => Push 5");
                    Console.WriteLine();
                    Console.Write("Select food apps :");
                    i = 1;
                }
                else if (Hungry == 2)
                {
                    Console.WriteLine("Not hungry");
                    i = 2;
                }
                else
                {
                    Console.Write("input 1 and 2 only :");
                }
            }

            chooseapp = int.Parse(Console.ReadLine());
            if (chooseapp == 1)
            {
                FOODPANDA();
            }
            else if (chooseapp == 2)
            {
                LINEMAN();
            }
            else if (chooseapp == 3)
            {
                UberEats();
            }
            else if (chooseapp == 4)
            {
                Grabfood();
            }
            else if (chooseapp == 5)
            {
                Getfood();
            }
            

        }
        static void FOODPANDA()
        {
            
            Console.WriteLine("APP FOOD PANDA");
            Console.WriteLine();
            Console.WriteLine("MUNU FOOD");
            Console.Write("INPUT NAME FOOD IN ENGLISH  :");
            string inputnamefood = Console.ReadLine();
            
            Console.WriteLine("push 0 => Confirm order");
            Console.WriteLine("push 1 => Cancel order");
            int Confirm = int.Parse(Console.ReadLine());
            
            if (Confirm == 0)
            {
                Console.WriteLine("The food will be delivered soon.");

            }
            else if (Confirm == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Choose new food");
                FOODPANDA();
            }
            else if (Confirm > 1)
            {
                Console.WriteLine("Please input 0 or 1");
                FOODPANDA();
            }
        }
        static void LINEMAN()
        {
            
            Console.WriteLine();
            Console.WriteLine("APP LINE MAN");
            Console.WriteLine();
            Console.WriteLine("MUNU FOOD");
            Console.Write("INPUT NAME FOOD IN ENGLISH :");
            string inputnamefood = Console.ReadLine();

            Console.WriteLine("push 0 => Confirm order");
            Console.WriteLine("push 1 => Cancel order");
            int Confirm = int.Parse(Console.ReadLine());

            if (Confirm == 0)
            {
                Console.WriteLine("The food will be delivered soon." );

            }
            else if (Confirm == 1)
            {
                Console.WriteLine("Choose new food");
                LINEMAN();
            }
            else if (Confirm > 1)
            {
                Console.WriteLine("Please input 0 or 1");
                LINEMAN();
            }
        }
        static void UberEats()
        {
            
            Console.WriteLine();
            Console.WriteLine("APP UBER EATS");
            Console.WriteLine();
            Console.WriteLine("MUNU FOOD");
            Console.Write("INPUT NAME FOOD IN ENGLISH  :");
            string inputnamefood = Console.ReadLine();

            Console.WriteLine("push 0 => Confirm order");
            Console.WriteLine("push 1 => Cancel order");
            int Confirm = int.Parse(Console.ReadLine());

            if (Confirm == 0)
            {
                Console.WriteLine("The food will be delivered soon.");

            }
            else if (Confirm == 1)
            {
                Console.WriteLine("Choose new food");
                UberEats();
            }
            else if (Confirm > 1)
            {
                Console.WriteLine("Please input 0 or 1");
                UberEats();
            }
        }
        static void Grabfood()
        {
            
            Console.WriteLine();
            Console.WriteLine("APP GRAB FOOD");
            Console.WriteLine();
            Console.WriteLine("MUNU FOOD");
            Console.Write("INPUT NAME FOOD IN ENGLISH  :");
            string inputnamefood = Console.ReadLine();

            Console.WriteLine("push 0 => Confirm order");
            Console.WriteLine("push 1 => Cancel order");
            int Confirm = int.Parse(Console.ReadLine());

            if (Confirm == 0)
            {
                Console.WriteLine("The food will be delivered soon.");

            }
            else if (Confirm == 1)
            {
                Console.WriteLine("Choose new food");
                Grabfood();
            }
            else if (Confirm > 1)
            {
                Console.WriteLine("Please input 0 or 1");
                Grabfood();
            }
        }
        static void Getfood()
        {
            
            Console.WriteLine();
            Console.WriteLine("APP GET FOOD");
            Console.WriteLine();
            Console.WriteLine("MUNU FOOD");
            Console.Write("INPUT NAME FOOD IN ENGLISH :");
            string inputnamefood = Console.ReadLine();

            Console.WriteLine("push 0 => Confirm order");
            Console.WriteLine("push 1 => Cancel order");
            int Confirm = int.Parse(Console.ReadLine());

            if (Confirm == 0)
            {
                Console.WriteLine("The food will be delivered soon.");

            }
            else if (Confirm == 1)
            {
                Console.WriteLine("Choose new food");
                Getfood();
            }
            else if (Confirm > 1)
            {
                Console.WriteLine("Please input 0 or 1");
                Getfood();
            }
        }
    }
}

   


