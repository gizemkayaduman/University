using System;
using System.ComponentModel.DataAnnotations;

namespace University.Models.Entities
{
    public class Student
    {
        [Key] // Primary Key olarak işaretleniyor
        public int SNUM { get; set; }  // Öğrenci numarası (Primary Key)

        [Required] // Zorunlu alan
        [StringLength(11, ErrorMessage = "SSSN en fazla 11 karakter olabilir.")]
        public string SSSN { get; set; }  // Kimlik numarası (Unique)

        [Required] // Zorunlu alan
        [StringLength(100, ErrorMessage = "İsim en fazla 100 karakter olabilir.")]
        public string NAME { get; set; }  // Öğrenci adı

        public string SCADDR { get; set; }  // Şu anki adres
        public string SCPHONE { get; set; }  // Şu anki telefon
        public string SPADDR { get; set; }  // Kalıcı adres
        public string SPPHONE { get; set; }  // Kalıcı telefon

        [Required] // Zorunlu alan
        public DateTime BDATE { get; set; }  // Doğum tarihi

        [Required] // Zorunlu alan
        public string SEX { get; set; }  // Cinsiyet

        public string CLASS { get; set; }  // Sınıf (Birinci sınıf, mezun vb.)
        public string PROG { get; set; }  // Program (lisans, yüksek lisans vb.)
        public string MAJOR { get; set; }  // Ana bölüm
        public string MINOR { get; set; }  // Yan bölüm
    }
}

