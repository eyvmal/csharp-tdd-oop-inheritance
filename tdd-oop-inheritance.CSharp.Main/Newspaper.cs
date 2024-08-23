namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper(string title) : LibraryItem(title)
    {
        public override string CheckIn()
        {
            return "newspapers are not available for loan";
        }
        
        public override string CheckOut()
        {
            return "newspapers are not available for loan";
        }
    }
}
