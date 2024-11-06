using ENT;

namespace DAL
{

    /// <summary>
    /// Funcion para delvolver la lista de objetos de tipo ClsMision
    /// </summary>
    /// <returns>lista ClsMision</returns>
    public class ClsListadoDAL
    {
        public static List<ClsMision> listadosMisionesDAL()
        {


            List<ClsMision> lista = new List<ClsMision>();

            lista.Add(new ClsMision(0, "Cazar al extremeño Loren", "Es un pequeño extremo muy cabezon y " +
                "con muy mal ostia hay que acabarlo por le bien de la republica", 10000));

            lista.Add(new ClsMision(1, "Rescatar al embajador capturado de Onderon",
                "El embajador ha sido secuestrado por piratas espaciales que buscan extorsionar a la República. Es vital rescatarlo antes de que lo vendan al mejor postor.", 20000));

            lista.Add(new ClsMision(2, "Destruir la nave del señor del crimen Glorrak",
                "Glorrak ha estado vendiendo armamento ilegal a los separatistas. " +
                "Su nave es altamente peligrosa y está fuertemente armada.", 25000));

            lista.Add(new ClsMision(3, "Proteger el convoy médico en Ruta 7",
                "Un convoy de suministros médicos para los refugiados de Tatooine está bajo " +
                "amenaza. Asegúrate de que llegue a su destino.", 12000));

            lista.Add(new ClsMision(4, "Infiltrarse en la fortaleza de los piratas de Gargon",
                "Se ha encontrado una fortaleza pirata en Gargon. Necesitamos información " +
                "y, si es posible, desactivar su defensa sin ser detectado.", 18000));

            lista.Add(new ClsMision(5, "Rastrear y capturar al espía imperial Val’thak",
                "Este espía ha estado filtrando información de la República. " +
                "Es astuto y sabe cómo ocultarse en cualquier entorno.", 22000));

            lista.Add(new ClsMision(6, "Liberar la colonia de Tal’ka del dominio separatista",
                 "Una pequeña colonia ha sido tomada por los separatistas " +
                 "para extraer minerales. Libera a los colonos y asegura la zona.", 30000));

            

            return lista;
        }
        /// <summary>
        /// Funcion que devuelve una mision de tipo ClsMision
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Objeto de tipo ClsMision</returns>
        public static ClsMision SelecionarMisionDAL(int Id)
        {
            List<ClsMision> lista = listadosMisionesDAL();
            ClsMision misionSelecionada = null;

            foreach (ClsMision mision in lista)
            {

                if (mision.Id == Id)
                {
                    misionSelecionada = mision;
                    break;
                }

               
            }
            return misionSelecionada;
        }
    }
}
