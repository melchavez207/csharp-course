namespace Test.DataStructures
{
    public class TestDoublyLinkedList
    {
        [Fact]
        public void AddFirst_ShouldInsertAtFront()
        {
            var list = new DoublyLinkedList<string>();
            list.AddFirst("Carlos");
            list.AddFirst("Sergio");
            list.AddFirst("Fabricio");

            var result = list.Get(0);

            Assert.Equal("Fabricio", result);
        }

        [Fact]
        public void AddLast_ShouldInsertAtEnd()
        {
            var list = new DoublyLinkedList<string>();
            list.AddLast("Carlos");
            list.AddLast("Sergio");
            list.AddLast("Fabricio");

            var result = list.Get(2);

            Assert.Equal("Fabricio", result);
        }

        [Fact]
        public void ToReversedArray_ShouldReturnCorrectReverseOrder()
        {
            // TODO: Complete the test

            // Assert.Equal(new[] {1, 2, 3}, list.ToReversedArray());
        }

        [Fact]
        public void Get_ShouldReturnCorrectElement()
        {
            // TODO: Complete the test

            // Assert.Equal('A', list.Get(0));
            // Assert.Equal('B', list.Get(1));
            // Assert.Equal('C', list.Get(2));
        }

        [Fact]
        public void Get_ShouldThrow_WhenIndexInvalid()
        {
            // TODO: Complete test

            // Assert.Throws<ArgumentOutOfRangeException>(() => list.Get(-1));
        }

        [Fact]
        public void Contains_ShouldReturnTrueIfValueExists()
        {
            // TODO: Complete test

            // Assert.True(list.Contains("Carlos"));
        }

        [Fact]
        public void Remove_ShouldRemoveExistingValue()
        {
            // TODO: Complete test

            // Assert.True(result);
            // Assert.Equal(2, list.Count);
            // Assert.Equal(new[] { 1, 3 }, list.ToArray());
        }

        [Fact]
        public void Remove_ShouldReturnFalseIfNotFound()
        {
            // TODO: Complete test

            // Assert.False(result);
            // Assert.Equal(3, list.Count);
            // Assert.Equal(new[] { 1, 2, 3 }, list.ToArray());
        }

        // OPTIONAL: Add more tests if wanted
    }
}
