using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Author author = new("John Doe");
                Article article = new ("JUnit Rocks", author);
                Assert.AreEqual("item has been checked out", article.CheckOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Author author = new("John Doe");
                Article article = new ("JUnit Rocks", author);
                article.CheckOut();

                Assert.AreEqual("item is currently on loan", article.CheckOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Author author = new("John Doe");
                Article article = new ("JUnit Rocks", author);
                article.CheckOut();

                Assert.AreEqual("item has been checked in", article.CheckIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Author author = new("John Doe");
                Article article = new ("JUnit Rocks", author);

                Assert.AreEqual("item is not currently on loan", article.CheckIn());
            }
    }
}