using Servicios.Consolas;
using Servicios.Menus;
using System;

namespace appPractica1.Presentacion.Consola
{
    public class clsMnuPrincipal : clsMenu
    {
        protected override void configurarMenu()
        {
            atrItems = new string[8];
            atrItems[0] = "MENU";
            atrItems[1] = "Numero de profesores";
            atrItems[2] = "Numero de profesores en cada departamento";
            atrItems[3] = "Numero de profesores en una categoría en los diferentes departamentos";
            atrItems[4] = "Cuanto profesores comenzaron a trabajar en diferente año";
            atrItems[5] = "Actualizar el nombre del departamento";
            atrItems[6] = "Generar sentencia sql de datos del csv";
            atrItems[7] = "Salir";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { new clsNProfesores(); } break;
                case 2: { new clsNProfesoresEnDept(); } break;
                case 3: { new clsNProfesoresEnCatfEnDept(); } break;
                case 4: { new clsNProfesoresStartDate(); } break;
                case 5: { new clsActualizarDept(); } break;
                case 6: { new clsGenerarSentenciasSQL(); } break;
                case 7: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla();  break;
            }
        }
    }
}