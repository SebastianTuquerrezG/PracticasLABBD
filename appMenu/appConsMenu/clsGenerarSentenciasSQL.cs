using System;
using Servicios.Consolas;
using Servicios.Menus;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace appPractica1.Presentacion.Consola
{
    public class clsGenerarSentenciasSQL : clsMenu
    {


        private void GSentencia()
        {
            string sentenciaSql = ""; 
            string Tabla = "MI_TABLA_SQL";
            foreach (string line in File.ReadLines(FileToRead))
            {
                Char delimiter = ',';
                string[] datos = line.Split(delimiter);
                for (byte columna = 0; columna < datos.Length; columna++)
                {
                    sentenciaSql = sentenciaSql + datos[columna] + "','";
                }
                sentenciaSql = "INSERT INTO " + Tabla + " VALUES ('" + sentenciaSql;
                sentenciaSql = sentenciaSql.Substring(0, sentenciaSql.Length - 2) + ")";
                Console.WriteLine(sentenciaSql);
                sentenciaSql = "";
            }
            clsConsola.LeerTecla();
        }
        
        protected override void configurarMenu()
        {
            atrItems = new string[3];
            atrItems[0] = "MENU";
            atrItems[1] = "SENTENCIAS";
            atrItems[2] = "Regresar al Menu Principal...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { GSentencia(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}