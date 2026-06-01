using System;

class GameManager
{
    private static GameManager obj;

    public int score = 0;
    public int level = 1;

    private GameManager()
    {
        Console.WriteLine("Game Manager Started");
    }

    public static GameManager GetInstance()
    {
        if (obj == null)
        {
            obj = new GameManager();
        }

        return obj;
    }

    public void AddScore(int s)
    {
        score += s;
    }

    public void NextLevel()
    {
        level++;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Score: " + score);
        Console.WriteLine("Level: " + level);
    }
}