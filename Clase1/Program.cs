using System;

namespace Program
{

    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
}

public class Banco
{

    // Atributos
    public string Nombre;
    public string Ubicacion;
    public int CantidadClientes;
}


//Metodos
public void AgregarCliente()
{
    Console.WriteLine("AgregoCliente");
}

public void MostrarInfo()
{
    Console.WriteLine("MuestroInfo");
}


class Libro
{
    // Atributos
    public string Titulo;
    public string Autor;
    public int Paginas;


    //Metodos

    public void Leer()
    {
        Console.WriteLine("Leo");
    }

    public void Resumen()
    {
        Console.WriteLine("HagoResumen");
    }
}