using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс отрисовки истребителя
    /// </summary> 
    class FighterPlane : WarPlane, IEquatable<FighterPlane>
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия переднего оперения
        /// </summary>
        public bool FrontPlane { private set; get; }

        /// <summary>
        /// Признак наличия боковых бомб
        /// </summary>
        public bool SideBombs { private set; get; }

        /// <summary>
        /// Признак наличия дополнительных бомб
        /// </summary>
        public bool BigBombs { private set; get; }

        /// <summary>
        /// Признак наличия турбины
        /// </summary>
        public bool MiniBombs { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолёта</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontPlane">Признак наличия переднего спойлера</param>
        /// <param name="sideBombs">Признак наличия боковых спойлеров</param>
        /// <param name="bigBombs">Признак наличия заднего спойлера</param>
        /// <param name="miniBombs">Признак наличия гоночной полосы</param>
        public FighterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontPlane, bool sideBombs, bool bigBombs, bool miniBombs) :
            base(maxSpeed, weight, mainColor, 110, 103)
        {
            DopColor = dopColor;
            FrontPlane = frontPlane;
            SideBombs = sideBombs;
            BigBombs = bigBombs;
            MiniBombs = miniBombs;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public FighterPlane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontPlane = Convert.ToBoolean(strs[4]);
                SideBombs = Convert.ToBoolean(strs[5]);
                BigBombs = Convert.ToBoolean(strs[6]);
                MiniBombs = Convert.ToBoolean(strs[7]);
            }
        }


        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black); Brush dopBrush = new SolidBrush(DopColor);
            // отрисуем сперва переднее оперение истребителя (чтобы потом отрисовка самолёта на него "легла")
            if (FrontPlane)
            {
                Brush plane = new SolidBrush(DopColor);
                PointF[] front_plane = {
                new PointF(_startPosX + 38, _startPosY + 38),
                new PointF(_startPosX + 38, _startPosY + 65),
                new PointF(_startPosX + 25, _startPosY + 58),
                new PointF(_startPosX + 25, _startPosY + 45)};
                g.FillPolygon(plane, front_plane);
                g.DrawPolygon(pen, front_plane); //обведём
            }

            // боковые бомбы
            if (SideBombs)
            {
                Brush bomb = new SolidBrush(DopColor);
                PointF[] side_bombs1 = {
                new PointF(_startPosX + 40, _startPosY - 2),
                new PointF(_startPosX + 37, _startPosY),
                new PointF(_startPosX + 40, _startPosY + 2),
                new PointF(_startPosX + 56, _startPosY + 2),
                new PointF(_startPosX + 60, _startPosY + 4),
                new PointF(_startPosX + 60, _startPosY - 4),
                new PointF(_startPosX + 56, _startPosY - 2)};
                PointF[] side_bombs2 = {
                new PointF(_startPosX + 40, _startPosY + 101),
                new PointF(_startPosX + 37, _startPosY + 103),
                new PointF(_startPosX + 40, _startPosY + 105),
                new PointF(_startPosX + 56, _startPosY + 105),
                new PointF(_startPosX + 60, _startPosY + 107),
                new PointF(_startPosX + 60, _startPosY + 99),
                new PointF(_startPosX + 56, _startPosY + 101)};
                g.FillPolygon(bomb, side_bombs1);
                g.FillPolygon(bomb, side_bombs2);
                g.DrawPolygon(pen, side_bombs1); //обведём
                g.DrawPolygon(pen, side_bombs2);
            }

            // маленькие бомбы
            if (MiniBombs)
            {
                Brush bomb = new SolidBrush(DopColor);
                PointF[] mini_bombs1 = {
                new PointF(_startPosX + 42, _startPosY + 9),
                new PointF(_startPosX + 38, _startPosY + 10),
                new PointF(_startPosX + 42, _startPosY + 11),
                new PointF(_startPosX + 53, _startPosY + 11),
                new PointF(_startPosX + 58, _startPosY + 12),
                new PointF(_startPosX + 58, _startPosY + 8),
                new PointF(_startPosX + 53, _startPosY + 9)};
                PointF[] mini_bombs2 = {
                new PointF(_startPosX + 42, _startPosY + 91),
                new PointF(_startPosX + 38, _startPosY + 92),
                new PointF(_startPosX + 42, _startPosY + 93),
                new PointF(_startPosX + 53, _startPosY + 93),
                new PointF(_startPosX + 58, _startPosY + 94),
                new PointF(_startPosX + 58, _startPosY + 90),
                new PointF(_startPosX + 53, _startPosY + 91)};
                g.FillPolygon(bomb, mini_bombs1);
                g.FillPolygon(bomb, mini_bombs2);
                g.DrawPolygon(pen, mini_bombs1); //обведём
                g.DrawPolygon(pen, mini_bombs2);
            }

            // большие бомбы
            if (BigBombs)
            {
                Brush bomb = new SolidBrush(DopColor);
                PointF[] big_bombs1 = {
                new PointF(_startPosX + 38, _startPosY + 21),
                new PointF(_startPosX + 33, _startPosY + 25),
                new PointF(_startPosX + 38, _startPosY + 29),
                new PointF(_startPosX + 50, _startPosY + 29),
                new PointF(_startPosX + 50, _startPosY + 21)};
                PointF[] big_bombs2 = {
                new PointF(_startPosX + 38, _startPosY + 76),
                new PointF(_startPosX + 33, _startPosY + 80),
                new PointF(_startPosX + 38, _startPosY + 84),
                new PointF(_startPosX + 50, _startPosY + 84),
                new PointF(_startPosX + 50, _startPosY + 76)};
                g.FillPolygon(bomb, big_bombs1);
                g.FillPolygon(bomb, big_bombs2);
                g.DrawPolygon(pen, big_bombs1); //обведём
                g.DrawPolygon(pen, big_bombs2);
            }

            // теперь отрисуем основной кузов самолёта
            base.DrawTransport(g);
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontPlane}{separator}{SideBombs}{separator}{BigBombs}{separator}{MiniBombs}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса FighterPlane
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(FighterPlane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FrontPlane != other.FrontPlane)
            {
                return false;
            }
            if (SideBombs != other.SideBombs)
            {
                return false;
            }
            if (BigBombs != other.BigBombs)
            {
                return false;
            }
            if (MiniBombs != other.MiniBombs)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            { 
                return false;
            } 
 
            if (!(obj is FighterPlane airObj))
            {
                return false;
            }
            else
            {
                return Equals(airObj);
            }
        }   
    }
}
