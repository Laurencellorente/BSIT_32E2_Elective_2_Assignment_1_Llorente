namespace BSIT_32E2_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public Dictionary<string, string> Options { get; set; } = new();
        public string CorrectOption { get; set; } = string.Empty;
    }
}