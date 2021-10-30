using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    public partial class FormFighterAircraft : Form
    {
        private FighterPlane air;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormFighterAircraft()
        {
            InitializeComponent();
        } 

        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxFighterAircraft.Width, pictureBoxFighterAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            air.DrawTransport(gr);
            pictureBoxFighterAircraft.Image = bmp; 
        }

         /// <summary>
         /// Обработка нажатия кнопки "Создать"
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void buttonCreate_Click(object sender, EventArgs e)
         {
             Random rnd = new Random();
             air = new FighterPlane();
             air.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkGreen, Color.Gray, true, true, true, true);
             air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxFighterAircraft.Width, pictureBoxFighterAircraft.Height);
             Draw();
         } 

         /// <summary>
         /// Обработка нажатия кнопок управления
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        { 
             //получаем имя кнопки
             string name = (sender as Button).Name;
             switch (name)
             {
                 case "buttonUp":
                     air.MoveTransport(Direction.Up);
                     break;
                 case "buttonDown":
                     air.MoveTransport(Direction.Down);
                     break;
                 case "buttonLeft":
                     air.MoveTransport(Direction.Left);
                     break;
                 case "buttonRight":
                     air.MoveTransport(Direction.Right);
                     break;
             }
             Draw();
        }
    }
}
