using System;
using Servicios.Consolas;
using Servicios.Menus;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace appPractica1.Presentacion.Consola
{
    public class clsNProfesores : clsMenu
    {
        private void LeerArchivos(int I)
        {
            clsConsola.LimpiarPantalla();
                        
            switch (I)
            {
                case 1:
                    {
                        var lineCount = File.ReadLines(FileToRead).Count();
                        Console.WriteLine("Numero de profesores: " + (lineCount - 1) + ".");
                        clsConsola.LeerTecla();
                    } break;
                case 2:
                    {
                        IEnumerable<string> line = File.ReadLines(FileToRead);
                        Console.WriteLine(String.Join(Environment.NewLine, line));
                        clsConsola.LeerTecla();
                    } break;
            }
        }
        
        protected override void configurarMenu()
        {
            atrItems = new string[4];
            atrItems[0] = "MENU # Profesores";
            atrItems[1] = "Numero de Profesores";
            atrItems[2] = "Lista de profesores";
            atrItems[3] = "Regresar al Menu Principal...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { LeerArchivos(atrOpcion); } break;
                case 2: { LeerArchivos(atrOpcion); } break;
                case 3: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}