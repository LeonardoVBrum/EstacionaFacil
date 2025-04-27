namespace EstacionaFacil.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } = default!;
        public string Modelo { get; set; } = default!;
        public string Marca { get; set; } = default!;
        public int ClienteId { get; set; }

    }
}
