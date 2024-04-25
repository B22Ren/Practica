using System.ComponentModel.DataAnnotations;

public class Client
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}