using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    class Treatment
    {
        public static byte hp;
        public static byte infection;
        public static bool bleeding;
        public static byte maxhp;

        public ITreatmentState State { get; set; }

        /// <summary>
        /// Конструктор контекста, принимающий соответствующее состояние
        /// </summary>
        /// <param name="ts">Состояние</param>
        public Treatment(ITreatmentState ts)
        {
            State = ts;
        }

        /// <summary>
        /// Обращение к состоянию
        /// </summary>
        public void Request()
        {
            this.State.Treat();
        }
    }
}
