using System;

class Program
{
    static void Main()
    {
        GameManager g1 = GameManager.GetInstance();

        g1.AddScore(100);
        g1.NextLevel();

        GameManager g2 = GameManager.GetInstance();

        g2.AddScore(50);

        g2.ShowStatus();

        if (g1 == g2)
        {
            Console.WriteLine("Same Game Manager Object");
        }
        else
        {
            Console.WriteLine("Different Objects");
        }
    }
}