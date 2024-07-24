using MyApplication;

namespace MyApplication.Nunit
{
    public class CalculateGradeTest
    {
        //UnitOfWork_Condition_ExpectedResult
        [Test]
        public void CalculateGrade_WithPoint0To59_ShouldTransferredToF() 
        {
            //Arrange
            var expectedGrade = "F";
            var pointList = new List<int> { 0, 10, 20, 59 };
            
            //Action && Assert
            foreach ( var point in pointList ) 
            {
               var result = Calculator.CalculateGrade(point);
                Assert.AreEqual(expectedGrade, result, $"Point: {point} should be graded as {expectedGrade}");

            }
            
        }
        [Test]
        public void CalculateGrade_WithPoint0To59_ShouldTransferredToD()
        {
            //Arrange
            var expectedGrade = "D";
            var pointList = new List<int> { 60,65,69 };

            //Action && Assert
            foreach (var point in pointList)
            {
                var result = Calculator.CalculateGrade(point);
                Assert.AreEqual(expectedGrade, result, $"Point: {point} should be graded as {expectedGrade}");

            }

        }
        [Test]
        public void CalculateGrade_WithPoint0To59_ShouldTransferredToC()
        {
            //Arrange
            var expectedGrade = "C";
            var pointList = new List<int> { 70,71,75,79 };

            //Action && Assert
            foreach (var point in pointList)
            {
                var result = Calculator.CalculateGrade(point);
                Assert.AreEqual(expectedGrade, result, $"Point: {point} should be graded as {expectedGrade}");

            }

        }
        [Test]
        public void CalculateGrade_WithPoint0To59_ShouldTransferredToB()
        {
            //Arrange
            var expectedGrade = "B";
            var pointList = new List<int> { 80,81,85,89};

            //Action && Assert
            foreach (var point in pointList)
            {
                var result = Calculator.CalculateGrade(point);
                Assert.AreEqual(expectedGrade, result, $"Point: {point} should be graded as {expectedGrade}");

            }

        }
        [Test]
        public void CalculateGrade_WithPoint0To59_ShouldTransferredToA()
        {
            //Arrange
            var expectedGrade = "A";
            var pointList = new List<int> { 90,91,99,100};

            //Action && Assert
            foreach (var point in pointList)
            {
                var result = Calculator.CalculateGrade(point);
                Assert.AreEqual(expectedGrade, result, $"Point: {point} should be graded as {expectedGrade}");

            }

        }

    }
}