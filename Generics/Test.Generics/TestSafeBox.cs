using Generics;

namespace Test.Generics
{
    public class TestSafeBox
    {
        // TODO: Add positive scenario

        [Fact]
        public void SafeBox_ShouldThrowIfNull()
        {
            Assert.Throws<ArgumentNullException>(() => new SafeBox<string>(null));
        }
    }
}
