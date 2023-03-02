using System;

namespace Homework_1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Input yous password : ");
            int password = int.Parse(Console.ReadLine());
            
            bool seven = password.ToString().Contains("7");
            bool factors = (password % 10 == 3 || password % 10 == 5 || password % 10 == 6 || password % 10 == 2 || password % 10 == 1);

            Console.Write("Input yous agency : ");
            string agency = Console.ReadLine();
            
            string CIA = "CIA"; 
            string FBI = "FBI";
            string NSA = "NSA";

            if ( agency == CIA && password % 10 % 3 == 0 && (password / 10) % 10 != 1 && (password / 10) % 10 != 3 && (password / 10) % 10 != 5 && (password / 1000) % 10 >= 6 && (password / 1000) % 10 != 8 ) {
                bool resulti1 = (agency == CIA);
                Console.WriteLine("Password is : {0}", resulti1);
            } else if ( agency == FBI && password >= 400000 && password <= 799999 && (password / 100) % 10 % 2 == 0 && (password / 100) % 10 != 6 && password / 10000 % 10 % 2 != 0 ) {
                bool resulti2 = ( agency == FBI );
                Console.WriteLine("Password is : {0}", resulti2);
            } else if ( agency == NSA && factors && (password / 100) % 10 % 3 == 0 && (password / 100) % 10 % 2 != 0 && seven ) {
                bool resulti3 = ( agency == NSA );
                Console.WriteLine("Password is : {0}", resulti3);
            } else {
                bool False = false;
                Console.WriteLine("Password is : {0}", False);
            }
        }
    }
}