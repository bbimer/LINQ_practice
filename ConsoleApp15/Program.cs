using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*-----------------------------------------------*/
            // 1
            //int[] ints = { 16, 21, 2, 6, 8, 1, 3, 12, 18, 4, 5, 9, 7, 10 };

            //var printQuery =
            //    from i in ints
            //    select i;

            //foreach (var item in printQuery) Console.Write($"{item} ");


            //var evenQuery =
            //    from i in ints
            //    where i % 2 == 0
            //    select i;

            //Console.WriteLine();
            //foreach (var item in evenQuery) Console.Write($"{item} ");


            //var oddQuery = 
            //    from i in ints
            //    where i % 2 != 0
            //    select i;

            //Console.WriteLine();
            //foreach (var item in oddQuery) Console.Write($"{item} ");


            //int goodNumber = 7;
            //IEnumerable<int> goodQuery =
            //    from i in ints
            //    where i > goodNumber
            //    select i;

            //Console.WriteLine();
            //foreach (var item in goodQuery) Console.Write($"{item} ");

            //int start = 3, end = 5;

            //var rangeQuery =
            //from i in ints
            //where i >= start && i <= end
            //select i;

            //Console.WriteLine();
            //foreach (var item in rangeQuery) Console.Write($"{item} ");

            //var mult7_Query =
            //from i in ints
            //where i % 7 == 0
            //orderby i
            //select i;

            //Console.WriteLine();
            //foreach (var item in mult7_Query) Console.Write($"{item} ");

            //var mult8_Query =
            //from i in ints
            //where i % 8 == 0
            //orderby i descending
            //select i;

            //Console.WriteLine();
            //foreach (var item in mult8_Query) Console.Write($"{item} ");

            /*-----------------------------------------------*/
            // 2
            string[] citiesOver500k = { "Київ", "Харків", "Одеса", "Дніпро", "Запоріжжя", "Львів", "Кривий Ріг", "Ne Одеса" };

            var printQuery =
                from i in citiesOver500k
                select i;

            Console.WriteLine(string.Join(", ", printQuery));

            int str_length = 4;
            var lQuery =
                from i in citiesOver500k
                where i.Length == str_length
                select i;
            
            Console.WriteLine(string.Join(", ", lQuery));

            var A_Query =
                from i in citiesOver500k
                where i[0] == 'А'
                select i;

            if (A_Query.Count() > 0) Console.WriteLine(string.Join(", ", A_Query));
            else Console.WriteLine("пусто");

            var M_Query =
                from i in citiesOver500k
                    where char.ToLower(i[i.Length - 1]) == 'м'
                    select i;

            if (M_Query.Count() > 0) Console.WriteLine(string.Join(", ", M_Query));
            else Console.WriteLine("пусто");

            var K_Query =
            from i in citiesOver500k
                where i[0] == 'К'
                orderby i descending
                select i;

            if (K_Query.Count() > 0) Console.WriteLine(string.Join(", ", K_Query));
            else Console.WriteLine("пусто");

            var Ne_Query =
                from i in citiesOver500k
                where i.StartsWith("Ne")
                orderby i descending
                select i;

            if (Ne_Query.Count() > 0) Console.WriteLine(string.Join(", ", Ne_Query));
            else Console.WriteLine("пусто");
        }
    }
}
