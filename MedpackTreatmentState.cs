using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class MedpackTreatmentState : ITreatmentState
    {
        /// <summary>
        /// Метод лечения игрока аптечкой
        /// </summary>
        public void Treat()
        {
            Treatment.bleeding = false;
            Treatment.hp = 100;
            Treatment.maxhp = 100;
            Treatment.infection = 0;
            Console.WriteLine("Кровотечение остановлено.");
            Console.WriteLine("Инфекция вылечена.");
            Console.WriteLine("Здоровье полностью восстановлено.");
        }
    }
}
