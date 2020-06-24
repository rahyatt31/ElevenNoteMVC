using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate                                                             // This class is for Creating the Properties for the 
                                                                                            // "Create" action for Categories 
    {
        [Required]                                                                          // The "Required" attribute ensures that the user does not enter a "null" value
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]                // The "MinLength" attribute is set up to have at least TWO Characters and to give an error message otherwise
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]     // The "MaxLength" attribute is set up to have less than 101 Characters and to give an error message otherwise
        public string Name { get; set; }                                                    // Creating a String Property for the Name of the Catergory created
    }
}
