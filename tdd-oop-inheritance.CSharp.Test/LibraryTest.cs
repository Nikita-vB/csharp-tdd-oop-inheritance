using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {
        [Test]
        public void AddItem() //Check item is added
        {
            //arrange
            Library library = new Library();

            //act
            Author writer = new Author() { name = "Thoreau", contact = "Not available", website = "Not available" };
            library.addToStock(new Book("Walden", writer));
         

            //assert
            Assert.That(library.checkOutLibraryItem("Walden"), Is.Not.EqualTo("item is not part of the library's collection"));
        }

        [Test]
        public void CheckIn_1() //Check in item not on loan
        {
            //arrange
            Library library = new Library();

            //act
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            library.addToStock(new Book("Life of Pi", writer));

            //assert
            Assert.That(library.checkInLibraryItem("Life of Pi"), Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void CheckOut_1() //Check out item
        {
            //arrange
            Library library = new Library();

            //act
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            library.addToStock(new Book("Hitchhiker's Guide to the Galaxy", writer));


            //assert
            Assert.That(library.checkOutLibraryItem("Hitchhiker's Guide to the Galaxy"), Is.EqualTo("item has been checked out"));

        }

        [Test]
        public void CheckIn_2() //Check in item that was on loan
        {
            //arrange
            Library library = new Library();

            //act
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            library.addToStock(new Book("Life of Pi", writer));

            //assert
            Assert.That(library.checkInLibraryItem("Life of Pi"), Is.EqualTo("item is not currently on loan"));

        }

        [Test]
        public void CheckOut_2() //Try to Check out item that is already checked out
        {
            //arrange
            Library library = new Library();

            //act
            Author writer = new Author() { name = "Nikita", contact = "Not available", website = "Not available" };
            library.addToStock(new Book("The Quest", writer));
            library.checkOutLibraryItem("The Quest");

            //assert
            Assert.That(library.checkOutLibraryItem("The Quest"), Is.EqualTo("item is currently on loan"));

        }
    }
}
