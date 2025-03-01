using System.IO;

void ejemploCrear()
{
    string path = "c://p1//misarchivos//misarchivos.txt";
    string contenido = "mi primer achivo plano\n";
    File.WriteAllText(path, contenido);
    Console.WriteLine("Archivo creado");
}

void ejemploleer()
{
    string path = "c://p1//misarchivos//misarchivos.txt";
    //string path = "c://p1//xls//plano.csv";

  
    }
    try
    {
        string contenido = File.ReadAllText(path);
        Console.WriteLine("Contenido del Archivo:");
        Console.WriteLine(contenido);
    } catch (DirectoryNotFoundException err){
        Console.WriteLine("Ups, no existe el directorio:" + path);
    }catch (FileNotFoundException err)
    {
        Console.WriteLine("Como voy a leer algo que no existe?");
    }catch (Exception err)
    {
        Console.WriteLine("Otro error: " + err);
    }
}


void ejemploleerlinea()
{   string path = "c://pq//misarchivos//archivo.txt";
    //string path = "c://p1//xls//plano.csv";
    string[] lineas = File.ReadAllLines(path);
    foreach(string linea in lineas){
        Console.WriteLine("Linea:"+linea);
    }
}

void ejemploAgregar()
{
    string path = "c://p1//misarchivos//misarchivos.txt";
    string contenido = "Estoy agregando contenido!!!";
    File.AppendAllText(path, contenido);
    Console.WriteLine("Se agrega contenido");
}

void ejemploPath()
{
    string path = "c://p1//misarchivos//archivo.txt";
    string nombreArchivo = Path.GetFileName(path);
    string extension = Path.GetExtension(path);
    string carpeta = Path.GetDirectoryName(path);
    Console.WriteLine("Archivo:" + nombreArchivo);
    Console.WriteLine("Extension:" + extension);
    Console.WriteLine("Directorio:" + carpeta);
}

void ejemploMover()
{
    string pathOrigen = "c://p1//misarchivos//misarchivos.txt";
    File.Delete(pathOrigen);
    Console.WriteLine("Archivo eliminado");
}

void ejemploListar()
{
    string path = "c:/windows";
    string[] archivos = Directory.GetFiles(path);
    foreach(string archivo in archivos)
    {
        Console.WriteLine(archivo);
    }
}

ejemploListar();

//ejemploMover();

//ejemploleer();

//ejemploPath();

//ejemploleerlinea();

//ejemploleer();

//ejemploCrear();
//ejemploAgregar();
//Console.WriteLine("--- agregar ---");
//ejemploleer();