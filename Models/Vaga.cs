using System.Reflection.Metadata.Ecma335;

namespace EstacionaFacil.Models
{
    public class Vaga
    {
        public int Id { get; set; } = default!;
        public string CodigoLocalizacao { get; set; } = default!;
        public bool Ocupada { get; set; } = default!;
        
    }
}
