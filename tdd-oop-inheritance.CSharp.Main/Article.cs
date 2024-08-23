namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article(string title, Author author) : LibraryItem(title)
    {
        private Author _author = author;
    }
}
