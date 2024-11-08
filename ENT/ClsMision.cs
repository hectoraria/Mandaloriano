namespace ENT
{
    public class ClsMision
    {

        #region Propiedades

        public int Id { get; set; }

        public string Nombre {  get; set; }

        public string Descripcion {  get; set; }

        public double Recompensa {  get; set; }
        #endregion

        #region Constructores
            
        public ClsMision() { }

        public ClsMision(int id, string nombre, string descripcion, double recompensa)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }



        #endregion

    }
}
