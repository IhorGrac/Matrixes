namespace Matrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();  
            
            matrix.PrintTheMatrix();

            var trace = matrix.FindTrace();
            
            Console.WriteLine($"The trace of the matrix is equal to: {trace}" );
        }
    }
}