using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentModels;
using System.Collections.Generic;
using System.Linq;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : Controller
    {
        public Student[] students = new Student[5]
            {new Student
                {
                    Id=1,FirstName="Sravan",LastName="Kumar"
                },
            new Student
                {
                    Id=2,FirstName="Yekanth",LastName="Kumar"
                },
            new Student
                {
                    Id=3,FirstName="Narender",LastName="Kumar"
                },
            new Student
                {
                    Id=4,FirstName="Ganapathi",LastName="Kumar"
                },
            new Student
                {
                    Id=5,FirstName="Sravani",LastName="Kumari"
                }
             };

        public StudentDetail[] studentDetails = new StudentDetail[5]
           {new StudentDetail
                {
                    Id=1,FirstName="Sravan",LastName="Kumar",Class="Tenth",AdmissionNumber="DPS1001",
                    Subjects=new List<SubjectDetails> {
                    new SubjectDetails{SubjectId=6,SubjectName="Maths",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=1,SubjectName="Science",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=2,SubjectName="Telugu",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=3,SubjectName="English",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=4,SubjectName="Social",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=5,SubjectName="Hindi",MarksObtained=70,MarksTotal=100}
                    }
                },
            new StudentDetail
                {
                    Id=2,FirstName="Yekanth",LastName="Kumar",Class="Tenth",AdmissionNumber="DPS1001",
                    Subjects=new List<SubjectDetails> {
                    new SubjectDetails{SubjectId=6,SubjectName="Maths",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=1,SubjectName="Science",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=2,SubjectName="Telugu",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=3,SubjectName="English",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=4,SubjectName="Social",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=5,SubjectName="Hindi",MarksObtained=70,MarksTotal=100}
                    }
                },
            new StudentDetail
                {
                    Id=3,FirstName="Narender",LastName="Kumar",Class="Tenth",AdmissionNumber="DPS1001",
                    Subjects=new List<SubjectDetails> {
                    new SubjectDetails{SubjectId=6,SubjectName="Maths",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=1,SubjectName="Science",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=2,SubjectName="Telugu",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=3,SubjectName="English",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=4,SubjectName="Social",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=5,SubjectName="Hindi",MarksObtained=70,MarksTotal=100}
                    }
                },
            new StudentDetail
                {
                    Id=4,FirstName="Ganapathi",LastName="Kumar",Class="Tenth",AdmissionNumber="DPS1001",
                    Subjects=new List<SubjectDetails> {
                    new SubjectDetails{SubjectId=6,SubjectName="Maths",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=1,SubjectName="Science",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=2,SubjectName="Telugu",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=3,SubjectName="English",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=4,SubjectName="Social",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=5,SubjectName="Hindi",MarksObtained=70,MarksTotal=100}
                    }
                },
            new StudentDetail
                {
                    Id=5,FirstName="Sravani",LastName="Kumari",Class="Tenth",AdmissionNumber="DPS1001",
                    Subjects=new List<SubjectDetails> {
                    new SubjectDetails{SubjectId=6,SubjectName="Maths",MarksObtained=70,MarksTotal=100},
                    new SubjectDetails{SubjectId=1,SubjectName="Science",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=2,SubjectName="Telugu",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=3,SubjectName="English",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=4,SubjectName="Social",MarksObtained=70,MarksTotal=100},
                        new SubjectDetails{SubjectId=5,SubjectName="Hindi",MarksObtained=70,MarksTotal=100}
                    }
                }
            };
        [HttpGet("get-students")]
        public IActionResult GetAllStudentsInfo()
        {
            return Json(this.students);
        }
        [HttpGet("get-studentById")]
        public IActionResult GetStudentById(int studentId)
        {
            return Json(this.studentDetails.FirstOrDefault(x => x.Id == studentId));
        }
        [HttpGet("get-student-marks/{studentId}/{subjectId}")]
        public IActionResult GetStudentMarksById(int studentId, int subjectId)
        {
            var obj = this.studentDetails.FirstOrDefault(x => x.Id == studentId).Subjects;
            //obj.ForEach(x => x.StudentId = studentId);
            return Json(obj.FirstOrDefault(x => x.SubjectId == subjectId));
        }
    }
}
