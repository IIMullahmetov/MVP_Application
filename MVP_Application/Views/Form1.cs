using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Application.Interface;

namespace MVP_Application
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter;

        public Form1(IPresenter presenter)
        {
            InitializeComponent();

            _presenter = presenter;
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            var result = fd.ShowDialog();
            if(result!=DialogResult.Cancel)
            {
                fileName.Text = fd.FileName;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            _presenter.OpenFile(fileName.Text);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public void ShowText(string text)
        {
            mainTextBox.Text = text;
        }
    }
}
