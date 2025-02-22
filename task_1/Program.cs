namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("""
                Welcome to Islam Carpet Cleaning Service!
                    We charges:
                    $25 per small carpet
                    $35 per large carpet

                    Note: Estimates are valid for 30 days
                    Sales tax rate is 6% 

                    Estimate for carpets cleaning service:
                """);
            Console.Write("Number of small carpets: ");
            int smallOnes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int largeOnes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"""
                Price per small one: $25
                Price per large one: $35
                Cost : ${(smallOnes*25) + (largeOnes*35)}
                Tax : ${((smallOnes*25) + (largeOnes*35)) * 0.06}
                =======================================
                Total estimates: ${((smallOnes * 25) + (largeOnes * 35)) * 1.06}
                This estimate is valid for 30 days only
                """);
            
        }
    }
}
