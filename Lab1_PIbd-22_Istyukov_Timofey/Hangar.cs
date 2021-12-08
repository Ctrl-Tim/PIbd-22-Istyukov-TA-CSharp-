using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hangar<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly List<T> _places;

        /// <summary>
        /// Максимальное количество мест в ангаре
        /// </summary>
        private readonly int _maxCount;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Размер ангара (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 215;

        /// <summary>
        /// Размер ангара (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 115;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер ангара - ширина</param>
        /// <param name="picHeight">Рамзер ангара - высота</param>
        public Hangar(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в ангар добавляется самолёт
        /// </summary>
        /// <param name="p">Ангар</param>
        /// <param name="air">Добавляемый самолёт</param>
        /// <returns></returns>
        public static int operator +(Hangar<T> h, T air)
        {
            if (h._places.Count >= h._maxCount)
            {
                throw new HangarOverflowException();
            }
            h._places.Add(air);
            return 1;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с ангара забираем самолёт
        /// </summary>
        /// <param name="p">Ангар</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Hangar<T> h, int index)
        {
            if (index < 0 || index > h._places.Count)
            {
                throw new HangarNotFoundException(index);
            }
            T obj = h._places[index];
            h._places.RemoveAt(index);
            return obj;
        }

        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);

            int x = 0;
            int y = 0;
            int j = 0;

            for (int i = 0; i < _places.Count; i++)
            {
                if (j >= pictureWidth / _placeSizeWidth)
                {
                    x = 0;
                    y += _placeSizeHeight;
                    j = 0;
                }
                _places[i]?.SetPosition(x, y + 2 * pictureWidth / _placeSizeWidth, pictureWidth, pictureHeight);
                x += _placeSizeWidth;
                j++;
            }

            for (int i = 0; i < _places.Count; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    //линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }

                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        /// <summary>
        /// Функция получения элементы из списка
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }

            return _places[index];
        }
    }
}