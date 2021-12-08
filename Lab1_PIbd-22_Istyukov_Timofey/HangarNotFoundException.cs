using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс-ошибка "Если не найден самолёт по определенному месту"
    /// </summary>   
    class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Не найден самолёт по месту " + i) { }
    }
}
