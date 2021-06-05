using System;

namespace homework_6_1
{
    class Program
    {
        struct Problem
        {
            public string Message;

            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        static void Menu(double ScoreNow,int Difficultypass)
        {
            
            int page;
            int a = 0;
            double Qc = 0;
            while (a != 1)
            {
                Console.Write(" Input your Menu : ");
                int.TryParse(Console.ReadLine(), out page);

                if (page == 0)
                {
                    Console.WriteLine("Play games");
                    a = 1;
                    Console.Write("Input your Difficulty :");
                    Difficultypass = int.Parse(Console.ReadLine());
                    page = 2 * Difficultypass + 3;

                    if (Difficultypass == 0)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);


                        Console.WriteLine("Difficulty is Easy");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        ScoreNow = ScoreNow + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));

                        Console.WriteLine("Score :" + ScoreNow);
                        Menu(ScoreNow, Difficultypass);
                    }
                    else if (Difficultypass == 1)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);

                        Console.WriteLine("Difficulty is Normal");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        ScoreNow = ScoreNow + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));
                        Console.WriteLine("Score :" + ScoreNow);
                        Menu(ScoreNow, Difficultypass);
                    }
                    else if (Difficultypass == 2)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);


                        Console.WriteLine("Difficulty is Easy");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        ScoreNow = ScoreNow + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));
                        Console.WriteLine("Score :" + ScoreNow);
                        Menu(ScoreNow, Difficultypass);
                    }
                }
                else if (page == 1)
                {
                    Console.WriteLine("Set up");
                    a = 1;
                    Console.WriteLine(" YOUR LEVEL. ");
                    Console.WriteLine(" Difficulty 0 = Easy ");
                    Console.WriteLine(" Difficulty 1 = Normal ");
                    Console.WriteLine(" Difficulty 2 = Hard ");
                    Console.WriteLine();
                    int Difficulty;
                    int i = 0;

                    Console.Write(" Score Now : 0 ,");
                    Console.Write(" Input your Difficulty : ");

                    while (i != 1)
                    {
                        int.TryParse(Console.ReadLine(), out Difficulty);

                        if (Difficulty == 0)
                        {
                            Console.WriteLine("Your difficulty easy");
                            i = 1;
                            Menu(ScoreNow, Difficultypass);
                        }
                        else if (Difficulty == 1)
                        {
                            Console.WriteLine("Your difficulty Normal");
                            i = 1;
                            Menu(ScoreNow, Difficultypass);
                        }
                        else if (Difficulty == 2)
                        {
                            Console.WriteLine("Your difficulty Hard");
                            i = 1;
                            Menu(ScoreNow, Difficultypass);
                        }
                        else
                        {
                            Console.WriteLine("Please input 0 OR 1 OR 2 Only.");
                            Console.Write(" Input your Difficulty : ");
                            i = 2;
                        }
                    }
                }
                else if (page == 2)
                {
                    Console.WriteLine("Exit the program");
                    a = 1;
                }
                else
                {
                    Console.WriteLine("Please input Number 0 - 2.");
                    Console.Write(" Input your Number : ");
                    Console.WriteLine();
                    a = 2;
                }
            }
        }

        static void Main(string[] args)
        {
            int Difficultypass = 0;
            double ScoreNow = 0;
            Difficulty level = 0;
            Console.WriteLine(" Score: {0}, Difficulty: {1} ", ScoreNow, level);
            Menu(ScoreNow, Difficultypass);
        }
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];
            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            } 
            return randomProblems;
        }



    }
}
    

