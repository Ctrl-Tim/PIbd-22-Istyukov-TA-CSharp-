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
    public partial class FormAirConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный самолёт
        /// </summary>
        Vehicle air = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddAir;

        public FormAirConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelNavy.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать самолёт
        /// </summary>
        private void DrawAir()
        {
            if (air != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAir.Width, pictureBoxAir.Height);
                Graphics gr = Graphics.FromImage(bmp);
                air.SetPosition(5, 5, pictureBoxAir.Width, pictureBoxAir.Height);
                air.DrawTransport(gr);
                pictureBoxAir.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary> 
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddAir == null)
            {
                eventAddAir = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddAir += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWarPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarPlane.DoDragDrop(labelWarPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelFighterPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelFighterPlane.DoDragDrop(labelFighterPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelAir_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный самолёт":
                    air = new WarPlane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Истребитель":
                    air = new FighterPlane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxFrontPlane.Checked, checkBoxSideBombs.Checked, checkBoxBigBombs.Checked, checkBoxMiniBombs.Checked);
                    break;
            }
            DrawAir();
        }

        /// <summary>
        /// Проверка получаемой информации (её типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                air.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAir();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                if (air is FighterPlane)
                {
                    (air as FighterPlane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAir();
                }
            }
        }

        // <summary>
        // Добавление самолёта
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            eventAddAir?.Invoke(air);
            Close();
        }
    }
}
