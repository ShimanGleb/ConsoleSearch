using System;

using ConsoleSearcher.Model;
using ConsoleSearcher.Code;

namespace ConsoleSearcher
{
    class Program
    {
        static void Main(string[] args)
        {                                    
            ModelSearcher searcher = new ModelSearcher();

            searcher.Models.Add(new MyModel { Id = 0, FirstLine = "First line", SecondLine = "Second line", ThirdLine = "Third line", Numbers = MyEnum.One });
            searcher.Models.Add(new MyModel { Id = 1, FirstLine = "First text line", SecondLine = "Second text line", ThirdLine = "Third text line", Numbers = MyEnum.One });
            searcher.Models.Add(new MyModel { Id = 2, FirstLine = "First test line", SecondLine = "Second test line", ThirdLine = "Third test line", Numbers = MyEnum.Two });
            searcher.Models.Add(new MyModel { Id = 3, FirstLine = "First random line", SecondLine = "Second random line", ThirdLine = "Third random line", Numbers = MyEnum.Two });
            searcher.Models.Add(new MyModel { Id = 4, FirstLine = "First random line", SecondLine = "Second random line", ThirdLine = "Third random line", Numbers = MyEnum.Two });
            searcher.Models.Add(new MyModel { Id = 5, FirstLine = "First line", SecondLine = "Second line", ThirdLine = "Third line", Numbers = MyEnum.Zero });
            searcher.Models.Add(new MyModel { Id = 6, FirstLine = "First line", SecondLine = "Second line", ThirdLine = "Third line", Numbers = MyEnum.Zero });

            while (true)
            {
                Console.Write("Enter text: ");

                string query = Console.ReadLine();                

                Console.WriteLine(searcher.FindModelsWithText(searcher.Models, query));
            }
        }
    }
}
