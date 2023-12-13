using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    class ArticleTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
            {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Article article = new Article("JUnit Rocks", writer);
            Assert.AreEqual("item has been checked out", article.checkOut());
            }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
            {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Article article = new Article("JUnit Rocks", writer);
            article.checkOut();

            Assert.AreEqual("item is currently on loan", article.checkOut());
            }

        [Test]
        public void shouldCheckInIfOnLoan()
            {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Article article = new Article("JUnit Rocks", writer);
            article.checkOut();

            Assert.AreEqual("item has been checked in", article.checkIn());
            }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
            {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Article article = new Article("JUnit Rocks", writer);
            Assert.AreEqual("item is not currently on loan", article.checkIn());
            }
    }
}