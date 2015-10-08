using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)


        

        {
           


            List<string> MovieA = new List<string>();

            MovieA.Add("returned: " + "2015, 07, 15");//returned
            MovieA.Add("checked out: " + "2015, 07, 01");//checkout
            MovieA.Add("due: " + "2015, 07, 13");//due
            MovieA.Add("MovieA" + OverDue("2015, 07,13", "2015, 07, 15")); // is it overdue?
            MovieA.Add("MovieA; Copywrite 1998");


            List<string> MovieB = new List<string>();
            MovieB.Add("returned: " + "2015, 08, 16");//returned
            MovieB.Add("checked out: " + "2015, 08, 02");//checkout
            MovieB.Add("due: " + "2015, 08, 14");//due
            MovieB.Add("MovieB:" + OverDue("2015, 08,14", "2015, 07, 03")); // is it overdue?
            MovieB.Add("MovieB; Copywrite 2009");
        

            List<string> Jameslist1 = new List<string>();
            {Jameslist1.Add("James");
                for (int i = 0; i < MovieB.Count; i++)
                {
                Jameslist1.Add( MovieB[i]);
                }
                
                
                
            }
            List<string> Annalist1 = new List<string>();
            {
                Annalist1.Add("Anna");
                for (int i = 0; i < MovieA.Count; i++)
                {
                Annalist1.Add(MovieA[i]);
                }
                
            }

            Dictionary<string, List<string>> movieOwner = new Dictionary<string, List<string>>();
            movieOwner.Add("James", MovieB);

            {
                Console.WriteLine("Enter customer name, overdue summary, or movie summary");
            

                string UI = Console.ReadLine();

                if (UI == "customer")
                {
                    Console.WriteLine("enter customer name");

             }

                string UI2 = Console.ReadLine();

                if (UI2 == "James")
                   { UI2.ToLower();

                foreach (string item in Jameslist1)
                
                    Console.WriteLine(item);
                  } 

            else if
                   (UI2 == "Anna")
                  {  UI2.ToLower();

                foreach (string item in Annalist1)
                
                    Console.WriteLine(item);

                }



                if (UI == "summary")
                {
                    foreach (string item in MovieA)
                    {
                        Console.WriteLine(item);
                    }
                        Console.WriteLine("Do you want to see the next summary? If so, press enter. Press 0 to exit");
                    string enteror0=Console.ReadLine();
                    
                    if (enteror0 == '0'.ToString())

                    {
                        return;
                    }
                   
                   
                    
}
                    
                if (UI == "movie")
                {
                    Console.WriteLine("Which movie?");
                
                string UI3 = Console.ReadLine();
                if (UI3 == "moviea")
                    {   Console.WriteLine(MovieA[0]);
                        Console.WriteLine(MovieA[1]);
                        Console.WriteLine(MovieA[2]);
                        Console.WriteLine(MovieA[3]);
                        Console.WriteLine(MovieA[4]);
                        Console.WriteLine("Rented By: Anna");
                    }

                    else if (UI3 == "movieb")
                    {
                        Console.WriteLine(MovieB[0]);
                        Console.WriteLine(MovieB[1]);
                        Console.WriteLine(MovieB[2]);
                        Console.WriteLine(MovieB[3]);
                        Console.WriteLine(MovieB[4]);
                        Console.WriteLine("Rented By: James");

                    }
                }
            }

        }
       
        static string OverDue(string dueDate, string returnDate)
        { 
            DateTime due = DateTime.Parse(returnDate);
            DateTime returned = DateTime.Parse(dueDate);

            if (due < returned)
            {
               
                return " Item is overdue and fees were applied.";
                
            }
            else
            {   return " Item is not overdue.";
            }
           
            }
        }
    }

