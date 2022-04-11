using System;

namespace Servicios.Consolas
{
    public class clsConsola
    {
        #region Servicios de Salida
        public static void Escribir(string prmMensaje)
        {
            Console.Write(prmMensaje);
        }  // Modularidad y portabilidad
        public static void EscribirSaltarLinea(string prmEtiqueta)
        {
            Escribir(prmEtiqueta + "\n");
        }
        #endregion
        #region Servicios de entrada
        public static void LeerTecla()
        {
            EscribirSaltarLinea("\n Presione cualquier tecla para continuar... ");
            Console.ReadKey();
        }
        public static Tipo Leer<Tipo>(string prmEtiqueta)
        {
            bool varEsValidoDato = false;
            do
            {
                try
                {
                    Escribir(prmEtiqueta);
                    return (Tipo)(Convert.ChangeType(Console.ReadLine(), typeof(Tipo)));
                }
                catch (Exception e)
                {
                    LimpiarPantalla();
                    EscribirSaltarLinea("La aplicacion ha fallado debido a: " + e.Message);
                    LeerTecla();
                }
            } while (varEsValidoDato == false);
            return default(Tipo);
        }
        #endregion
        #region Servicios de Control
        /*public static int ConvertirParse_LeerDato(int num)
        {
            num = int.Parse(Console.ReadLine());
        }*/
        public static void LimpiarPantalla()
        {
            Console.Clear();
        }
        #endregion
    }
}
