using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }
    }
}
