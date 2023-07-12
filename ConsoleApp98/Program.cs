namespace ConsoleApp98
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bracketExpression;
            int currentDepthExpression = 0;
            int currentDepthExpression2 = 0;
            int maxDepthExpression = 0;
            char bracketLeft = '(';
            char bracketRight = ')';
            bool isCorretExpression = true;

            Console.Write("Введите скобочное выражение: ");
            bracketExpression = Console.ReadLine();

            for (int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == bracketLeft)
                {
                    currentDepthExpression++;
                    currentDepthExpression2++;
                }
                else if (bracketExpression[i] == bracketRight)
                {
                    currentDepthExpression--;
                }

                if (currentDepthExpression == 0)
                {
                    currentDepthExpression2 = 0;
                }

                if (maxDepthExpression < currentDepthExpression2)
                {
                    maxDepthExpression = currentDepthExpression2;
                }

                if (currentDepthExpression < 0)
                {
                    currentDepthExpression = 0;
                }

                if (bracketExpression[0] == bracketRight)
                {
                    isCorretExpression = false;
                }

                Console.WriteLine("Ваша текущая глубина выражения: " + currentDepthExpression);
                Console.WriteLine("Ваша максимальная глубина выражения: " + maxDepthExpression);
            }

            if (currentDepthExpression != 0)
            {
                isCorretExpression = false;
            }

            if (isCorretExpression == false)
            {
                Console.WriteLine("Выражение не верное.");
            }
            else if (isCorretExpression == true)
            {
                Console.WriteLine("Выражение верное.");
            }
        }
    }
}