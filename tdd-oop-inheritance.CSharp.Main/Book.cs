namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book(string title, Author author) : LibraryItem(title)
    {
        private Author _author = author;
    }
}
