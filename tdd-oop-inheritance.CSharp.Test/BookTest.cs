using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author author = new("John Doe");
            Book book = new ("JUnit Rocks", author);
            Assert.AreEqual("item has been checked out", book.CheckOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author author = new("John Doe");
            Book book = new ("JUnit Rocks", author);
            book.CheckOut();

            Assert.AreEqual("item is currently on loan", book.CheckOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author author = new("John Doe");
            Book book = new ("JUnit Rocks", author);
            book.CheckOut();

            Assert.AreEqual("item has been checked in", book.CheckIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author author = new("John Doe");
            Book book = new ("JUnit Rocks", author);

            Assert.AreEqual("item is not currently on loan", book.CheckIn());
        }
    }
}