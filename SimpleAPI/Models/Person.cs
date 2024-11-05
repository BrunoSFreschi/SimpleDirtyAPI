namespace SimpleAPI.Models;

public class Person
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Adress { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
}