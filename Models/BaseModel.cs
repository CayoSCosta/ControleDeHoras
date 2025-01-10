namespace ControleDeHoras.Models;

public class Base
{
    public Guid ID { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public DateTime DataDeModificacao { get; set; }
}
