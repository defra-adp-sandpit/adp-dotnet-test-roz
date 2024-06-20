using System.ComponentModel.DataAnnotations;

namespace Adp.Dotnet.Test.Roz.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

