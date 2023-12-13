using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Book book = new Book("JUnit Rocks", writer);
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Book book = new Book("JUnit Rocks", writer);
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Book book = new Book("JUnit Rocks", writer);
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Book book = new Book("JUnit Rocks", writer);

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}