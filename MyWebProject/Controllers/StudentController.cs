using Microsoft.AspNetCore.Mvc;
using MyWebProject.Models;
using System.Collections.Generic;

namespace MyWebProject.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        // Tạo một danh sách sinh viên giả lập (Mock data)
        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Nguyễn Văn A", Major = "Công nghệ thông tin" },
            new Student { Id = 2, Name = "Trần Thị B", Major = "Marketing" },
            new Student { Id = 3, Name = "Lê Văn C", Major = "Quản trị kinh doanh" }
        };

        // Truyền danh sách này sang View
        return View(students);
    }
}
