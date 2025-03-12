using anchicoque_backend.Models.Enums;

namespace anchicoque_backend.Models;

public class Product 
{
    public required string IdReference {get; set;}
    public required string Name {get; set;}
    public required ProductType Type {get; set;}
    public string? Description {get; set;}


    public List<ProductImage> Images {get; set;} = [];

    
}