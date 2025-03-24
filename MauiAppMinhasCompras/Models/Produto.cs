using SQLite;

namespace MauiAppMinhasCompras.Models
{
    // Classe que representa um produto
    internal class Produto
    {
        // Campo privado para armazenar a descrição do produto
        private string _descricao;

        // Define a chave primária e a autoincrementação no banco de dados
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Propriedade para acessar e modificar a descrição do produto
        public string Descricao
        {
            get => _descricao;
            set
            {
                // Verifica se a descrição é nula e lança uma exceção se for
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }
                _descricao = value;
            }
        }

        // Propriedade que representa a quantidade do produto
        public double Quantidade { get; set; }

        // Propriedade que representa o preço do produto
        public double Preco { get; set; }

        // Propriedade que calcula o valor total do produto (quantidade * preço)
        public double Total { get => Quantidade * Preco; }
    }
}
