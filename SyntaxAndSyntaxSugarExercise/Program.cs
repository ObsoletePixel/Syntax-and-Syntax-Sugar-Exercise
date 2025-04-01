namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var i = 4;
            var response = (i>9) ? $"{i} is larger than 9" : $"{i} is smaller than 9";
            Console.WriteLine(response);
        }
    }
}
