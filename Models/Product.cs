namespace anchicoque_backend.Models;

using anchicoque_backend.Models.Enums;

public class Product 
{
    public required string Id {get; set;}
    public required string Name {get; set;}
    public required ProductType Type {get; set;}
    public string? Description {get; set;}
    public required int Height {get; set;}
    public required int Width {get; set;}
    public required int Depth {get; set;}

    public List<ProductImage> Images {get; set;} = [];

    //un producto esta en varias lineas
    public List<Line> Lines {get;set;} =[]; 
    

    
}