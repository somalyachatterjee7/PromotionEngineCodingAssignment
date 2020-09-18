using System;

namespace PromotionEngineCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of Products type 'A':");
            var AtypeProducts = Console.ReadLine();
            Console.WriteLine("Please enter number of Products type 'B':");
            var BtypeProducts = Console.ReadLine();
            Console.WriteLine("Please enter number of Products type 'C':");
            var CtypeProducts = Console.ReadLine();
            Console.WriteLine("Please enter number of Products type 'D':");
            var DtypeProducts = Console.ReadLine();
            Console.WriteLine(GetPromotionItemSets(10, 3));
            Console.ReadKey();
        }
        static Tuple<int, int> GetPromotionItemSets(int nuberofProducts, int offerSetValue)
        {
            var mean = nuberofProducts + offerSetValue / 2;
            var nonPromotionItemCount = nuberofProducts - (mean - (mean % offerSetValue));
            var offerSet = (mean % offerSetValue);
            return new Tuple<int, int>(offerSet, nonPromotionItemCount);
        }
    }
}
