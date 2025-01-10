namespace ControleDeHoras.Models;

public class Registro : BaseModel
{
    public DateOnly DataDeInicio { get; set; }
    public TimeOnly HoraDeInicio { get; set; }
    public TimeOnly HoraDeTermino { get; set; }
    public TimeOnly HorasUtilizadas { get; set; }
    public string? Ticket { get; set; }
    public string? Cliente { get; set; }
    public string? Descricao { get; set; }
}
