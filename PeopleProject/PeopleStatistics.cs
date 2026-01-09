namespace PeopleProject
{
    public class PeopleStatistics
    {
        private Person[] _people;

        public PeopleStatistics(Person[] people)
        {
            _people = people ?? Array.Empty<Person>();
        }

        public void SetPeople(Person[] people)
        {
            _people = people ?? Array.Empty<Person>();
        }

        public double GetAverageAge()
        {
            if (_people.Length == 0) return 0;
            return _people.Average(p => p.age);
        }

        public int GetNumberOfStudents()
        {
            return _people.Count(p => p.isStudent);
        }

        public Person GetPersonWithHighestScore()
        {
            if (_people.Length == 0) throw new InvalidOperationException("No people available");
            return _people.MaxBy(p => p.score)!;
        }

        public double GetAverageScoreOfStudents()
        {
            var students = _people.Where(p => p.isStudent).ToArray();
            if (students.Length == 0) return 0;
            return students.Average(s => s.score);
        }

        public Person GetOldestStudent()
        {
            var students = _people.Where(p => p.isStudent).ToArray();
            if (students.Length == 0) throw new InvalidOperationException("No students available");
            return students.MaxBy(s => s.age)!;
        }

        public bool IsAnyoneFailing()
        {
            return _people.Any(p => p.score < 40);
        }
    }
}