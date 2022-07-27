using System;

namespace cs_con_LibMgmtSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library("My Public Library");

            lib.Add(new Book2("Book 1", 2));
            lib.Add(new Book2("Book 2", 5, "Author#1"));
            lib.Add(new Book2("Book 3", 7, "Autor#1", "Author#2"));
            lib.Add(new Book2("Book 4", 1));
            lib.Add(new Newspaper("Times of India", new DateTime(2022, 11, 15)));
            lib.Add(new Newspaper("The Hindu", DateTime.Now));

            lib.DisplayLibraryItems();

            lib
        }

        private static void Demo02()
        {
            Book2 bk1 = new Book2(
                "Experiments with Truth", 5);
            Console.WriteLine(bk1);
            Console.WriteLine();

            Book2 bk2 = new Book2(
                "Experiments with Truth", 2,
                new string[] { "Mahatma Gandhi" });
            Console.WriteLine(bk2);
            Console.WriteLine();

            Book2 bk3 = new Book2(
                "Experiments with Truth", 3,
                new string[] { "Mahatma Gandhi", "Mohandas Karamchand Gandhi" });
            Console.WriteLine(bk3);
            Console.WriteLine();

        }

        private static void Demo01()
        {
            Book1 bk1 = new Book1(
                "Experiments with Truth", 5);
            Console.WriteLine(bk1);
            Console.WriteLine();

            Book1 bk2 = new Book1(
                "Experiments with Truth", 2,
                new string[] { "Mahatma Gandhi" });
            Console.WriteLine(bk2);
            Console.WriteLine();

            Book1 bk3 = new Book1(
                "Experiments with Truth", 3,
                new string[] { "Mahatma Gandhi", "Mohandas Karamchand Gandhi" });
            Console.WriteLine(bk3);
            Console.WriteLine();
        }
    }
}
