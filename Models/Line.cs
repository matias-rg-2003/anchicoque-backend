namespace anchicoque_backend.Models;

public class Line
{
    public required string Id {get; set;}
    public required string Name {get; set;}
    public string? Description {get; set;}

    //linea tiene muchos productos
    public List<Product> Products {get; set;} = []; 

    //linea tiene muchos cueros
    public List<Leather> Leathers {get; set;} = []; 
}