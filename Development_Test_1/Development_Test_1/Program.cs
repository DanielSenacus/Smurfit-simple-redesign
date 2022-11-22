namespace Development_Test_1
{
    internal class Program
    {

        static string integer_to_string(int n, int base1)
        {
            string str = "";
            while (n > 0)
            {
                int digit = n % base1;
                n /= base1;
                str += (char)(digit + '0');
            }
            return str;
        }


        static int isPalindrome(int i, int k)
        {
            int temp = i;

            // m stores reverse of a number
            int m = 0;
            while (temp > 0)
            {
                m = temp % 10 + m * 10;
                temp /= 10;
            }

            // if reverse is equal to number
            if (m == i)
            {

                // converting to base 
                string str = integer_to_string(m, k);
                char[] ch = str.ToCharArray();
                Array.Reverse(ch);
                string str1 = new String(ch); ;
                if (str.Equals(str1))
                {
                    return i;
                }
            }
            return 0;
        }

        // find sum of all palindromes
        static void sumPalindrome(int n, int k)
        {

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum += isPalindrome(i, k);
            }
            Console.WriteLine("Total sum is " + sum);
        }

        // driver function
        static void Main()
        {
            int n = 1000000; // Max integer number
            int k = 2; // Binary base

            sumPalindrome(n, k);
        }
    }
}