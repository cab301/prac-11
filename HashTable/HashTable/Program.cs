namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHashtable hashtable = new HashtableLinear(7);
            hashtable.Print();
            int[] numsToAdd = { 374, 1091, 911, 227, 421, 161, 83 };
            foreach (int number in numsToAdd)
            {
                Console.WriteLine("Inserting {0}", number);
                hashtable.Insert(number);
                hashtable.Print();
            }

            int[] numsToSearch = { 1091, 83, 1092 };
            foreach (int number in numsToSearch)
            {
                Console.WriteLine("Number {0} found at {1}", number,
                    hashtable.Search(number));
            }

            int[] numsToDelete = { 911 };
            foreach (int number in numsToDelete)
            {
                Console.WriteLine("Deleting {0}", number);
                hashtable.Delete(number);
                hashtable.Print();
            }
            Console.WriteLine("Number {0} found at {1}", 83,
    hashtable.Search(83));
            //hashtable.Print();
            //int[] numsToAdd = { 59, 39, 20, 33, 58, 23, 12, 29, 57 };
            //foreach (int number in numsToAdd)
            //{
            //    Console.WriteLine("Inserting {0}", number);
            //    hashtable.Insert(number);
            //    hashtable.Print();
            //}
            //int[] numsToDelete = { 29, 39 };
            //foreach (int number in numsToDelete)
            //{
            //    Console.WriteLine("Deleting {0}", number);
            //    hashtable.Delete(number);
            //    hashtable.Print();
            //}
        }
    }
}