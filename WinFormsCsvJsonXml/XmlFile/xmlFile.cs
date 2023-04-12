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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ParserJsonCsvToXml.JsonFile;
using ParserJsonCsvToXml.CsvFile;

namespace ParserJsonCsvToXml.XmlFile
{
    // Этот класс описывает итоговый файл res.xml.
    internal class xmlFile
    {
        string _pathToXML;
        public xmlFile(string pathtoxml) { _pathToXML = pathtoxml; }

        // Размер типов данных в байтах. 
        Dictionary<string, string> _sizeData = new Dictionary<string, string>()
        {
            {"int","4"},
            {"double","8"},
            {"bool","1"}
        };
        // Эта функция записывает данные в итоговый файл res.xml.
        public void UpLoadXML(List<Item> lst)
        {

            // Сереализация файла res.xml. 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), new XmlRootAttribute("rootSrc"));
            using (FileStream fs = new FileStream(_pathToXML, FileMode.OpenOrCreate))
            {

                serializer.Serialize(fs, lst);

            }

        }
        // Эта функция создаёт лист данных для файла res.xml.
        public List<Item> CreateResLst(List<csvTag> csvTagsSelec, RootSrc rt)
        {
            // Флаг для расчета адреса тега.
            bool _outflag = true;

            List<Item> _xmlTagsTemp = new(1);

            // Запрос создания листа тегов путём объединения Init.csv и TypeDescs.json.
            var BaseResLst = csvTagsSelec.Join(rt.TypeDescs, t => t.Type, tt => tt.TypeVal, (t, tt) => new { tag = t.Varble + ".", props = tt.Props, address = t.Addr });

            // Выполнение запроса по созданию листа тегов.. 
            foreach (var XmlTag in BaseResLst)
            {

                _outflag = true;

                foreach (var TagEnd in XmlTag.props)
                {

                    // Проверка позици тега в группе,если первый.
                    if (_outflag)
                    {
                        _xmlTagsTemp.Add(new Item() { node = XmlTag.tag + TagEnd.Key, address = XmlTag.address.Length != 0 ? XmlTag.address : "0" });
                        _outflag = false;
                    }

                    else
                    {
                        _xmlTagsTemp.Add(new Item() { node = XmlTag.tag + TagEnd.Key, address = (short.Parse(_xmlTagsTemp?.Last().address) + int.Parse(_sizeData[TagEnd.Value])).ToString() });
                    }
                }

            }

            return _xmlTagsTemp;
        }

    }
}
