using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category                                           // This class is for creating our Category Properties
    {
        [Key]                                                       // The "Key" tag is used for uniquely identifying an enitity.
        public int CategoryID { get; set; }                         // Creating our CategoryID Property

        [Required]                                                  // The "Required" attribute ensures that the user does not enter a "null" value
        public Guid OwnerID { get; set; }                           // GUID stands for Global Unique Identifier...meaning we are giving this property a unique ID to associate with
        [Required]
        public string Name { get; set; }                            // Creating a Name Property

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }              // Creating a Property for when the category is "Created"
        public DateTimeOffset? ModifiedUtc { get; set; }            // Creating a Property for when the category is "Modified" or "Updated"
        public ICollection<Note> Notes { get; set; }                // Note sure
    }
}
