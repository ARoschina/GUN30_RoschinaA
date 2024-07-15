class Program
{
    static void Main(string[] args)
    {
        int x;

        // To write smth in console
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        var s = Console.ReadLine(); // Mathematical operator
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Wrong operator!");
            return;
        }

        // Mathematical operations
        switch (s[0])
        {
            case '+':
                x = a + b;
                Console.WriteLine("Result of {0}+{1}={2}/{3}/{4}", a, b, x, Convert.ToString(x, 16), Convert.ToString(x, 2));
                break;
            case '-':
                x = a - b;
                Console.WriteLine("Result of {0}-{1}={2}/{3}/{4}", a, b, x, Convert.ToString(x, 16), Convert.ToString(x, 2));
                break;
            case '*':
                x = a * b;
                Console.WriteLine("Result of {0}*{1}={2}/{3}/{4}", a, b, x, Convert.ToString(x, 16), Convert.ToString(x, 2));
                break;
            case '/':
                x = a / b;
                Console.WriteLine("Result of {0}/{1}={2}/{3}/{4}", a, b, x, Convert.ToString(x, 16), Convert.ToString(x, 2));
                break;
            case '&': //Binary system                
                Console.WriteLine("Result of {0}&{1}={2}", a, b, Convert.ToString(a & b, 2));
                break;
            case '|':
                Console.WriteLine("Result of {0}|{1}={2}", a, b, Convert.ToString(a | b, 2));
                break;
            case '^':
                Console.WriteLine("Result of {0}^{1}={2}", a, b, Convert.ToString(a ^ b, 2));
                break;
            default:
                Console.WriteLine("Wrong sign!");
                break;
        }
    }
}