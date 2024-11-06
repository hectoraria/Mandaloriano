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

            //if (TimeOnly.FromDateTime(DateTime.Now) >= new TimeOnly(8, 0) && TimeOnly.FromDateTime(DateTime.Now) < new TimeOnly(12, 0))
            //{
                lista = ClsListadoDAL.listadosMisionesDAL();
            //}
            //else
            //{
            //    lista = null;
            //}


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
