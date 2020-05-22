using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class OintmentTreatmentState : ITreatmentState
    {
        /// <summary>
        /// Метод лечения игрока мазью
        /// </summary>
        public void Treat()
        {
            Treatment.bleeding = false;
            Treatment.hp = (byte)(Treatment.hp + 10);
            Treatment.maxhp = (byte)(Treatment.maxhp + 20);
            Console.WriteLine("Кровотечение остановлено.");
        }
    }
}
