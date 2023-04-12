-Это приложение выполняет соединение каждой строки(тега) из .csv файла "-\ParserJsonCsvToXml\WinFormsCsvJsonXml\App_Data\srcFiles\\Init.csv" с соответствующими данными из .json файла "-\ParserJsonCsvToXml\WinFormsCsvJsonXml\App_Data\srcFiles\TypeDescs.json" по типу(UTR,IO,SL,SVD),
при этом для каждого из полученных тегов высчитывается смещение на размер типа данных от предыдущего по списку тега.Полученные данные записываются в итоговый файл "~\ParserJsonCsvToXml\WinFormsCsvJsonXml\App_Data\resFile\res.xml"

-Пользователь на форме выбирает путь к .csv файлу Init.csv, после чего выбирает конкретные строки(теги) из данного файла для дальнейшего их объединения с данными из .json файла TypeDescs.json", далее  создаётся/открывается .xml файл res.xml и заполняется итоговыми данными.

-Например, при выборе первой строки из .csv файла Init.csv :
```csv
   Varble;Type;Addr
   rootSrc.LSB2.KSL1;UTR;1000
           
```
 происходит объединение по типу со следующим фрагментом .json файла TypeDescs.json:
```json
{
      "TypeVal": "UTR",
      "Props": {
        "lowD": "double",
        "lowI": "double",
        "lowN": "double",
        "lowP": "double",
        "modeP": "int",
        "CurrProc": "double",
        "CurrQ": "double",
        "lowIL": "double",
        "lowII2": "double",
        "lowK": "double",
        "BelZ": "double",
        "AirZrp": "double",
        "lowD_out": "double",
        "flowI_out": "double",
        "lowN_out": "double",
        "lowP_out": "double",
        "mode_out": "int",
        "CurrProc_out": "double",
        "CurrY_out": "double"
      }
  ```

 в итоговый .xml файл res.xml запишется следующий фрагмент данных:
```xml
<Item>                               
<node>rootSrc.LSB2.KSL1.lowD</node>
<addr>1000</addr>                  
</Item>                              
<Item>                               
<node>rootSrc.LSB2.KSL1.lowI</node>
<addr>1008</addr>                  
</Item>                              
<Item>                               
<node>rootSrc.LSB2.KSL1.lowN</node>
<addr>1016</addr>                  
</Item>                              
<Item>                               
<node>rootSrc.LSB2.KSL1.lowP</node>
<addr>1024</addr>                  
</Item>
```


-Для работы с .csv файлом используется библиотека "CsvHelper (30.0.1)",папки "csvFile","jsonFile","xmlFile" содержат классы,
 описывающие соответствующие файлы, "FormView.cs"-представление.
