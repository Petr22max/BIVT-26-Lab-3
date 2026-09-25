using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double d = Math.Sqrt(x * x + y * y);

                if (d >= r1 && d <= r2)
                {
                    count++;
                }
            }

            // end

            return count;
        }

        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                bool f = false;
                for (int j = 0; j < 4; j++)
                {
                    int x = int.Parse(Console.ReadLine());
                    s += x;
                    if (x == 2)
                    {
                        f = true;
                    }
                }
                if (f)
                {
                    count++;
                }
            }
            if (n > 0)
            {
                average = (double)s / (n * 4);
            }
            // end

            return (count, average);
        }

        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            for (int i = 0; i < exams; i++)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    double x = a * 0.4 + b * 0.6;

    if (x > 85)
        avgMark += 5;
    else if (x > 70)
        avgMark += 4;
    else if (x > 50)
        avgMark += 3;
    else
        avgMark += 2;
}

if (exams > 0)
    avgMark /= exams;

            // end

            return avgMark;
        }

        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here

            // end

            return (solution, attempts);
        }

        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            // end

            return luck;
        }
    }
}
