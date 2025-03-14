namespace anchicoque_backend.Models;

public class Category 
{
    public required string Id {get; set;}
    public required string Name {get; set;}

    //Relacion 1 a N con ProductType
    public List<ProductType> Types {get; set;} = [];
}