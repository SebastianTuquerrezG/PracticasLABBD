using Servicios.Consolas;
using Servicios.Menus;
using System;
using System.IO;
using System.Collections.Generic;

namespace appPractica1.Presentacion.Consola
{
    public class clsNProfesoresStartDate : clsMenu
    {
        private void StartDate()
        {
            clsConsola.LimpiarPantalla();

            List<int> intermediate_list = new List<int>();

            #region Variables para el For
            int contador = 0;
            char delimitador = ',';
            int fecha, max, min;
            #endregion

            foreach (string line in File.ReadLines(FileToRead))
            {
                string[] valores = line.Split(delimitador);
                string año = valores[5];
                if (año == "start_date")
                {
                    continue;
                }
                else { fecha = Int32.Parse(año); }

                intermediate_list.Add(fecha);
                contador++;
            }

            int[] arr_sample = intermediate_list.ToArray();max = min = arr_sample[0];

            //for(int i= 0; i < arr_sample.Length; i++) 
            //    Console.WriteLine(arr_sample[i]); Imprime todas las fechas

            for (int i = 0; i < arr_sample.Length; i++)
            {
                if (arr_sample[i] > max)
                    max = arr_sample[i];

                if (arr_sample[i] < min)
                    min = arr_sample[i];
            }

            for(int i = min ; i <= max; i++)
            {
                int contador2 = 0;
                for(int j = 0; j < arr_sample.Length; j++)
                {
                    if (arr_sample[j] == i)
                        contador2++;
                }
                Console.WriteLine("Los profesores que iniciaron en la fecha: " + i + " son: " + contador2);
            }

            clsConsola.LeerTecla();
        }
                
        protected override void configurarMenu()
        {
            atrItems = new string[3];
            atrItems[0] = "MENU";
            atrItems[1] = "Lista de cantidad de profesores que iniciaron en X año";
            atrItems[2] = "Regresar al Menu Principal...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { StartDate(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}