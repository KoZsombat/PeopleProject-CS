using PeopleProject;

namespace TestPeopleProject
{
    [TestFixture]
    public class TestPeople
    {
        private Person person1;
        private Person person2;
        private Person person3;
        private Person person4;
        private Person person5;
        private Person[] _testPeople;
        private Person[] _testPeople2;

        [SetUp]
        public void Setup()
        {
            person1 = new Person(1, "Anna", 20, true, 85);
            person2 = new Person(2, "Béla", 25, false, 70);
            person3 = new Person(3, "Cecil", 22, true, 35);
            person4 = new Person(4, "Dóra", 30, true, 90);
            person5 = new Person(5, "Erik", 28, false, 65);

            _testPeople = new[] { person1, person2, person3, person4, person5 };

            person1 = new Person(11, "Fanni", 19, true, 55);
            person2 = new Person(12, "Gábor", 40, false, 45);
            person3 = new Person(13, "Hanna", 21, true, 95);
            person4 = new Person(14, "Isti", 23, true, 38);
            person5 = new Person(15, "Juli", 35, false, 77);

            _testPeople2 = new[] { person1, person2, person3, person4, person5 };
        }

        [Test]
        public void SetPeople_SetsPeopleArray()
        {
            var stats = new PeopleStatistics(System.Array.Empty<Person>());
            Assert.AreEqual(0, stats.GetNumberOfStudents());

            stats.SetPeople(_testPeople);
            Assert.AreEqual(3, stats.GetNumberOfStudents());
            stats.SetPeople(_testPeople2);
            Assert.AreEqual(3, stats.GetNumberOfStudents());
        }

        [Test]
        public void GetAverageAge_ReturnsAverageAge()
        {
            var stats = new PeopleStatistics(_testPeople);
            var avg = stats.GetAverageAge();
            Assert.AreEqual(25, avg);
            var stats2 = new PeopleStatistics(_testPeople2);
            var avg2 = stats2.GetAverageAge();
            Assert.AreEqual(27.6, avg2);
        }

        [Test]
        public void GetNumberOfStudents_ReturnsStudentsCount()
        {
            var stats = new PeopleStatistics(_testPeople);
            var count = stats.GetNumberOfStudents();
            Assert.AreEqual(3, count);
            var stats2 = new PeopleStatistics(_testPeople2);
            var count2 = stats2.GetNumberOfStudents();
            Assert.AreEqual(3, count2);
        }

        [Test]
        public void GetPersonWithHighestScore_ReturnsCorrectPerson()
        {
            var stats = new PeopleStatistics(_testPeople);
            var result = stats.GetPersonWithHighestScore();
            Assert.AreEqual("Dóra", result.name);
            Assert.AreEqual(90, result.score);
            var stats2 = new PeopleStatistics(_testPeople2);
            var result2 = stats2.GetPersonWithHighestScore();
            Assert.AreEqual("Hanna", result2.name);
            Assert.AreEqual(95, result2.score);
        }

        [Test]
        public void GetAverageScoreOfStudents_ReturnsAverageStudentScore()
        {
            var stats = new PeopleStatistics(_testPeople);
            var avg = stats.GetAverageScoreOfStudents();
            Assert.AreEqual(70, avg);
            var stats2 = new PeopleStatistics(_testPeople2);
            var avg2 = stats2.GetAverageScoreOfStudents();
            Assert.AreEqual(62.666666666666664, avg2);
        }

        [Test]
        public void GetOldestStudent_ReturnsOldestStudent()
        {
            var stats = new PeopleStatistics(_testPeople);
            var result = stats.GetOldestStudent();
            Assert.AreEqual("Dóra", result.name);
            Assert.AreEqual(30, result.age);
            var stats2 = new PeopleStatistics(_testPeople2);
            var result2 = stats2.GetOldestStudent();
            Assert.AreEqual("Isti", result2.name);
            Assert.AreEqual(23, result2.age);
        }

        [Test]
        public void IsAnyoneFailing_ReturnsTrueWhenSomeoneFails()
        {
            var stats = new PeopleStatistics(_testPeople);
            var failing = stats.IsAnyoneFailing();
            Assert.IsTrue(failing);
            var stats2 = new PeopleStatistics(_testPeople2);
            var failing2 = stats2.IsAnyoneFailing();
            Assert.IsTrue(failing2);
        }
    }
}