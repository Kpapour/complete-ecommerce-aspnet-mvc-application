using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ProducerModel
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }
    }
}
