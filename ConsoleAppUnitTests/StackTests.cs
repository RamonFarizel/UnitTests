using System;
using ConsoleApp;
using Xunit;

namespace ConsoleAppUnitTests
{
    public class StackTests
    {
        Stack<string> _stack;

        public StackTests()
        {
            _stack = new Stack<string>();
        }

        [Fact]
        public void Push_WhenNullValueIsPassed_ThrowsNullExceptiojn()
        {
            //Arrange
            string value = null;

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => _stack.Push(value));
        }

        [Fact]
        public void Push_WhenItemIsAdded_VerifyListCountGreaterThanZero()
        {
            //Arrange
            string value = "A";

            //Act
            _stack.Push(value);

            //Assert
            Assert.NotEqual(0,_stack.Count);
        }

        [Fact]
        public void Pop_WhenListDontHaveItens_ReturnInvalidOperationException()
        {
            //Arrange


            //act

            //Assert
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Fact]
        public void Pop_WhenHaveItens_RemoveLastItemAndReturn()
        {
            //Arrange
            

            //act
            _stack.Push("A");
            _stack.Push("B");

            var expected = _stack.Peek();
            var result = _stack.Pop();

            //Assert
            Assert.NotEqual(expected,result);
        }
    }
}
