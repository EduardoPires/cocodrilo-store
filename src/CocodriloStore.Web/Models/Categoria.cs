using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CocodriloStore.Web.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        public string Descricao { get; set; }
        
        public List<Produto> Produtos { get; set; } = new();
    }
}