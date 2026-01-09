using PeopleProject;
using NUnit.Framework;

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
            person2 = new Person(12, "Gábor", 40, true, 45);
            person3 = new Person(13, "Hanna", 21, true, 95);
            person4 = new Person(14, "Isti", 23, true, 38);
            person5 = new Person(15, "Juli", 35, false, 77);

            _testPeople2 = new[] { person1, person2, person3, person4, person5 };
        }

        [Test]
        public void SetPeople_SetsPeopleArray1()
        {
            var stats = new PeopleStatistics(System.Array.Empty<Person>());
            Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(0));

            stats.SetPeople(_testPeople);
            Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(3));
        }

        [Test]
        public void SetPeople_SetsPeopleArray2()
        {
            var stats = new PeopleStatistics(System.Array.Empty<Person>());
            Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(0));

            stats.SetPeople(_testPeople2);
            Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(4));
        }

        [Test]
        public void GetAverageAge_ReturnsAverageAge1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var avg = stats.GetAverageAge();
            Assert.That(avg, Is.EqualTo(25));
        }

        [Test]
        public void GetAverageAge_ReturnsAverageAge2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var avg2 = stats2.GetAverageAge();
            Assert.That(avg2, Is.EqualTo(27.6));
        }

        [Test]
        public void GetNumberOfStudents_ReturnsStudentsCount1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var count = stats.GetNumberOfStudents();
            Assert.That(count, Is.EqualTo(3));
        }

        [Test]
        public void GetNumberOfStudents_ReturnsStudentsCount2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var count2 = stats2.GetNumberOfStudents();
            Assert.That(count2, Is.EqualTo(4));
        }

        [Test]
        public void GetPersonWithHighestScore_ReturnsCorrectPerson1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var result = stats.GetPersonWithHighestScore();
            Assert.That(result.name, Is.EqualTo("Dóra"));
            Assert.That(result.score, Is.EqualTo(90));
        }

        [Test]
        public void GetPersonWithHighestScore_ReturnsCorrectPerson2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var result2 = stats2.GetPersonWithHighestScore();
            Assert.That(result2.name, Is.EqualTo("Hanna"));
            Assert.That(result2.score, Is.EqualTo(95));
        }

        [Test]
        public void GetAverageScoreOfStudents_ReturnsAverageStudentScore1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var avg = stats.GetAverageScoreOfStudents();
            Assert.That(avg, Is.EqualTo(70));
        }

        [Test]
        public void GetAverageScoreOfStudents_ReturnsAverageStudentScore2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var avg2 = stats2.GetAverageScoreOfStudents();
            Assert.That(avg2, Is.EqualTo(58.25));
        }

        [Test]
        public void GetOldestStudent_ReturnsOldestStudent1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var result = stats.GetOldestStudent();
            Assert.That(result.name, Is.EqualTo("Dóra"));
            Assert.That(result.age, Is.EqualTo(30));
        }

        [Test]
        public void GetOldestStudent_ReturnsOldestStudent2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var result2 = stats2.GetOldestStudent();
            Assert.That(result2.name, Is.EqualTo("Gábor"));
            Assert.That(result2.age, Is.EqualTo(40));
        }

        [Test]
        public void IsAnyoneFailing_ReturnsTrueWhenSomeoneFails1()
        {
            var stats = new PeopleStatistics(_testPeople);
            var failing = stats.IsAnyoneFailing();
            Assert.That(failing, Is.True);
        }

        [Test]
        public void IsAnyoneFailing_ReturnsTrueWhenSomeoneFails2()
        {
            var stats2 = new PeopleStatistics(_testPeople2);
            var failing2 = stats2.IsAnyoneFailing();
            Assert.That(failing2, Is.True);
        }
    }
}