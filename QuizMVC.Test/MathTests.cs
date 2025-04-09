using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMVC.Test
{
    public class MathTests
    {
        [Fact]
        public void Adding_2_And_2_Should_Be_4()
        {
            // Arrange
            var a = 2;
            var b = 2;

            // Act
            var result = a + b;

            // Assert
            Assert.Equal(4, result);
        }
    }
}
