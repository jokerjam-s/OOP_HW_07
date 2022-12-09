using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    public interface ICost
    {
        double GetCost();

        // расчет стоимости хранения 
        /**
         * @start  - начало хранеия грузи 
         * @end    - окончание ранеия груза
         * @price  - цена за сутки
         */
        void CalcCost(DateTime start, DateTime end, double price);
    }
}
