namespace anchicoque_backend.Models;


public class Product 
{
    public required string Id {get; set;}
    public required string Name {get; set;}
    
    //Relacion 1 a N con ProductType
    public required string IdType {get; set;}
    public ProductType Type {get; set;} = null!;

    public string? Description {get; set;}
    public required int Height {get; set;}
    public required int Width {get; set;}
    public required int Depth {get; set;}

    public List<ProductImage> Images {get; set;} = [];
    public List<Line> Lines {get;set;} =[]; 
    

    
}