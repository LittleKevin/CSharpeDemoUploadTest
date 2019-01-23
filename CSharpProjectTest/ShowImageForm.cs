using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProjectTest
{
    public partial class ShowImageForm : Form
    {
        #region variable
        public string htmlName = "ShowImage.html";
        static string webReportUrl = System.AppDomain.CurrentDomain.BaseDirectory + webReportUrl + "webReport\\";
        #endregion

        #region myFunction
        private void showPictrue() 
        {
            webBrowser1.Visible = true;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Url = new System.Uri(webReportUrl + htmlName);
        }
        #endregion
        public ShowImageForm()
        {
            InitializeComponent();
        }

        private void ShowImageForm_Load(object sender, EventArgs e)
        {
            showPictrue();
        }
    }
}
