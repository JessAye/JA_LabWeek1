namespace JA_LabWeek1.Models
{
    public class Student
    {
        public string name { get; set; }
       public LetterGrade grade {get; set;}
        public Student(string name, LetterGrade grade) {
            this.name = name;
            this.grade = grade;
        
        }
    }
}
