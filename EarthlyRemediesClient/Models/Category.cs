using System.Collections.Generic;

namespace EarthlyRemediesClient.Models
{
  public class Category
  {
    public Category()
    {
      this.Remedies = new HashSet<CategoryRemedy>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<CategoryRemedy> Remedies { get; set; }
  }
}