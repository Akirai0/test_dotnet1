using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace test_dotnet1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("ชื่อนักศึกษา")]
        public string Name { get; set; }
        [DisplayName("คะแนนสอบ")]
        [Range(0, 100)]
        public int Score { get; set; }
    }
}
