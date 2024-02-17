namespace FluentBuilderInheritance
{
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