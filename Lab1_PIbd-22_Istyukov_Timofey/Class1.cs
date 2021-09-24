using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс отрисовки автомобиля
    /// </summary>
    public class FighterAircraft
    {
        /// <summary>
        /// Левая координата отрисовки истребителя
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки истребителя
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки истребителя
        /// </summary>
        private readonly int airWidth = 108;

        /// <summary>
        /// Высота отрисовки истребителя
        /// </summary>
        private readonly int airHeight = 103;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес истребителя
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }

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
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontPlane">Признак наличия переднего спойлера</param>
        /// <param name="sideBombs">Признак наличия боковых спойлеров</param>
        /// <param name="bigBombs">Признак наличия заднего спойлера</param>
        /// <param name="miniBombs">Признак наличия гоночной полосы</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontPlane, bool sideBombs, bool bigBombs, bool miniBombs)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontPlane = frontPlane;
            SideBombs = sideBombs;
            BigBombs = bigBombs;
            MiniBombs = miniBombs;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        ///<param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - airWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - airHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка истребителя
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва переднее оперение истребителя (чтобы потом отрисовка автомобиля на него "легла")
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

            //турбина
            Brush brCyan = new SolidBrush(Color.DarkCyan);
            PointF[] turbo = {
                new PointF(_startPosX + 51, _startPosY + 42),
                new PointF(_startPosX + 105, _startPosY + 42),
                new PointF(_startPosX + 110, _startPosY + 44),
                new PointF(_startPosX + 110, _startPosY + 49),
                new PointF(_startPosX + 107, _startPosY + 51),
                new PointF(_startPosX + 110, _startPosY + 53),
                new PointF(_startPosX + 110, _startPosY + 58),
                new PointF(_startPosX + 105, _startPosY + 61),
                new PointF(_startPosX + 51, _startPosY + 61)};
            g.FillPolygon(brCyan, turbo);
            g.DrawPolygon(pen, turbo); //обведём

            //крылья
            Brush br = new SolidBrush(MainColor);
            PointF[] wings = {
                new PointF(_startPosX + 45, _startPosY + 45),
                new PointF(_startPosX + 45, _startPosY),
                new PointF(_startPosX + 51, _startPosY),
                new PointF(_startPosX + 58, _startPosY + 45),
                new PointF(_startPosX + 58, _startPosY + 58),
                new PointF(_startPosX + 51, _startPosY + 103),
                new PointF(_startPosX + 45, _startPosY + 103)};
            g.FillPolygon(br, wings);
            g.DrawPolygon(pen, wings); //обведём

            //хвостовое оперение
            PointF[] tail_plane = {
                new PointF(_startPosX + 105, _startPosY + 28),
                new PointF(_startPosX + 105, _startPosY + 75),
                new PointF(_startPosX + 92, _startPosY + 65),
                new PointF(_startPosX + 92, _startPosY + 38)};
            g.FillPolygon(br, tail_plane);
            g.DrawPolygon(pen, tail_plane); //обведём

            //кузов
            g.FillRectangle(br, _startPosX + 15, _startPosY + 45, 90, 13);
            g.DrawRectangle(pen, _startPosX + 15, _startPosY + 45, 90, 13); //обведём

            //нос
            Brush brBlack = new SolidBrush(Color.Black);
            PointF[] nose = {
                new PointF(_startPosX + 15, _startPosY + 45),
                new PointF(_startPosX, _startPosY + 51),
                new PointF(_startPosX + 15, _startPosY + 58) };
            g.FillPolygon(brBlack, nose);
            g.DrawPolygon(pen, nose); //обведём
        }
    }
}
