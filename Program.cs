using System;
using System.Diagnostics;
using System.IO;

static void crearArchivo() //Funcion para crear el archivo inventos.txt
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    string contenido = "Los inventos secretos de Tony Son: \n";
    File.WriteAllText(path, contenido);
    Console.WriteLine("Archivo creado");
}

static void agregarInvento() //Funcion para agregar un invento al archivo inventos.txt sin sibreescribir el contenido
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    Console.WriteLine("Escribe el nombre de tu invento Tony");
    string contenido = "\n" + Console.ReadLine();
    File.AppendAllText(path, contenido);
    Console.WriteLine("Se agrega tu invento Tony");
}

static void leerArchivo() // funcion para leer el archivo inventos.txt y mostrar en pantalla los inventos
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    try
    {
        string contenido = File.ReadAllText(path);
        Console.WriteLine("Contenido del Archivo:");
        Console.WriteLine(contenido);
    }
    catch (DirectoryNotFoundException err)
    {
        Console.WriteLine("Error, el directorio no se ha creado, ejecuta la funcion 1" + path);
    }
    catch (FileNotFoundException err)
    {
        Console.WriteLine("Error, el archivo no existe, ¡Ultron debe haberlo borrado!");
    }
    catch (Exception err)
    {
        Console.WriteLine("Otro error: " + err); // Estas son las execepciones para los posibles errores 
    }
}
static void realizarBackup() // Funcion que genera un backup del archivo inventos.txt
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    try
    {
        string pathBackup = "c://LaboratorioAvengers//inventosBackup.txt";
        File.Copy(path, pathBackup);
        Console.WriteLine("Backup realizado");
    }

    catch (FileNotFoundException err)
    {
        Console.WriteLine("Error, el directorio no se ha creado, ejecuta la funcion 1");
    }
    catch (Exception err)
    {
        Console.WriteLine("El archivo ya existe " );
    }
}

static void moverArchivo() // Funcion para mover el archivo inventos.txt a la carpeta inventosclasificados, la caperta ya debe estar creada en el dir. 
{
    string path = "C://LaboratorioAvengers//inventos.txt";
    string pathDestino = "C://LaboratorioAvengers//inventosclasificados//inventos.txt";
    try
    {
        File.Move(path, pathDestino);
        Console.WriteLine("Archivo Movido");

    }
    catch (DirectoryNotFoundException err)
    {
        Console.WriteLine("Error, el directorio no se ha creado, crea el directorio " + pathDestino);
    }

}


static void crearCarpeta() // Funcion para crear la carpeta Proyectos Secretos
{
    string path = "c://laboratorioAvengers//ProyectosSecretos";
    try
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("Carpeta creada");
    }
    catch (Exception err)
    {
        Console.WriteLine("Error la carpeta ya esta creada " + err);
    }
}

static void verificaArchivo() // Funcion para verificar si el archivo inventos.txt existe
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    if (File.Exists(path))
    {
        Console.WriteLine("El archivo existe");
    }
    else
    {
        Console.WriteLine("El archivo no existe");
    }
}

static void eliminiarArchivo() // Funcion para eliminar el archivo inventos.txt
{
    string path = "c://LaboratorioAvengers//inventos.txt";
    try
    {
        File.Delete(path);
        Console.WriteLine("Archivo eliminado");
    }
    catch (FileNotFoundException err)
    {
        Console.WriteLine("Error, el archivo no existe");
    }
    catch (Exception err)
    {
        Console.WriteLine("Otro error: ");
    }
}

static void listarArchivos() // Funcion para listar los archivos de la carpeta LaboratorioAvengers
{
    string path = "c://LaboratorioAvengers//";
    string[] archivos = Directory.GetFiles(path);
    Console.WriteLine("Archivos en la carpeta LaboratorioAvengers: \n");
    foreach (string archivo in archivos)
    {
        Console.WriteLine(archivo);
    }
}

while (true) // para mostrar el menu de opciones nuevamente al sleccionar una
{
Console.WriteLine("Bienvenido a la Mision Secreta de Tony Stark \n");
Console.WriteLine("Presiona 0 para verificar si el archivo de inventos.txt existe \n");
Console.WriteLine("Presiona 1 para crear el archivo de inventos.txt \n");
Console.WriteLine("Presiona 2 para agregar un invento \n");
Console.WriteLine("Presiona 3 para leer el archivo de inventos.txt \n");
Console.WriteLine("Presiona 4 para realizar un backup del archivo de inventos.txt \n");
Console.WriteLine("Presiona 5 para mover el archivo de inventos.txt \n");
Console.WriteLine("Presiona 6 para crear la carpeta Proyectos Secretos \n");
Console.WriteLine("Presiona 7 para eliminar el archivo de inventos.txt \n");
Console.WriteLine("Presiona 8 para listar los archivos de la carpeta LaboratorioAvengers \n");
Console.WriteLine("Presiona 9 para salir \n");

    string funcion = Console.ReadLine();
    switch (funcion)
    {
        case "0":
            verificaArchivo();  
            break;
        case "1":
            crearArchivo();
            break;
        case "2":
            agregarInvento();
            break;
        case "3":
            leerArchivo();
            break;
        case "4":
            realizarBackup();
            break;
        case "5":
            moverArchivo();
            break;
        case "6":
            crearCarpeta();
            break;
        case "7":
            eliminiarArchivo();
            break;
        case "8":
            listarArchivos();
            break;
        case "9":
            return;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}
