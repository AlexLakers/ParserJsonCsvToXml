using System;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data;
using System.IO;
using System.Text;

namespace ParserJsonCsvToXml.JsonFile
{
    // Этот класс описывает файл TypeDescs.json.
    public class jsonFile
    {
        string _pathToJSON;
        public jsonFile(string _path) { _pathToJSON = _path; }

        // Эта функция читает файл TypeDescs.json и возвращает данные из этого файла. 
        public async Task<RootSrc> LoadJSON()
        {
            // Данные из файла TypeDescs.json.
            RootSrc _jsonData = new();

            // Открытие и десериализация файла TypeDescs.json.
            using (FileStream fs = new FileStream(_pathToJSON, FileMode.Open))
            {
                _jsonData = await JsonSerializer.DeserializeAsync<RootSrc>(fs);

            }

            // Проверка наличия всех свойств  в файле TypeDescs.json.
            if (_jsonData?.TypeDescs is not null)
            {
                foreach (TypeDesc _ti in _jsonData.TypeDescs)
                {
                    if (_ti.Props is null || _ti.TypeVal is null)
                    { MessageBox.Show($"Проверьте наличие свойств \"Propertys\" и \"TypeName\" в файле .JSON путь:[{_pathToJSON}] ", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            else
            { MessageBox.Show($"Проверьте наличие массива \"TypeInfos\"  в файле .JSON путь:[{_pathToJSON}] ", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }


            return _jsonData;



        }
    }
}
