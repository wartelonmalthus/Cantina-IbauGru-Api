namespace CantinaIbauGru.Domain.Entities;

public abstract class Register
{
    public int Id {  get; set; }
    public bool softDelete { get;  set; }
    public DateTime CreateAt {  get; private set; }
    public DateTime UpdateAt { get; set; }

    protected Register()
    {
        softDelete = false;
        CreateAt = DateTime.UtcNow;
    }

    public DateTime MudarDataDeCriacao(DateTime data)
    {
        CreateAt = data;
        return CreateAt;
    }
}
