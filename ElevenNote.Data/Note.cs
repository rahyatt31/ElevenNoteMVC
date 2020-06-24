using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note                                               // This class is for Creating our Note Properties
    {
        [Key]                                                       // The "Key" tag is used for uniquely identifying an enitity.
        public int NoteId { get; set; }                             // Creating our NoteID Property which is our unique primary key

                                                                    // A single user could have multiple notes, or different users could add a 
                                                                    // note at the same time, so we need some sort of property that returns a 
                                                                    // unique note number. In other words the "Primary KEY" will always be a 
                                                                    // unique number.

        [Required]                                                  // The "Required" attribute ensures that the user does not enter a "null" value
        public Guid OwnerID { get; set; }                           // GUID stands for Global Unique Identifier...meaning we are giving this property a unique ID to associate with
        [Required]
        public string Title { get; set; }                           // Creating a String Property for the Title of our Note
        [Required]
        public string Content { get; set; }                         // Creating a String Property for the Content of our Note

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }              // Creating a Property for when the category is "Created"
        public DateTimeOffset? ModifiedUtc { get; set; }            // Creating a Property for when the category is "Modified" or "Updated"


        //[ForeignKey("Category")]                                    // Category goes into Note, Note = Parent, Category = Child
        //public int CategoryID { get; set; }
        //public Category Category { get; set; }

        // public virtual Category Category {get; set;}
        // using virtual allows Override on Category

    }
}
