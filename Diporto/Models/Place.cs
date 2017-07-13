using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diporto.Models {
  [Table("place")]
  public class Place {
    [Column("id")]
    public int Id { get; set; }
    
    [Required]
    [Column("name")]
    public string Name { get; set; }
    
    [Required]
    [Column("lat")]
    public float Lat { get; set; }
    
    [Required]
    [Column("lon")]
    public float Lon { get; set; }
    
    [Required]
    [Column("phone")]
    public string Phone { get; set; }
    
    [Required]
    [Column("address")]
    public string Address { get; set; }
    
    [Required]
    [Column("opening_hours")]
    public string OpeningHours { get; set; }
    
    public ICollection<PlaceCategory> PlaceCategories { get; set; }
    
    public ICollection<PlacePhoto> PlacePhotos { get; set; }

    public ICollection<PlaceReview> PlaceReviews { get; set; }
  }
}