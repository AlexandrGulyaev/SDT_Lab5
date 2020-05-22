using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class TabletTreatmentState : ITreatmentState
    {
        /// <summary>
        /// Метод лечения игрока таблеткой
        /// </summary>
        public void Treat()
        {
            Treatment.hp = (byte)(Treatment.hp + 15);
            Treatment.maxhp = (byte)(Treatment.maxhp + 30);
            Treatment.infection = 0;
            Console.WriteLine("Инфекция вылечена.");
        }
    }
}
