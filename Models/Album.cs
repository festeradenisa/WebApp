using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Xml.Linq;

namespace WebAppCrud.Models
{
    public class Album
    {
        public int ID { get; set; }

        [Display(Name = "Album Title")]
        public string Title { get; set; }

        [Display(Name = "Album Price")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Album Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? ArtistID { get; set; }
        public Artist? Artist { get; set; }
    }

}

