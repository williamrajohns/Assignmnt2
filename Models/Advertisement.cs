using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab4.Models
{
    public enum Question
    {
        Earth,
        Computer
    }
    public class Advertisement
    {
        //these were commented out due to issues I had getting the create crud pages/nuget not working and I was desperate to try anything to see if it would fix it


        //[Required(ErrorMessage = "AnswerImageID is required")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerImageId { get; set; }

        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 characters, Minimum 3 characters.")]
        [Required]
        [DisplayName("File Name")]
        public string FileName { get; set; }

        //[Required(ErrorMessage = "URL is required")]
        //[StringLength(150, MinimumLength = 3, ErrorMessage = "Maximum 150 characters, Minimum 3 characters.")]
        [Required]
        [Url]
        public string Url { get; set; }

       
    }
}
