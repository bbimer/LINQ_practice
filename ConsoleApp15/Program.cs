using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 16, 21, 2, 6, 8, 1, 3, 12, 18, 4, 5, 9, 7, 10 };

            var printQuery =
                from i in ints
                select i;

            foreach (var item in printQuery) Console.Write($"{item} ");


            var evenQuery =
                from i in ints
                where i % 2 == 0
                select i;

            Console.WriteLine();
            foreach (var item in evenQuery) Console.Write($"{item} ");


            var oddQuery = 
                from i in ints
                where i % 2 != 0
                select i;

            Console.WriteLine();
            foreach (var item in oddQuery) Console.Write($"{item} ");


            int goodNumber = 7;
            IEnumerable<int> goodQuery =
                from i in ints
                where i > goodNumber
                select i;

            Console.WriteLine();
            foreach (var item in goodQuery) Console.Write($"{item} ");

            int start = 3, end = 5;

            var rangeQuery =
            from i in ints
            where i >= start && i <= end
            select i;

            Console.WriteLine();
            foreach (var item in rangeQuery) Console.Write($"{item} ");

            var mult7_Query =
            from i in ints
            where i % 7 == 0
            orderby i
            select i;

            Console.WriteLine();
            foreach (var item in mult7_Query) Console.Write($"{item} ");

            var mult8_Query =
            from i in ints
            where i % 8 == 0
            orderby i descending
            select i;

            Console.WriteLine();
            foreach (var item in mult8_Query) Console.Write($"{item} ");
        }
    }
}
