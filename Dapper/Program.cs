namespace Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Juan", Edad = 30 },
            new Usuario { Id = 2, Nombre = "María", Edad = 25 },
            new Usuario { Id = 3, Nombre = "Pedro", Edad = 35 }
        };

        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Edad: {usuario.Edad}");
        }
    }
}