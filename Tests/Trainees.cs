

namespace Unit_Testing.Tests
{
    public class Trainees
    {
        private  List<string> _studentList = new List<string>();

         public int student_count => _studentList.Count;

        public void addStudent(string studentName)
        {
            //nullChecking
            if (string.IsNullOrEmpty(studentName))
                throw new ArgumentNullException("name is required");
            _studentList.Add(studentName);
        }
        public void removeStudent(string studentName)
        {
            //nullChecking
            if (string.IsNullOrEmpty(studentName))
                throw new ArgumentNullException("name is required");
            _studentList.Remove(studentName);
        }
        public string searchStudent(string studentName)
        {
            //nullChecking
            if (string.IsNullOrEmpty(studentName))
                throw new ArgumentNullException("name is required");
            var name = _studentList.Find(x => x == studentName);
            if(name != null)
            {
                return name;
            }
            return string.Empty;
        }
    }
}
