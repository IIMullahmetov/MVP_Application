using MVP_Application.Interface;
using MVP_Application.Models;

namespace MVP_Application.Presenters
{
    public class MainPresenter: IPresenter
    {
        private IView _view;
        private IModel _model;

        public MainPresenter()
        {
            _view = new Form1(this);
            _model = new MainModel();//this);
        }

        public void Start()
        {
            _view.Show();
        }

        public void OpenFile(string filename)
        {
            var text = _model.GetText(filename);
            _view.ShowText(text);
        }
    }
}