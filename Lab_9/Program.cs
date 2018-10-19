using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //check
            string keepGoing; //will be used later for checking for continue or exit of program
            int sID; //going to try and use this to pass keys into methods
            

            Hashtable studentList = new Hashtable();
            {
                studentList.Add(01, "Micheal Hern");
                studentList.Add(02, "Taylor Everts");
                studentList.Add(03, "Joshua Zimmerman");
                studentList.Add(04, "Lin-Z Chang");
                studentList.Add(05, "Madelyn Hilty");
                studentList.Add(06, "Nana Banahene");
                studentList.Add(07, "Rochelle Toles");
                studentList.Add(08, "Shah Shahid");
                studentList.Add(09, "Tim Broughton");
                studentList.Add(10, "Abby Wessels");
                studentList.Add(11, "Blake Shaw");
                studentList.Add(12, "Bob Valentic");
                studentList.Add(13, "Jordan Owiesny");
                studentList.Add(14, "Jay Stiles");
                studentList.Add(15, "Jon Shaw");
            };

            //get student from list
            // foreach (string key in studentList.Keys)
            //{
            //    Console.WriteLine(String.Format("{0}: {1}", key, studentList[key]));
            //}
            
            Console.Write("Enter a number for a student that you would like to know about: ");
            string studentID = (Console.ReadLine());
            sID = int.Parse(studentID);
            Console.WriteLine("You chose: " + (studentList[sID]));



            //ask what you want to know about student
            Console.WriteLine("What would you like to learned about this student? ");
            Console.WriteLine("Enter (1) for Hometown");
            Console.WriteLine("Enter (2) for Favorite Food");
            Console.WriteLine("Enter (3) for Favorite Number");
            string studentInfoReq = (Console.ReadLine());
            

            //send to method method via if statements
            
            if (studentInfoReq == "1")
            {
                
                HomeTownMeth(sID);

            }
            if (studentInfoReq == "2")
            {
                FFMeth(sID);
               
            }
            if (studentInfoReq == "3")
            {
                NumMeth(sID);
                
            }
            else
            {
                return;
            }




        }
        //The Methods!
        
        //Hometown
        static void HomeTownMeth(int sID)
        {
            Hashtable studentTown = new Hashtable();
            {
                studentTown.Add(01, "Canton");
                studentTown.Add(02, "Caro");
                studentTown.Add(03, "Taylor");
                studentTown.Add(04, "Toledo");
                studentTown.Add(05, "Oxford");
                studentTown.Add(06, "Guana");
                studentTown.Add(07, "Mars");
                studentTown.Add(08, "Newark");
                studentTown.Add(09, "Detroit");
                studentTown.Add(10, "Traverse City");
                studentTown.Add(11, "Los Angeles");
                studentTown.Add(12, "St. Clair Shores");
                studentTown.Add(13, "Warren");
                studentTown.Add(14, "Macomb");
                studentTown.Add(15, "Huntington Woods");
            };
            //Console.WriteLine("They are from : " + studentTown);

            Console.WriteLine("Their hometown is: " + studentTown[sID]);
        }
        //FavFood
        private static string FFMeth(int sID)
        {
            Hashtable studentFood = new Hashtable();
            {
                studentFood.Add(01, "Chicken Wings");
                studentFood.Add(02, "Cordon Bleu");
                studentFood.Add(03, "Turkey");
                studentFood.Add(04, "Ice Cream");
                studentFood.Add(05, "Croissent");
                studentFood.Add(06, "Empanadas");
                studentFood.Add(07, "Space Cheese");
                studentFood.Add(08, "Chicken Wings");
                studentFood.Add(09, "Chicken Parm");
                studentFood.Add(10, "Soup");
                studentFood.Add(11, "Cannolis");
                studentFood.Add(12, "Pizza");
                studentFood.Add(13, "Burgers");
                studentFood.Add(14, "Pickles");
                studentFood.Add(15, "Ribs");
            };
            Console.WriteLine("Their favorite food is: " + studentFood[sID]);
            return "x";
            
        }
        //FavNumber
        private static string NumMeth(int sID)
            {
                Hashtable studentFavNum = new Hashtable();
                {
                    studentFavNum.Add(01, "7");
                    studentFavNum.Add(02, "14");
                    studentFavNum.Add(03, "18");
                    studentFavNum.Add(04, "275");
                    studentFavNum.Add(05, "38");
                    studentFavNum.Add(06, "75");
                    studentFavNum.Add(07, "88");
                    studentFavNum.Add(08, "314");
                    studentFavNum.Add(09, "22");
                    studentFavNum.Add(10, "99");
                    studentFavNum.Add(11, "225");
                    studentFavNum.Add(12, "10");
                    studentFavNum.Add(13, "54");
                    studentFavNum.Add(14, "78");
                    studentFavNum.Add(15, "2");
                };
            Console.WriteLine("Their favorite number is: "+ studentFavNum[sID]);
            return "x";
        }
        
    }
}