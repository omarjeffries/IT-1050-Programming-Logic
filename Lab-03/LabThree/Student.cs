namespace LabThree
{
    class Student
    {
        private string Name;
        private int Grade;
        private string Teacher;

        public Student(string thierName, string thierTeacher)
        {
            this.Name = thierName;
            this.Teacher = thierTeacher;
        }

        public Student(int Grade)
        {
            this.Grade = 0;
        }

        public int SetGrade(int thisGrade)
        {
            int output = this.Grade; 
        }

    }
}