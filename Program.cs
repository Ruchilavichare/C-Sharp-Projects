namespace BracketsBalanced
{
    class Program
    {
        static bool AreBracketsBalanced(string s)
        {
            string prev;
            do
            {
                prev = s;
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
                Console.WriteLine(prev + "--" + s);
            } while (s != prev);

            return s.Length == 0;
        }

        static void Main()
        {
            Console.WriteLine(AreBracketsBalanced("{([])}"));  // True
            //Console.WriteLine(AreBracketsBalanced("{{)()(}}"));  // False
            //Console.WriteLine(AreBracketsBalanced("{([)]}"));  // False
            //Console.WriteLine(AreBracketsBalanced("[({})]"));  // True
            //Console.WriteLine(AreBracketsBalanced("((()))"));  // True
            //Console.WriteLine(AreBracketsBalanced("((())"));   // False
        }
    }
}
