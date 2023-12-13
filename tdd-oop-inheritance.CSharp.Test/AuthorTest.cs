using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class AuthorTest
    {
        [Test]// check that book has author
        public void Book_Author_Test()
        {
            //arrange
            Author writer = new Author() { name = "Thoreau", contact = "Not available", website = "Not available" };
            Book book = new Book("Walden", writer);

            //act
            string expected = "Thoreau";
            string result = book.Author.name;

            //assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test] //check that article has author

        public void Article_Author_Test()
        {
            //arrange
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            Article article = new Article("Fake news", writer);

            //act
            string expected = "Nikita";
            string result = article.Author.name;

            //assert
            Assert.That(expected, Is.EqualTo(result));
        }

    }
}
