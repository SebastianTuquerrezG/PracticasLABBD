using System;
using Servicios.Consolas;
using Servicios.Menus;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace appMatematica.Presentacion.Consola
{
    public class clsNProfesoresEnDept : clsMenu
    {
        private void NumProfDept()
        {
            clsConsola.LimpiarPantalla();

            #region Variables para el For
            int contador = 0;
            char delimitador = ',';
            #endregion

            #region Contadores de Departamento
            int contador_dept1 = 0;
            int contador_dept2 = 0;
            #endregion

            foreach (string line in File.ReadLines(FileToRead))
            {
                string[] valores = line.Split(delimitador);
                switch (valores[4])
                {
                    case "101028": { contador_dept1++; } break;
                    case "102017": { contador_dept2++; } break;
                }
                contador++;
            }

            Console.WriteLine("El numero de profesores en el Departamento de Ciencias de la Energia son:" + contador_dept1);
            Console.WriteLine("El numero de profesores en el Departamento Tecnologia Geotermica son:" + contador_dept2);
            clsConsola.LeerTecla();
        }
        protected override void configurarMenu()
        {
            atrItems = new string[3];
            atrItems[0] = "MENU";
            atrItems[1] = "Profesores en cada departamento";
            atrItems[2] = "Regresar al Menu Principal";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { NumProfDept(); } break;
                case 2: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}