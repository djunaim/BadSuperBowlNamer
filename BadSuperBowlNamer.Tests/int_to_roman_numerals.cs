using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class int_to_roman_numerals
    {
        // Fact tells method I am on top of is a test. Tells xUnit to run test method
        [Fact]

        // optimize names for readability, even though would never name methods like this
        // always return void
        public void translating_1_results_in_I()
        {
            // Arrange (set up context)
            var num = 1;
            var expectedResult = "I";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_3_results_in_III()
        {
            // Arrange (set up context)
            var num = 3;
            var expectedResult = "III";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_5_results_in_V()
        {
            // Arrange (set up context)
            var num = 5;
            var expectedResult = "V";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_9_results_in_IX()
        {
            // Arrange (set up context)
            var num = 9;
            var expectedResult = "IX";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_12_results_in_XII()
        {
            // Arrange (set up context)
            var num = 12;
            var expectedResult = "XII";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_14_results_in_XIV()
        {
            // Arrange (set up context)
            var num = 14;
            var expectedResult = "XIV";
            var translator = new Translator();

            // Act (doing the thing we're testing)
            var actualResult = translator.Translate(num);

            // Assert (verifying result) - uses assertion library
            // Equal method give me 2 things and I'll tell you if those 2 things are equal
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
