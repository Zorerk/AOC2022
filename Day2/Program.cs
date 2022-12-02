namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Day2 = new Day2();
            Day2.P1();
            Day2.P2();
        }
    }

    class Day2
    {
        string[] data;
        public Day2()
        {
            data = File.ReadAllLines("data.txt");
        }

        public void P1()
        {
            int score = 0;
            foreach (string? d in data)
            {
                string[] x = d.Split(" ");

                switch (x[0])
                {
                    case "A":
                        if (x[1] == "X")
                        {
                            score += 4;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 8;
                        }
                        else
                        {
                            score += 3;
                        }
                        break;
                    case "B":
                        if (x[1] == "X")
                        {
                            score += 1;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 5;
                        }
                        else
                        {
                            score += 9;
                        }
                        break;
                    case "C":
                        if (x[1] == "X")
                        {
                            score += 7;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 2;
                        }
                        else
                        {
                            score += 6;
                        }
                        break;
                }
            }
            Console.WriteLine("P1 Score: {0}", score);
        }

        public void P2()
        {
            int score = 0;
            foreach (string? d in data)
            {
                string[] x = d.Split(" ");

                switch (x[0])
                {
                    case "A":
                        if (x[1] == "X")
                        {
                            score += 3;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 4;
                        }
                        else
                        {
                            score += 8;
                        }
                        break;
                    case "B":
                        if (x[1] == "X")
                        {
                            score += 1;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 5;
                        }
                        else
                        {
                            score += 9;
                        }
                        break;
                    case "C":
                        if (x[1] == "X")
                        {
                            score += 2;
                        }
                        else if (x[1] == "Y")
                        {
                            score += 6;
                        }
                        else
                        {
                            score += 7;
                        }
                        break;

                }
            }
            Console.WriteLine("P2 Score: {0}", score);
        }

    }
}