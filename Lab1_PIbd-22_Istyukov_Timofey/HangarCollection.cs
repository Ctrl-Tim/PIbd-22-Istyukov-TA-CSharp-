using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_PIbd_22_Istyukov_Timofey
{
    /// <summary>
    /// Класс-коллекция ангаров
    /// </summary> 
    public class HangarCollection
    {
        /// <summary>
        /// Словарь (хранилище) с ангарами
        /// </summary>
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages;

        /// <summary>
        /// Возвращение списка названий ангаров
        /// </summary>
        public List<string> Keys => hangarStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление ангара
        /// </summary>
        /// <param name="name">Название ангара</param>
        public void AddHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                return;
            }
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }

        /// <summary>
        /// Удаление ангара
        /// </summary>
        /// <param name="name">Название ангара</param>
        public void DelHangar(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        }

        /// <summary>
        /// Доступ к ангару
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (this.hangarStages.ContainsKey(ind))
                {
                    return hangarStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        ITransport air = null;

        /// <summary>
        /// Сохранение информации по самолётам в ангаре в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"HangarCollection{Environment.NewLine}");
                foreach (var level in hangarStages)
                {
                    //Начинаем парковку
                    fs.Write($"Hangar{separator}{level.Key}{Environment.NewLine}");
                    foreach (ITransport air in level.Value)
                    {
                        //если место не пустое
                        //Записываем тип самолёта
                        if (air.GetType().Name == "WarPlane")
                        {
                            fs.Write($"WarPlane{separator}");
                        }
                        if (air.GetType().Name == "FighterPlane")
                        {
                            fs.Write($"FighterPlane{separator}");
                        }
                        //Записываемые параметры
                        fs.Write(air + Environment.NewLine);
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Неверный формат файла");
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                string strs = fs.ReadLine();
                if (!strs.Contains("HangarCollection"))
                {
                    //если нет такой записи, то это не те данные
                    throw new ArgumentException("Неверный формат файла");
                }
                hangarStages.Clear(); //если есть, то очищаем записи
                Vehicle air = null;
                string key = string.Empty;
                while ((strs = fs.ReadLine()) != null)
                {
                    //идём по считанным записям
                    if (strs.Contains("Hangar"))
                    {
                        key = strs.Split(separator)[1];
                        hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (strs.Contains(separator))
                    {
                        if (strs.Contains("WarPlane"))
                        {
                            air = new WarPlane(strs.Split(separator)[1]);
                        }
                        if (strs.Contains("FighterPlane"))
                        {
                            air = new FighterPlane(strs.Split(separator)[1]);
                        }
                        if (hangarStages[key] + air != 1)
                        {
                            throw new IndexOutOfRangeException("Не удалось загрузить самолёт в ангар");
                        }
                    }
                }
            }
        }
    }
}