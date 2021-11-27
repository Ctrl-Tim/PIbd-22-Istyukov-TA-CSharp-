﻿using System;
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
        private readonly HangarCollection hangarCollection;

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width, pictureBoxHangar.Height);
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;

            listBoxHangars.Items.Clear();
            for (int i = 0; i < hangarCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarCollection.Keys[i]);
            }

            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >= listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index < listBoxHangars.Items.Count)
            {
                listBoxHangars.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            if (listBoxHangars.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить ангар"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void buttonAddHangar_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hangarCollection.AddHangar(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Удалить ангар"
        /// </summary>
        /// <param name="sender"></param
        /// <param name="e"></param> 
        private void buttonDelHangar_Click_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить ангар {listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarCollection.DelHangar(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }


        /// <summary>
        /// Обработка нажатия кнопки "Припарковать военный самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void buttonSetWarPlane_Click_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var air = new WarPlane(100, 1000, dialog.Color);
                    if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + air == 1)
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
        /// Обработка нажатия кнопки "Припарковать истребитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void buttonSetFighterPlane_Click_Click_1(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var air = new FighterPlane(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                        if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + air == 1)
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
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void buttonTakeAir_Clic_Click_1(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var air = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (air != null)
                {
                    FormPlane form = new FormPlane();
                    Random rnd = new Random();
                    air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), form.Width - 12, form.Height - 80);
                    form.SetAir(air);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewLevelName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
