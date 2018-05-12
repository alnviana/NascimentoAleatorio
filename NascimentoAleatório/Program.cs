using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NascimentoAleatório {
    class Program {
        static void Main(string[] args) {
            DateTime minDate = new DateTime(1960, 1, 1);
            DateTime maxDate = new DateTime(2000, 12, 31);
            long diffTicks = maxDate.Ticks - minDate.Ticks;
            int intTicks = (int) (diffTicks / 100000000000);

            Random random = new Random(Guid.NewGuid().GetHashCode());            

            for (int i = 0; i < 1000; i++) {
                long randomTicks = random.Next(intTicks + 1) * 100000000000;
                DateTime finalDate = new DateTime(minDate.Ticks + randomTicks);
                Console.WriteLine(finalDate.ToShortDateString());
            }

            Console.ReadLine();
        }
    }
}
