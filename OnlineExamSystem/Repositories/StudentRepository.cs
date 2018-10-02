using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamSystem.Data;
using OnlineExamSystem.Models;
using System.Web;
using System.IO;

namespace OnlineExamSystem.Repositories
{
    public class StudentRepository
    {
        private readonly ApplicationDbContext _context;

        public int UploadImageInDataBase(HttpPostedFileBase file, Student studentModel)
        {
            studentModel.Photo = ConvertToBytes(file);
            var Student = new Student()
            {
                Name = studentModel.Name,
                Email = studentModel.Email,
                PhoneNo = studentModel.PhoneNo,
                Nationality = studentModel.Nationality,
                Photo = studentModel.Photo

            };
            _context.Student.Add(Student);
            int i = _context.SaveChanges();
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}
