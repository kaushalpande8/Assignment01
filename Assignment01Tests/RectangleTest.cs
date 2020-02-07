using NUnit.Framework;
using AssignmentQ01;

namespace Assignment01Tests
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void GetLength_IsTrue()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1, r.Lenght);
        }
        [Test]
        public void SetLength_IsTrue()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(7, r.SetLenght(7));
        }
        [Test]
        public void GetWidth_IsTrue()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(1, r.Width);
        }
        [Test]
        public void SetWidth_IsTrue()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(7, r.SetWidth(7));
        }
        [Test]
        public void FindPerimeter_IsTrue()
        {
            Rectangle r = new Rectangle();
            r.Lenght = 2;
            r.Width = 2;
            Assert.AreEqual(8, r.GetPerimeter());
        }
        [Test]
        public void FindArea_IsTrue()
        {
            Rectangle r = new Rectangle();
            r.Lenght = 2;
            r.Width = 2;
            Assert.AreEqual(4, r.GetArea());
        }
        [Test]
        public void GetLength_IsFalse()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(2, r.Lenght);
        }
        [Test]
        public void SetLength_IsFalse()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(6, r.SetLenght(7));
        }
        [Test]
        public void GetWidth_IsFalse()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(2, r.Width);
        }
        [Test]
        public void SetWidth_IsFalse()
        {
            Rectangle r = new Rectangle();
            Assert.AreEqual(6, r.SetWidth(7));
        }
        [Test]
        public void FindPerimeter_IsFalse()
        {
            Rectangle r = new Rectangle();
            r.Lenght = 9;
            r.Width = 2;
            Assert.AreEqual(3, r.GetPerimeter());
        }
        [Test]
        public void FindArea_IsFalse()
        {
            Rectangle r = new Rectangle();
            r.Lenght = 2;
            r.Width = 2;
            Assert.AreEqual(5, r.GetArea());
        }



    }
}
