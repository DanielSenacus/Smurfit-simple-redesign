namespace Development_Test_2
{
    internal class Program
    {
        class SK_Accounts
        {

            public SK_Accounts()
            {
                Console.WriteLine("Constructor called.");
            }

            // destructor
            ~SK_Accounts()
            {
                Console.WriteLine("Destructor called.");
            }

            public static void Main(string[] args)
            {

                //creates object of Person
                SK_Accounts p1 = new SK_Accounts();
            }
        }
    }
}