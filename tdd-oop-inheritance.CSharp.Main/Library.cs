namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryItem> _libraryItems = new List<LibraryItem>();

        public void addToStock(LibraryItem item) {
            _libraryItems.Add(item);
        }

        public string checkInItems(string title) {

            var filtered = _libraryItems.Where(x => x.Title.Equals(title)).ToList();

            return filtered.Count() < 1 ? "item is not part of the library's collection" : filtered[0].CheckIn();
        }

        public string checkOutItem(string title) {
            var filtered = _libraryItems.Where(x => x.Equals(title)).ToList();

            return filtered.Count() < 1 ? "item is not part of the library's collection" : filtered[0].CheckOut();
        }
    }
}
