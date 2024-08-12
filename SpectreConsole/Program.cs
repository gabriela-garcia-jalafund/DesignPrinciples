using System;
using Spectre.Console;

public class Program
{
    static void Main(string[] args)
    {
        AnsiConsole.Markup("[bold yellow]¡Hola, Mundo![/] [underline red]Bienvenido a Spectre.Console[/]");

        var table = new Table();

        table.AddColumn("Id");
        table.AddColumn("Nombre");
        table.AddColumn("Edad");

        table.AddRow("1", "Juan", "30");
        table.AddRow("2", "María", "25");
        table.AddRow("3", "Pedro", "35");

        AnsiConsole.Render(table);
    }
}
