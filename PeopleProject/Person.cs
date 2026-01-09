namespace PeopleProject
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public bool isStudent { get; set; }
        public int score { get; set; }

        public Person(int id, string name, int age, bool isStudent, int score)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.isStudent = isStudent;
            this.score = score;
        }
    }
}