using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckItTwice.Models
{
  public class ListItem
  {
    public ListItem() { }
    public int Id { get; set; }
    public required string Title { get; set; }
    public required int Quantity { get; set; }

    [DataType(DataType.Url)]
    public string? Url { get; set; }

    [DataType(DataType.Currency)]
    public decimal? Price { get; set; }
    public string? Description { get; set; }
    
  }
}
