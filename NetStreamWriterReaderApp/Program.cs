// StreamWriter
// StreamReader

string path = @"D:\RPO\Maxim Efimov\NewDir\file.dat";

string text = @"Инициализирует новый экземпляр класса StreamWriter для указанного файла по заданному пути, используя заданную кодировку и размер буфера. Если файл существует, он может быть либо перезаписан, либо в него могут быть добавлены данные. Если файл не существует, конструктор создает новый файл.";

string[] ptext = {
    "Инициализирует новый экземпляр StreamWriter класса для указанного файла с использованием указанной кодировки и настраивается с помощью указанного FileStreamOptions объекта.",
    "Инициализирует новый экземпляр StreamWriter класса для указанного файла с использованием кодировки по умолчанию и настраивается с помощью указанного FileStreamOptions объекта",
    "Предоставляет StreamWriter без резервного хранилища, в который можно осуществлять запись, но из которого нельзя считывать данные.",
};
//using (StreamWriter writer = new(path))
//{
//    writer.Write(text);
//}

//using(StreamWriter writer = new(path, true))
//{
//    foreach(string line in ptext)
//        writer.WriteLine(line);
//}

//using(StreamReader reader = new StreamReader(path))
//{
//    //string textRead = reader.ReadToEnd();
//    //Console.WriteLine(textRead);
//    string line = reader.ReadLine();
//    Console.WriteLine(line);
//    //while((line = reader.ReadLine()) != null)
//    //    Console.WriteLine(line);
//}

using(StreamWriter writer = new StreamWriter(path))
{
    writer.WriteLine(Console.ReadLine());
}
