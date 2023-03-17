using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleAppProjectTest
{
    [TestClass]

    public class TestStudentGrades
    {
        private readonly StudentGrades con = new StudentGrades();
        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]{
                10,20,30,40,50,60,70,80,90,100
            };
        }


        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;
            //Act
            Grades actualGrade = con.ConvertToGrade(0);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;
            //Act
            Grades actualGrade = con.ConvertToGrade(39);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert0ToGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;
            //Act
            Grades actualGrade = con.ConvertToGrade(40);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestConvert0ToGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;
            //Act
            Grades actualGrade = con.ConvertToGrade(50);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestConvert0ToGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;
            //Act
            Grades actualGrade = con.ConvertToGrade(60);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }
        [TestMethod]
        public void TestConvert0ToGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;
            //Act
            Grades actualGrade = con.ConvertToGrade(70);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            //Arrange
            con.Marks = testMarks;
            double expectedMean = 55.0;
            //Act
            con.CalculateStats();
            //Assert
            Assert.AreEqual(expectedMean, con.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange
            con.Marks = testMarks;
            int expectedMin = 10;
            //Act
            con.CalculateStats();
            //Assert
            Assert.AreEqual(expectedMin, con.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            //Arrange
            con.Marks = testMarks;
            int expectedMax = 100;
            //Act
            con.CalculateStats();
            //Assert
            Assert.AreEqual(expectedMax, con.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            //Arrange
            con.Marks = testMarks;
            bool expectedProfile = false;

            //Act
            con.CalGradePro();
            expectedProfile = ((con.GradeProfile[0] == 3) &&
                               (con.GradeProfile[1] == 1) &&
                               (con.GradeProfile[2] == 1) &&
                               (con.GradeProfile[3] == 1) &&
                               (con.GradeProfile[4] == 4));
            //Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}