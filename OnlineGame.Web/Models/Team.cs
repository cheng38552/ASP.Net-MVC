using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGame.Web.Models
{
    //[Table("Gamer"]
    [Table("Team", Schema = "dbo")]
    public class Team
    {
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public List<Gamer> Gamers { get; set; }
    }
}