using System.Collections.Generic;

namespace StudentModels
{
    public class StudentDetail : Student
    {
        public string Class { get; set; }
        public string AdmissionNumber { get; set; }
        public List<SubjectDetails> Subjects { get; set; }
    }
}
