using System;

namespace PrintFace
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("  Hello, world! ");
        }

        public static void SayHelloUser(string userName)
        {
            Console.WriteLine("Hello, " + userName + "!");
        }

        public static void PrintFace()
        {
            string face = " +\"\"\"\"\"+\n" +
                              "(| o o |)\n" +
                              " |  ^  |\n" +
                              " | '-' |\n" +
                              " +-----+";
            Console.WriteLine(face);
        }
    }
}
