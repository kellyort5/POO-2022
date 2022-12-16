namespace TalleresGraficosU
{
    public class pagoss
    {
        public string efectivo { get; set; }
        public string tarjeta { get; set; }

        public pagoss(string efectivo, string tarjeta)
        {
            this.efectivo = efectivo ;
            this.tarjeta = tarjeta ;
        }
    }
}