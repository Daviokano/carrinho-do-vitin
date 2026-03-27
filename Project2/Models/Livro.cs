using System.ComponentModel;

namespace Project2.Models
{
    public class Livro
    {
        public int codLivro {  get; set; }

        [DisplayName("XYZ")] 

        public string nomeLivro { get; set; }

        public string imagemLivro { get; set; }

        public int quantidade { get; set; } 
    }
}
