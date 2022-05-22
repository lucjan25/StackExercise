using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackExerciseBiblioteka;

namespace StackUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsEmpty()
        {
            StackClass TestStack = new StackClass();
            bool stackEmpty = TestStack.isEmpty();

            Assert.IsTrue(stackEmpty, "Nowy stos nie jest pusty.");
        }
        [TestMethod]
        public void TestPush()
        {
            StackClass TestStack = new StackClass();
            TestStack.push("testString");
            bool stackEmpty = TestStack.isEmpty();

            Assert.IsFalse(stackEmpty, "Stos z jednym elementem jest pusty.");
        }
        [TestMethod]
        public void TestPop()
        {
            StackClass TestStack = new StackClass();
            string testString1 = "testString1";
            string testString2 = "testString2";
            TestStack.push(testString1);
            TestStack.push(testString2);
            string stackString2 = TestStack.pop();
            string stackString1 = TestStack.pop();

            Assert.AreEqual(testString2, stackString2, "Pop nie zwraca szczytu stosu");
            Assert.AreEqual(testString1, stackString1, "Pop nie zdejmuje elementu ze stosu");
        }
        [TestMethod]
        [ExpectedException(typeof(StackEmptyException))]
        public void TestPopException()
        {
            StackClass TestStack = new StackClass();
            TestStack.pop();
        }
        [TestMethod]
        public void TestTop()
        {
            StackClass TestStack = new StackClass();
            string testString1 = "testString1";
            string testString2 = "testString2";
            TestStack.push(testString1);
            string stackString1 = TestStack.top();
            TestStack.push(testString2);
            string stackString2 = TestStack.top();
            

            Assert.AreEqual(testString2, stackString2, "Top nie zwraca szczytu stosu po dodaniu kolejnego elementu");
            Assert.AreEqual(testString1, stackString1, "Top nie zwraca szczytu stosu po dodaniu pierwszego elementu");
        }
        [TestMethod]
        [ExpectedException(typeof(StackEmptyException))]
        public void TestTopException()
        {
            StackClass TestStack = new StackClass();
            TestStack.top();
        }
    }
}
