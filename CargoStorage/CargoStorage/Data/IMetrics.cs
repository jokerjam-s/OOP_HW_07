using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    /** 
     * метрика, интерфейс для задания единиц измерения
     */
    public interface IMetrics<T>
    {
        T GetMetrics();

        void SetMetrics(T value);
    }
}
