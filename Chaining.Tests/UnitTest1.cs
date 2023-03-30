using Chaining_and_Continuation;
using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Chaining_and_Continuation.Tasks;

namespace Chaining.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TenRandomIntsTest()
        {
            //Arrange
            int size = 10;

            //Act
            int[] array = TenRandomInts();

            //Assert
            array.ShouldSatisfyAllConditions(
                () => array.ShouldNotBeNull(),
                () => array.Length.ShouldBe(size),
                () => array.ShouldAllBe(x => x >= 1 && x <= 100)
            );
        }

        [Fact]
        public void MultiplyRandomArrayTest()
        {
            ////Arrange
            //int[] array = Enumerable.Range(1, 10).ToArray();

            // Arrange
            int[] arr = new int[] { 1, 2, 3 };
            int[] expected = arr.Select(i => i * new Random().Next(1, 11)).ToArray();

            // Act
            int[] result = MultiplyRandomArray(arr);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void SortArrayByAscendingTest()
        {
            //Arrange
            int[] array = new[] { 5, 3, 8, 1, 7 };
            int[] expected = new[] { 1, 3, 5, 7, 8 };

            //Act
            SortAscending(array);

            //Assert
            array.ShouldBe(expected);
        }

        [Fact]
        public void CalculateAverageValueTest()
        {
            //Arrange
            int[] array = new[] { 2, 4, 6, 8 };

            //Act
            double result = GetAverageValue(array);

            //Assert
            result.ShouldBe(5);
        }
    }
}

