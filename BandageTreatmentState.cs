using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class BandageTreatmentState : ITreatmentState
    {
        public void Treat()
        {
            /// <summary>
            /// Метод лечения игрока бинтом
            /// </summary>
            Treatment.bleeding = false;
            Treatment.hp = (byte)(Treatment.hp + 5);
            Console.WriteLine("Кровотечение остановлено.");
        }
    }
}
