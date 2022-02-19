using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGame.Web.Models
{
    //[Table("Gamer"]
    [Table("Gamer", Schema = "dbo")]
    public class Gamer
    {
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TeamId { get; set; }
    }
}

/*
1.
////[Table("Gamer"]
//[Table("Gamer", Schema = "dbo")]
//...
//[Column("Name")]
//public string Name { get; set; }
Reference:
http://www.entityframeworktutorial.net/code-first/table-dataannotations-attribute-in-code-first.aspx
http://www.entityframeworktutorial.net/code-first/column-dataannotations-attribute-in-code-first.aspx
In order to map the Gamer Table entity into the Model, Models/Gamer.cs.
You need to add the [Table("Gamer")] attribute  in the class level.
Then the EntityFramework will automatically map the Gamer table fields into Gamer Model properties.
Gamer table field, id will automatically map to Gamer Model properties, id,
because it has the same name.
If you want to map 2 different name, then you need [Column("Name")] attribute.
//[Column("Name")]
//public string Name2 { get; set; }
This [Column("Name")] attribute
will map Table Column, Name, to Model Property, Name2.
*/