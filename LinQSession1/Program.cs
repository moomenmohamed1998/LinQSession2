using System.Security.Cryptography;
using System.Threading;
using System.Windows.Markup;
using LinQSession1.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LinQSession1.ListGenerator;
namespace LinQSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region 1- Find all products that are out of stock.

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            #endregion

            #region 2- Find all products that are in stock and cost more than 3.00 per unit


            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.000M);

            #endregion

            #region 3-Returns digits whose name is shorter than their value.

            //var Result = ProductList.Where(p => p.ProductName.Length < p.UnitPrice); 
            #endregion

            #endregion

            //----------------------------------------

            #region LINQ - Element Operators

            #region 1-Get first Product out of Stock 

            //var Result = ProductList.First(P=>P.UnitsInStock==0);
            //Console.WriteLine(Result);


            #endregion
            #region 2-Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock > 1000);
            //Console.WriteLine(Result?.ProductName ?? "Null");

            #endregion
            #region 3-Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(p => p > 5)
            //                .Skip(1)
            //                .FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #endregion

            //----------------------------------------

            #region LINQ - Aggregate Operators

            #region 1-Uses Count to get the number of odd numbers in the array 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //int Result = Arr.Count(P => P % 2 != 0);

            //Console.WriteLine(Result);

            #endregion

            #region 4- Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion


            #endregion

            //----------------------------------------

            #region LINQ - Ordering Operators

            #region 1-Sort a list of products by name
            //var Result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var product in Result)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}");
            //}
            #endregion

            #region 2-Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(P => P, StringComparer.OrdinalIgnoreCase);

            //foreach (var P in Result)
            //{
            //    Console.WriteLine(P);
            //}

            #endregion

            #region 3-Sort a list of products by units in stock from highest to lowest

            //var Result = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4-Sort a list of digits, first by length of their name, and then alphabetically by the name itself

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr
            //    .OrderBy(P => P.Length)
            //    .ThenBy(P => P);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5- Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr
            //          .OrderBy(P => P.Length)
            //          .ThenBy(P => P, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6-Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ProductList
            //            .OrderBy(p => p.Category)
            //            .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7 - Sort first by-word length and then by a case-insensitive descending sort of the words in an array
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr
            //           .OrderBy(P => P.Length)
            //           .ThenByDescending(P => P, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 8-Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};


            //var Result = Arr
            //    .Where(P => P.Length > 1 && P[1] == 'i')
            //    .Reverse();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            //----------------------------------------

            #region LINQ–Transformation Operators

            #region 1- Return a sequence of just the names of a list of products

            //var Result = ProductList.Select(p => p.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2-Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types)


            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(P => new
            //{
            //    Upper = P.ToUpper(),
            //    Lower = P.ToLower()
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3-Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type

            //var Result = ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,  
            //    p.Category
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4- Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((value, index) => new
            //{
            //    Value = value,
            //    Index = index,
            //    Matche = value == index
            //});

            //foreach (var item in Result)
            //{

            //    Console.WriteLine($" {item.Value} : {item.Matche}");
            //}
            #endregion

            #endregion

            //----------------------------------------

            #region LINQ - Set Operators

            #region 1-Find the unique Category names from Product List

            //var Result = ProductList.Select(p => p.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            //----------------------------------------

            #region LINQ - Quantifiers



            #endregion


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




        }
    }
}
