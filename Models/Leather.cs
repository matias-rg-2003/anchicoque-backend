namespace anchicoque_backend.Models;

using anchicoque_backend.Models.Enums;

public class Leather 
{
    public required string Id {get; set;}
    public required string Name {get; set;}
    public required string PictureUrl {get; set;}
    public required LeatherType Type {get; set;}

    //un cuero esta en muchas lineas
    public List<Line> Lines {get; set;} = [];
} 