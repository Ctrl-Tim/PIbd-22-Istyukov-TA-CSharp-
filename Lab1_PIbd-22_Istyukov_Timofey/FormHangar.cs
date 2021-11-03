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
    public partial class FormHangar : Form
    {
        /// <summary>
        /// Объект от класса-ангара
        /// </summary>
        private readonly Hangar<WarPlane> hangar;

        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<WarPlane>(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать военный самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void buttonSetWarPlane_Click_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var air = new WarPlane(100, 1000, dialog.Color);
                if (hangar + air != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Ангар переполнен");
                }

            }
        }


        /// <summary>
        /// Обработка нажатия кнопки "Припарковать истребитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void buttonSetFighterPlane_Click_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var air = new FighterPlane(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    if (hangar + air != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Ангар переполнен");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void buttonTakeAir_Clic_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var air = hangar - Convert.ToInt32(maskedTextBox.Text);
                if (air != null)
                {
                    FormPlane form = new FormPlane();
                    Random rnd = new Random();
                    air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), form.Width - 10, form.Height - 40);
                    form.SetAir(air);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
