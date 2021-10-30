using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    public class WarPlane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолёта
        /// </summary>
        protected readonly int airWidth = 110;

        /// <summary>
        /// Высота отрисовки самолёта
        /// </summary>
        protected readonly int airHeight = 103;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолёта</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public WarPlane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструкторс изменением размеров самолёта
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолёта</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="airWidth">Ширина отрисовки самолёта</param>
        /// <param name="airHeight">Высота отрисовки самолёта</param>
        protected WarPlane(int maxSpeed, float weight, Color mainColor, int airWidth, int airHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.airWidth = airWidth;
            this.airHeight = airHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight; switch (direction)
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

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
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
