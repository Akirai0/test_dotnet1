using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace test_dotnet1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="กรุณาใส่ชื่อนักศึกษา!!!!!!")]
        [DisplayName("ชื่อนักศึกษา")]
        public string Name { get; set; }
        [DisplayName("คะแนนสอบ")]
        [Range(0, 100, ErrorMessage ="กรุณาใส่คะแนนในช่วง 0 - 100")]
        public int Score { get; set; }
    }
}
