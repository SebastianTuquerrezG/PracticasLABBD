﻿using Servicios.Consolas;
using Servicios.Menus;
using System;
using System.IO;

namespace appPractica1.Presentacion.Consola
{
    public class clsActualizarDept : clsMenu
    {
        private void evSuma(int Opcion)
        {
            clsConsola.LimpiarPantalla();

            StreamWriter streamWriter = new StreamWriter(FileToRewritten);

            #region Variables para el For
            int o,i;
            string name = "", dept = "";
            #endregion

            clsConsola.LimpiarPantalla();
            Console.WriteLine(
                "[1] Cambiar por nombre personalizado\n" +
                "[2] Cambiar por nombre recomendado");
            string n = Console.ReadLine();
            i = Int32.Parse(n);

            switch (i)
            {
                case 1: { name = Console.ReadLine();}break;
                case 2: { name = "faculty of electronic engineering and telecommunications"; } break;
            }

            clsConsola.LimpiarPantalla();
            Console.WriteLine(
                "[1] Actualizar en otro archivo\n" +
                "[2] Imprimir actualizacion por consola");
            string Opcion2 = Console.ReadLine();
            o = Int32.Parse(Opcion2);

            switch (Opcion)
            {
                case 1:
                    {
                        dept = "Energy Sciences Department";
                        switch (o)
                        {
                            case 1:
                                {
                                    foreach (string line in File.ReadLines(FileToRead))
                                    {
                                        string linea = line;
                                        linea = linea.Replace(dept, name);
                                        streamWriter.WriteLine(linea);
                                    }
                                    streamWriter.Close();
                                }
                                break;
                            case 2:
                                {
                                    foreach (string line in File.ReadLines(FileToRead))
                                    {
                                        string linea = line;
                                        linea = linea.Replace(dept, name);
                                        Console.WriteLine(linea);
                                    }
                                }
                                break;
                        }
                    } break;
                case 2:
                    {
                        dept = "Geothermal Technology Department";
                        switch (o)
                        {
                            case 1:
                                {
                                    foreach (string line in File.ReadLines(FileToRead))
                                    {
                                        string linea = line;
                                        linea = linea.Replace(dept, name);
                                        streamWriter.WriteLine(linea);
                                    }
                                    streamWriter.Close();
                                }
                                break;
                            case 2:
                                {
                                    foreach (string line in File.ReadLines(FileToRead))
                                    {
                                        string linea = line;
                                        linea = linea.Replace(dept, name);
                                        Console.WriteLine(linea);
                                    }
                                }
                                break;
                        }
                    } break;
            }
            clsConsola.LeerTecla();
        }

        protected override void configurarMenu()
        {
            atrItems = new string[4];
            atrItems[0] = "MENU";
            atrItems[1] = "Reescribir en el departamento de ciencias";
            atrItems[2] = "Reescribir en el departamento de tecnologia geotermica";
            atrItems[3] = "Regresar al Menu Principal...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { evSuma(atrOpcion); } break;
                case 2: { evSuma(atrOpcion); }break;
                case 3: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}