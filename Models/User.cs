using anchicoque_backend.Models.Enums;

namespace anchicoque_backend.Models;

public class User 
{
    public required string Id {get; set;}
    public required string Name {get; set;}
    public required string LastName {get; set;}
    public required string Email {get; set;}
    public required string Password {get; set;}
    public DateTime CreatedAt {get; set;}
    public UserRole Role {get; set;} = UserRole.CUSTOMER;

    //TODO revisar que mas campos agregar

}