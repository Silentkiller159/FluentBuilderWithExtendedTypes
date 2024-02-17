namespace FluentBuilderInheritance
{
    /// <summary>
    /// Dear programmer:
    /// When I wrote this code, only god and
    /// I knew how it worked.
    /// Now, only god knows it!
    /// 
    /// Therefore, if you are trying to understand
    /// this behavior and it consumes a lot of time (most surely).
    /// Please increment this counter as a 
    /// warning for the next person:
    /// 
    /// total_hours_wasted_here = 3
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var myA = new FluentBuilderA()
                            .setFirst(10)
                            .Build();

            Console.WriteLine(myA);


            var myB = new FluentBuilderB()
                            .setFirst(10)
                            .setSecond(20)
                            .Build();

            Console.WriteLine(myB);


            var myC = new FluentBuilderC()
                            .setFirst(10)
                            .setSecond(20)
                            .setThird(30)
                            .Build();

            Console.WriteLine(myC);
        }
    }
}