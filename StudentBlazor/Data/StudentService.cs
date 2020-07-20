using Newtonsoft.Json;
using StudentModels;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentBlazor.Data
{
    public class StudentService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public async Task<Student[]> GetAllStudentAsync(string token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync("http://localhost:8013/api/student/get-students");
            var studentJson = JsonConvert.DeserializeObject<Student[]>(await response.Content.ReadAsStringAsync());
            return studentJson;
        }

        public async Task<StudentDetail> GetStudentDetailAsync(int studentId, string token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync($"http://localhost:8013/api/student/get-studentById?studentId={studentId}");
            var studentDetail = JsonConvert.DeserializeObject<StudentDetail>(await response.Content.ReadAsStringAsync());
            return studentDetail;
        }

        public async Task<SubjectDetails> GetStudentMarksAsync(int studentId, int subjectId, string token)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync($"http://localhost:8013/api/student/get-student-marks/{studentId}/{subjectId}");
            var subjectDetail = JsonConvert.DeserializeObject<SubjectDetails>(await response.Content.ReadAsStringAsync());
            return subjectDetail;
        }
    }
}
