namespace tdd_oop_inheritance.CSharp.Main;

public class LibraryItem(string title)
{
    public string Title = title;
    private bool OnLoan { get; set; } = false;

    public virtual string CheckIn() {
        if (!OnLoan) {
            return "item is not currently on loan";
        }
        OnLoan = false;
        return "item has been checked in";
    }
    
    public virtual string CheckOut() {
        if (OnLoan) {
            return "item is currently on loan";
        }
        OnLoan = true;
        return "item has been checked out";
    }
}