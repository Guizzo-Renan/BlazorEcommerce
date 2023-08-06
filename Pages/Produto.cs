public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Custo { get; set; }
    public bool Promocao { get; set; }
    public string? Imagem { get; set; }
    public int Vendas { get; set; }

    private decimal Opreco; // Private backing field for the Preco property

        public decimal Preco
        {
            
            get
            {
                // Parse the Custo string and extract the numeric value
                if (decimal.TryParse(Custo?.Replace("R$", "").Trim(), out decimal preco))
                {
                    Opreco = preco;
                }
                return Opreco;
            }
            set
            {
                Opreco = value;
            }
        }

    public int Nota = 5;

    public string Tipo { get; set; }

    public string Descricao = "descricao descricao descricao descricao descricao descricao descricao descricao descricao";
}