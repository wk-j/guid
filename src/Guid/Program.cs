using System;

namespace Guid {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0) {
                Console.WriteLine(System.Guid.NewGuid().ToString("N"));
            } else {
                var pattern = args[0];
                Console.WriteLine(System.Guid.NewGuid().ToString(pattern));
            }
        }
    }
}
