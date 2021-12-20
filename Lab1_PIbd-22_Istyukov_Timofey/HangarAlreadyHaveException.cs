using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс-ошибка "Если в ангаре уже есть самолёт с такими же характеристиками"
    /// </summary>   
    class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("В ангаре уже есть такой самолёт") { }
    }
}
