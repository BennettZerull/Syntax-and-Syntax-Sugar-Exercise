namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var awnser = 4;
            var response = (awnser < 9) ? $"{awnser} is less then nine." : $"{awnser} is greater then nine.";
            Console.WriteLine(response);
        }
    }
}
