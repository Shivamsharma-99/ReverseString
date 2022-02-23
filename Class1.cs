using System;
using System.Linq;


namespace StringProgram
{
    class Program
    {
        public void reverseString()
        {
            // ------------ Method 1. ------ using for loop --------------
            string name = "Shivam";
            var chars = name.ToCharArray();
            var length = chars.Length;

            Console.WriteLine($"String length is : {length}");
            for (var i = length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }
            Console.ReadLine();
        }
        public void Revstring()
        {

            // -------------- Method 2. ---- using Array.Reverse ----------
            string name1 = "Shivam";
            var chars1 = name1.ToCharArray();
            Array.Reverse(chars1);
            Console.Write(chars1);
            Console.ReadLine();
        }
        public void RevString()
        {
            // --------------- Method 3. -------- using String.Reverse -----
            string name = "Shivam";
            var revString = new string(name.Reverse().ToArray());
            Console.WriteLine(revString);
            Console.ReadLine();

        }
    }
}
