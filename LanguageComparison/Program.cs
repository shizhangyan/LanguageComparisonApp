using System;

namespace LanguageComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VBLib.Demos vb = new VBLib.Demos();

            var vbResults = vb.LoadFile();

            Console.WriteLine("VB.NET Call");
            foreach(var result in vbResults)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.WriteLine();

            CShaprLib.Demos csharp = new CShaprLib.Demos();

            var csharpResults = csharp.LoadFile();

            Console.WriteLine("C# Call");
            foreach(var result in csharpResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}
