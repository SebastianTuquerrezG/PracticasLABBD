using Servicios.Consolas;

namespace Servicios.Menus
{
    public class clsMenu
    {
        #region Atributos
        protected string FileToRead = @"C:\Users\Personal\OneDrive - unicauca.edu.co\Documentos\Semestre 4\Practica1\positions.csv";
        protected string FileToRewritten = @"C:\Users\Personal\OneDrive - unicauca.edu.co\Documentos\Semestre 4\BD1\ej.txt";
        protected int atrOpcion = -1;
        protected int atrOpcionSalir;
        protected string[] atrItems; 
        #endregion
        #region Operaciones
        public clsMenu()
        {
            configurarMenu();
            atrOpcionSalir = atrItems.Length - 1;
            iterarMenu();
        }
        protected virtual void configurarMenu() { }
        protected virtual void procesarOpcion() { }

        protected void imprimirMenu()
        {
            clsConsola.LimpiarPantalla();
            clsConsola.EscribirSaltarLinea(atrItems[0]);
            for (int i = 1; i < atrItems.Length; i++)
                clsConsola.EscribirSaltarLinea(i + "." + atrItems[i]);
        }
        private void iterarMenu()
        {
            do
            {
                imprimirMenu();
                atrOpcion = clsConsola.Leer<int>("Seleccione una Opcion -->");
                procesarOpcion();
            } while (atrOpcion != atrOpcionSalir);
        }
        #endregion
    }
}