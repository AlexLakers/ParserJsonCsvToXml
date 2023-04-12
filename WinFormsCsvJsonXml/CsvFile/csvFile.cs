using System;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;


namespace ParserJsonCsvToXml.CsvFile
{

    // Этот класс описывает файл Init.csv.
    public class csvFile
    {
        public csvFile(string _pathToCsv) { _pathToCSV = _pathToCsv; }
        string _pathToCSV;

        // Лист данных из файла Init.csv.
        List<csvTag> _lstCsvData = new List<csvTag>(1);

        // Эта функция читает файл Init.csv и возвращает данные из этого файла. 
        public List<csvTag> LoadCSV()
        {
            // Cheking path to file Init.csv is not null.
            if (_pathToCSV is null) MessageBox.Show("Не выбран путь к файлу Input.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";", BadDataFound = null };

            // Открытие и чтение файла Init.csv.

            using (var reader = new StreamReader(_pathToCSV))
            {
                using (var csv = new CsvReader(reader, config))
                {

                    csv.Read();
                    csv.ReadHeader();

                    // Построчное чтение из файла Init.csv.
                    while (csv.Read())
                    {
                        _lstCsvData.Add(new csvTag(csv.GetField("Varble"), csv.GetField("Type"), csv.GetField("Addr")));
                    }

                }

            }

            return _lstCsvData;
        }

        // Эта функция возвращает лист выделенных строк.
        public List<csvTag> csvCurrentRow(DataGridView dg, List<csvTag> lstTempSource)
        {

            //Проверка файла Init.csv(DataGridView) на отсутствие данных.
            if (dg.RowCount <= 1)
            { MessageBox.Show($"Файл Input.csv не содержит данных", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            // Лист выбранных строк в DataGridView.
            List<csvTag> _lstRows = new(1);

            foreach (DataGridViewRow row in dg.SelectedRows)
            {
                _lstRows.Add(lstTempSource.ElementAt(row.Index));
            }

            return _lstRows;

        }
    }
}
