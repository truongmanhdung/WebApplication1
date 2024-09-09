using NuGet.Versioning;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
        [StringLength(100,ErrorMessage = "Tên phải lớn hơn 4 ký tự, nhỏ hơn 100 ký tự", MinimumLength = 4)]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; } //Email

        [StringLength(100, ErrorMessage = "Mật khẩu phải lớn hơn 8 ký tự, nhỏ hơn 100 ký tự", MinimumLength = 8)]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        public string? Password { get; set; }//Mật khẩu

        [Required(ErrorMessage = "Ngành học bắt buộc phải được nhập")]
        public Branch? Branch { get; set; }//Ngành học

        [Required(ErrorMessage = "Giới tính bắt buộc phải được nhập")]
        public Gender? Gender { get; set; }//Giới tính

        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }//Địa chỉ

        [Range(typeof(DateTime), "1/1/1963", "31/12/2024")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập")]
        public DateTime DateOfBirth { get; set; }//Ngày sinh


        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10")]
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        public double Score { get; set; } // Điểm
    }

}
