using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        private Author _author = new("John Doe", "john@doe.com", "https://doe.com");

        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new ("JUnit Rocks", _author);
            Assert.AreEqual("item has been checked out", book.CheckOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new ("JUnit Rocks", _author);
            book.CheckOut();

            Assert.AreEqual("item is currently on loan", book.CheckOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new ("JUnit Rocks", _author);
            book.CheckOut();

            Assert.AreEqual("item has been checked in", book.CheckIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new ("JUnit Rocks", _author);

            Assert.AreEqual("item is not currently on loan", book.CheckIn());
        }
    }
}