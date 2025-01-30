using Microsoft.EntityFrameworkCore;
using test_dotnet1.Models;

namespace test_dotnet1.Data
{
    //ตัวแทนฐานข้อมูล
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) { 
            
        }

        //ตัวแทนในการสร้างตาราง
        public DbSet<Student> Students { get; set; }
    }
}
