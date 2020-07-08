using System;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase.RunUseCase();
            Console.WriteLine("\n{0}\n", new string('-', 50));
            UseCase.RunUseCaseMultipleConnections();
        }
    }
}
