using IsEmri.Business;
using System;
using System.Windows.Forms;

namespace IsEmri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IsEmriReporter _isEmriReporter = new IsEmriReporter();

        private void Form1_Load(object sender, EventArgs e)
        {
            gridDuruslar.DataSource = _isEmriReporter.Duruslar;
            gridEmirler.DataSource = _isEmriReporter.Emirler;
            this.Text = _isEmriReporter.Text;
            gridRapor.DataSource = _isEmriReporter.ListPivotModel;
        }
    }
}
