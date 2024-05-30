namespace HusSagLib
{
    public class HusSag
    {
        public int Id { get; set; }
        public string? Vej { get; set; }
        public int HusNr { get; set; }
        public string? By { get; set; }
        public int Pris { get; set; }

        public override string ToString() //Overskriver ToString metoden, så den returnerer en string med alle properties 
        {
            return $"id: {Id}, Vej: {Vej}, HusNr: {HusNr}, By: {By}, Pris: {Pris}";
        }
    }
}
