    using System;
using System.IO;
using MVP_Application.Interface;

namespace MVP_Application.Models
{
    public class MainModel:IModel
    {
        //private IPresenter _presenter;

        public MainModel()//IPresenter presenter)
        {
            //_presenter = presenter;
        }

        public string GetText(string filename)
        {
            var text = "";
            try
            {
                text=File.ReadAllText(filename);
            }
            catch (Exception)
            {
                text = "An arror occured while opening file";
            }
            return text;
        }
    }
}