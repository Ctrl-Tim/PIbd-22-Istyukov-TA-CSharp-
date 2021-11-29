﻿using NLog;
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
        private readonly HangarCollection hangarCollection;

        /// <summary>
        /// Логгер 
        /// </summary>
        private readonly Logger logger;

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width, pictureBoxHangar.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn("Не введено название ангара");
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили ангар {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили ангар {listBoxHangars.SelectedItem.ToString()}");
                    hangarCollection.DelHangar(listBoxHangars.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void buttonSetAir_Click_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormAirConfig();
            formCarConfig.AddEvent(AddAir);
            formCarConfig.Show();
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
                try
                {
                    var air = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (air != null)
                    {
                        FormPlane form = new FormPlane();
                        Random rnd = new Random();
                        air.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), form.Width - 12, form.Height - 80);
                        form.SetAir(air);
                        form.ShowDialog();
                        logger.Info($"Изъят самолёт {air} с места {maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (HangarNotFoundException ex)
                {
                    logger.Warn("Не найдено");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void listBoxHangars_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на ангар {listBoxHangars.SelectedItem.ToString()}");
            Draw();
        }

        /// <summary>
        /// Метод добавления самолёта
        /// </summary>
        /// <param name="car"></param>
        private void AddAir(Vehicle air)
        {
            if (air != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + air == 1)
                    {
                        Draw();
                        logger.Info($"Добавлен самолёт {air}");
                    }
                    else
                    {
                        logger.Warn("Самолет не удалось поставить");
                        MessageBox.Show("Самолёт не удалось поставить");
                    }
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    logger.Warn("Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
