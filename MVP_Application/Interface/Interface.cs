namespace MVP_Application.Interface
{
    public interface IView
    {
        void Show();
        void ShowText(string text);
    }

    public interface IModel
    {
        string GetText(string filename);
    }

    public interface IPresenter
    {
        void Start();
        void OpenFile(string filename);
    }
}