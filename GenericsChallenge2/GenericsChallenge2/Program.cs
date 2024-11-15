using GenericsChallenge2.Classes;
namespace GenericsChellenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var testList = new List<string>() { "hello", "world" };
            var newDict = new Dictionary<int, string>
            {
                {1, "peas" },
                {2, "ye;low" },
            };

            static T GetLast<T>(T[] array)
            {
                return array[^1];
            }
            
            double[] doubleArray = { 10.5, 60.5, 2.2, 8.76, 6.1111 };
            string[] stringArray = { "hello", "world", "it's", "northcoders!" };

            Console.WriteLine(GetLast(ints));
            Console.WriteLine(GetLast(doubleArray));
            Console.WriteLine(GetLast(stringArray));

            Stack<string> favouriteBooks = new Stack<string>();
            favouriteBooks.Push("The Bible");
            favouriteBooks.Push("The Quran");
            favouriteBooks.Push("The Hungry Caterpillar");
            Console.WriteLine(favouriteBooks.Count);
            Console.WriteLine(favouriteBooks.Pop());
            Console.WriteLine(favouriteBooks.Count);

            foreach (string book in favouriteBooks)
            {
                Console.WriteLine(book);
            }*/

            int[] numbers = { 1, 2, 3 };
            /*   int[] numbers2 = new int[numbers.Length - 1];
               Array.Copy(numbers, numbers2, numbers.Length - 1);

               for (int i = 0; i < numbers2.Length; i++)
               {
                   Console.WriteLine(numbers2[i]);
               }
   */
            CustomStack<int> stack1 = new CustomStack<int>(numbers);
            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------------");

            stack1.Pop();

            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }

            //foreach (int i in stack1)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine();

            stack1.Push(6);

            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }


        }
    }
}
