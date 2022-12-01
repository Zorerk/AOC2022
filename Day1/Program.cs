namespace Day1 // Note: actual namespace depends on the project name.
{

    struct ELFS
    {
        public int Max1,Max2,Max3;
        public int Id;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Day1 day = new Day1();
            day.Traverse();
        }
    }

    class Day1
    {
        private string[] data;
        private int[] elfs;
        private ELFS elf;

        public Day1()
        {
            //Read data file
            data = File.ReadAllLines("data.txt");
            elf.Max1 = 0;
            elf.Max2 = 0;
            elf.Max3 = 0;

            elfs = new int[GetAmountNumberOfElfs()];

        }

        private int GetAmountNumberOfElfs()
        {
            int i = 0;
            foreach (string? d in data)
            {
                int number = 0;
                if (!Int32.TryParse(d, out number))
                {
                    i++;
                }
            }
            return i + 1;
        }


        public void Traverse()
        {
            int i = 0;
            foreach (string? d in data)
            {
                int number = 0;
                if (Int32.TryParse(d, out number))
                {
                    this.elfs[i] += number;
                }
                else
                {
                    if(elfs[i] > elf.Max1){
                        elf.Max3 = elf.Max2;
                        elf.Max2 = elf.Max1;
                        elf.Max1 = elfs[i];
                    }
                    
                    i++;
                }
            };

            Console.WriteLine("Max Calories: {0}", elf.Max1);
            Console.WriteLine("Top 3: {0}", elf.Max1+elf.Max2+elf.Max3);

        }

    }
}