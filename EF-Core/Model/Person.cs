using System.ComponentModel.DataAnnotations;

namespace Model;

public class Person
{
    public int PersonId { get; set; }
    [ConcurrencyCheck]
    public int SocialSecurityNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}