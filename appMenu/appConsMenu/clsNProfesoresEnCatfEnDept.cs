using Servicios.Consolas;
using Servicios.Menus;
using System;
using System.IO;

namespace appMatematica.Presentacion.Consola
{
    public class clsNProfesoresEnCatfEnDept : clsMenu
    {
        private void CatgEnDept(int Opcion)
        {
            clsConsola.LimpiarPantalla();
            
            #region Variables para el For
            int contador = 0;
            char delimitador = ',';
            char delimitador2 = ' ';
            #endregion

            #region ID de departamento
            string Energy = "101028";
            string Geothermal = "102017";
            #endregion

            #region Contadores de Categoria
            int contadorCtgAssistant = 0;
            int contadorCtgAssociate = 0;
            int contadorCtgCurator = 0;
            int contadorCtgProfessor = 0;
            int contadorCtgResearch = 0;
            #endregion

            foreach (string line in File.ReadLines(FileToRead))
            {
                string[] valores = line.Split(delimitador);
                string[] vdevalores = valores[1].Split(delimitador2);
                string DeptId = valores[4];
                string Catg = vdevalores[0];
                switch (Opcion)
                {
                    case 1:
                        {
                            if(DeptId == Energy)
                            {
                                if (Catg == "Assistant") { contadorCtgAssistant++; }
                                else if (Catg == "Associate") { contadorCtgAssociate++; }
                                else if (Catg == "Curator") { contadorCtgCurator++; }
                                else if (Catg == "Professor") { contadorCtgProfessor++; }
                                else if (Catg == "Research") { contadorCtgResearch++; }
                            }
                        }break;
                    case 2:
                        {
                            if (DeptId == Geothermal)
                            {
                                if (Catg == "Assistant") { contadorCtgAssistant++; }
                                else if (Catg == "Associate") { contadorCtgAssociate++; }
                                else if (Catg == "Curator") { contadorCtgCurator++; }
                                else if (Catg == "Professor") { contadorCtgProfessor++; }
                                else if (Catg == "Research") { contadorCtgResearch++; }
                            }
                        } break;
                }
                contador++;
            }
            
            string Dept = null;
            if(Opcion == 1) { Dept = "Departamento de Ciencias de la Energia"; }
            else if(Opcion == 2) { Dept = "Departamento Tecnologia Geotermica"; }

            Console.WriteLine("Los profesores asistentes en el " + Dept + " son:" + contadorCtgAssistant);
            Console.WriteLine("Los curadores asociados a la biblioteca del " + Dept + " son:" + contadorCtgAssociate);
            Console.WriteLine("Los curadores de la biblioteca del " + Dept + " son:" + contadorCtgAssistant);
            Console.WriteLine("Los profesores del " + Dept + " son:" + contadorCtgAssistant);
            Console.WriteLine("Los profesores de investigacion del " + Dept + " son:" + contadorCtgAssistant);
            clsConsola.LeerTecla();
        }
        protected override void configurarMenu()
        {
            atrItems = new string[4];
            atrItems[0] = "MENU";
            atrItems[1] = "Numero de Profesores en las categorias del Departamento de Ciencias de la Energia";
            atrItems[2] = "Numero de Profesores en las categorias del Departamento Tecnologia Geotermica";
            atrItems[3] = "Regresar al Menu Anterior...";
        }
        protected override void procesarOpcion()
        {
            switch (atrOpcion)
            {
                case 1: { CatgEnDept(1); } break;
                case 2: { CatgEnDept(2); } break;
                case 3: clsConsola.EscribirSaltarLinea("Escogiste Salir"); clsConsola.LeerTecla(); break;
                default: clsConsola.EscribirSaltarLinea("Escogiste una Opcion erronea"); clsConsola.LeerTecla(); break;
            }
        }
    }
}