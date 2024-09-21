public class NavigationHistoryService
{
    private Stack<string> _history = new Stack<string>();

    public void AddToHistory(string uri)
    {
        _history.Push(uri);
    }

    public string GoBack()
    {
        return _history.Count > 0 ? _history.Pop() : "/";
    }
}
