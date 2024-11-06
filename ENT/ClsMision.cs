namespace ENT
{
    public class ClsMision
    {

        #region Propiedades

        public long Id {  get;  }

        public string Nombre {  get; set; }

        public string Descripcion {  get; set; }

        public double Recompensa {  get; set; }
        #endregion

        #region Constructores
            
        public ClsMision() { }

        public ClsMision(long id, string nombre, string descripcion, double recompensa)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }



        #endregion

    }
}
