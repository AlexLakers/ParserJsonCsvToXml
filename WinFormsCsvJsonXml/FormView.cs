using System;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Data;
using System.IO;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml;
using ParserJsonCsvToXml.XmlFile;
using ParserJsonCsvToXml.JsonFile;
using ParserJsonCsvToXml.CsvFile;

namespace CsvJsonToXml
{
    public partial class FormView : Form
    {
        // Все строки из файла Init.csv..
        List<csvTag> _csvTags;

        // Выбранные строки из файла Init.csv.
        List<csvTag> _csvTagsSelect;

        // Итоговый лист тегов для файла res.xml.
        List<Item> _xmlTags;

        // Данные из файла TypeDescs.json.
        RootSrc _root;

        //Переменные описывающие Init.csv,TypeDescs.json,res.xml.
        csvFile csvfile;
        jsonFile jsonfile;
        xmlFile _xmlfile;

        // Пути к файлам TypeDescs.json,res.xml,Init.csv.
        string _pathToJSON = "C:\\Users\\Alexey\\Desktop\\ParserJsonCsvToXml\\WinFormsCsvJsonXml\\App_Data\\srcFiles\\TypeDescs.json";
        string _pathToXML = "C:\\Users\\Alexey\\Desktop\\ParserJsonCsvToXml\\WinFormsCsvJsonXml\\App_Data\\resFile\\res.xml";
        string _pathToCSV;

        //View
        public FormView()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки "Path selection".
        private async void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                // Инициализация пути к файлу Init.csv.
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                _pathToCSV = openFileDialog.FileName;
                tbPath.Text = _pathToCSV;
                tbPath.ReadOnly = true;

                // Чтение файла TypeInfos.json.
                jsonfile = new jsonFile(_pathToJSON);
                _root = await jsonfile.LoadJSON();

            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show($"Не найден файл {_pathToJSON}", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (JsonException jex)
            {
                MessageBox.Show($"Ошибка файла .JSON путь:[{_pathToJSON}] {Environment.NewLine} сообщение:[{jex.Message}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception exc)
            {
                MessageBox.Show($"Сообщение:[{exc.Message}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        // Обработчик события нажатия кнопки "Save selected rows".
        private void btnToXML_Click(object sender, EventArgs e)
        {

            try
            {
                _csvTagsSelect = new List<csvTag>(1);

                _csvTagsSelect = csvfile.csvCurrentRow(dataGridView1, _csvTags);

                _xmlfile = new xmlFile(_pathToXML);

                _xmlTags = _xmlfile.CreateResLst(_csvTagsSelect, _root);

                //Выгрузка данных в файл res.xml. 
                _xmlfile.UpLoadXML(_xmlTags);

                if (_xmlTags is not null)
                {
                    MessageBox.Show($"Данные сохранены в .XML файл", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException nre)
            { MessageBox.Show($"Тэги для выгрузки не выбраны", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (XmlException xe)
            {
                MessageBox.Show($"Ошибка файла .XML путь:[{_pathToXML}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show($"Не найден файл .XML путь:[{_pathToXML}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception Exc)
            {
                MessageBox.Show($"Сообщение:[{Exc.Message}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик события нажатия кнопки "Show file".
        private void btnShowCSV_Click(object sender, EventArgs e)
        {

            try
            {
                csvfile = new csvFile(_pathToCSV);

                // Загрузка данных из файла init.xml.
                _csvTags = csvfile.LoadCSV();

                // Отображение данных в таблице данных.
                dataGridView1.DataSource = _csvTags;
            }
            catch (CsvHelperException _csvHelpEx)
            {
                MessageBox.Show($"Выбран некорректный файл.CSV  {Environment.NewLine} сообщение:[{_csvHelpEx.Message}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception Exc)
            {
                MessageBox.Show($"Сообщение:[{Exc.Message}]", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

    }
}


















