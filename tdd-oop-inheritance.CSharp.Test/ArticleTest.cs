using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        private Author _author = new("John Doe", "john@doe.com", "https://doe.com");
        [Test]
        public void shouldCheckOutIfAvailable()
            {
                Article article = new ("JUnit Rocks", _author);
                Assert.AreEqual("item has been checked out", article.CheckOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
                Article article = new ("JUnit Rocks", _author);
                article.CheckOut();

                Assert.AreEqual("item is currently on loan", article.CheckOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
                Article article = new ("JUnit Rocks", _author);
                article.CheckOut();

                Assert.AreEqual("item has been checked in", article.CheckIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
                Article article = new ("JUnit Rocks", _author);

                Assert.AreEqual("item is not currently on loan", article.CheckIn());
            }
    }
}