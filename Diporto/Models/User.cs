using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Newtonsoft.Json;
using NpgsqlTypes;

namespace Diporto.Models {
  [Table("user")]
  [JsonObject(MemberSerialization.OptIn)]
  public class User : IdentityUser<int> {
    [Required]
    [Column("name")]
    [JsonProperty("name")]
    public string Name { get; set; }

    [Column("profile_image_url")]
    [JsonProperty("profile_image_url")]
    public string ProfileImageURL { get; set; }

    [Required]
    [Column("is_admin")]
    [JsonIgnore]
    public bool IsAdmin { get; set; }

    [Column("current_location")]
    [JsonProperty("current_location")]
    [JsonIgnore]
    public PostgisPoint CurrentLocation { get; set; }

    [NotMapped]
    public IEnumerable<int> Bookmarks { get; set; }
    
    [JsonIgnore]
    public ICollection<PlaceReview> PlaceReviews { get; set; }

    [JsonIgnore]
    public ICollection<RoomMembership> RoomMemberships { get; set; }

    [JsonIgnore]
    public ICollection<UserPlaceBookmark> PlaceBookmarks { get; set; }
  }
}
