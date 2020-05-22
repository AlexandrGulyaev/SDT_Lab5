using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gulyaev_AG_5
{
    interface ITreatmentState
    {
        /// <summary>
        /// Метод лечения игрока в соответствии с выбранным состоянием
        /// </summary>
        void Treat();
    }
}
