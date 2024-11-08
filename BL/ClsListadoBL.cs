using DAL;
using ENT;

namespace BL
{
    public class ClsListadoBL
    {
        /// <summary>
        /// Funcion que devuelve la lista de la capa DAL dependiendo de la hora manda la lista o vacia
        /// </summary>
        /// <returns>Lista de misiones o lista vacia</returns>
        public static List<ClsMision> listadoMisionesBL()
        {
            List<ClsMision> lista;

            if(DateTime.Now.Hour>0 && DateTime.Now.Hour < 8)
            {
                lista = null;
            }
            else
            {
                lista = ClsListadoDAL.listadosMisionesDAL();
            }
                
           
            
                
           


            return lista;
        }

        /// <summary>
        /// Funcion que devuelve una mision de tipo ClsMision
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Objeto de tipo ClsMision</returns>
        public static ClsMision SelecionarMisionBL(int Id)
        {
            ClsMision misionSelecionar = ClsListadoDAL.SelecionarMisionDAL(Id);
            return misionSelecionar;
        }
    }
}
