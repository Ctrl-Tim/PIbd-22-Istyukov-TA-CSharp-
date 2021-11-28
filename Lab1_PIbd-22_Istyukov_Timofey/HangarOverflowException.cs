using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже заняты все места"
    /// </summary> 
    class HangarOverflowException : Exception
    {
        public HangarOverflowException() : base("В ангаре нет свободных мест") { }
    }
}
