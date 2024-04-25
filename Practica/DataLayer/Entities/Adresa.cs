
public class Adresa
{
      [Key]
    public int Id { get; set; }
    public string Oras { get; set; }
    public string Strada { get; set; }
    public string CodPostal { get; set; }
    public string NumarStrada { get; set; }



    public int taraId { get; set; } 
    public Tara Tara { get; set; }
    // Other properties and methods
}