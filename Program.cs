using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer gamingPC = new ComputerBuilder()
                                    .SetCPU("Intel i9")
                                    .SetRAM("32GB")
                                    .SetStorage("1TB SSD")
                                    .SetGPU("RTX 4080")
                                    .Build();

            gamingPC.ShowDetails();

            Console.ReadLine();
        }
    }
}