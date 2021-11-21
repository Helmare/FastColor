using Xunit;

namespace Hazdryx.Drawing.FastColorTests
{
    /// <summary>
    ///     A test class for rgb24 operations in <code>FastColor</code>.
    /// </summary>
    public class Rgb24Test
    {
        #region Explode Tests
        [Theory]
        [InlineData(0xFF0000, 0xFF)]
        [InlineData(0x5F77AD, 0x5F)]
        [InlineData(0, 0)]
        public void Explode_OutputsCorrectRed(int color, int expected)
        {
            FastColor.Explode(color, out int r, out _, out _);
            Assert.Equal(expected, r);
        }
        [Theory]
        [InlineData(0xFF00, 0xFF)]
        [InlineData(0x5F77AD, 0x77)]
        [InlineData(0, 0)]
        public void Explode_OutputsCorrectGreen(int color, int expected)
        {
            FastColor.Explode(color, out _, out int g, out _);
            Assert.Equal(expected, g);
        }
        [Theory]
        [InlineData(0xFF, 0xFF)]
        [InlineData(0x5F77AD, 0xAD)]
        [InlineData(0, 0)]
        public void Explode_OutputsCorrectBlue(int color, int expected)
        {
            FastColor.Explode(color, out _, out _, out int b);
            Assert.Equal(expected, b);
        }
        #endregion

        #region Implode Tests
        [Theory]
        [InlineData(0xFF, 0xFF, 0xFF, 0xFFFFFF)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0x5F, 0x77, 0xAD, 0x5F77AD)]
        public void Implode_ReturnsCorrectValue(int r, int g, int b, int expected)
        {
            int color = FastColor.Implode(r, g, b);
            Assert.Equal(expected, color);
        }
        #endregion

        #region Reverse24 Tests
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0xFF0000, 0x0000FF)]
        [InlineData(0x00FF00, 0x00FF00)]
        [InlineData(0x0000FF, 0xFF0000)]
        [InlineData(0x5F77AD, 0xAD775F)]
        public void Reverse24_ReturnsCorrectValue(int color, int expected)
        {
            Assert.Equal(expected, FastColor.Reverse24(color));
        }
        #endregion
    }
}
