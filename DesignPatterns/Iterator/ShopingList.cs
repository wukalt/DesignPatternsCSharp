namespace DesignPatterns.Iterator;

public class ShopingList
{
    private List<string> _items = new();

    public void Insert(string item)
    {
        _items.Add(item);
    }

    public string Pop()
    {
        string lastItem = _items.Last();
        _items.Remove(lastItem);
        return lastItem;
    }

    public IIterator<string> GetListIterator()
    {
        return new ListIterator(this);
    }

    private class ListIterator : IIterator<string>
    {
        private ShopingList _list;
        private int _index;

        public ListIterator(ShopingList list)
        {
            _list = list;
        }

        public string Current()
        {
            return _list._items[_index];
        }

        public bool HasNext()
        {
            return _index < _list._items.Count;
        }

        public void Next()
        {
            _index++;
        }
    }
}
