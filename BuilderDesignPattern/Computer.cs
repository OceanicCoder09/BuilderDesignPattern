using System;

namespace BuilderDesignPattern
{
    public class Computer
    {
        public string CPU { get; set;}
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Computer Configuration:");
            Console.WriteLine("CPU      : " + CPU);
            Console.WriteLine("RAM      : " + RAM);
            Console.WriteLine("Storage  : " + Storage);
            Console.WriteLine("GPU      : " + GPU);
        }
    }
}