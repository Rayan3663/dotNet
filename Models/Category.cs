using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FirstApp.Models
{
    public class Category
    {

        [Key]
        public int id { get; set; }

        public string Name { get; set; } Nullable<int> age { get; set; }

        public  int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
