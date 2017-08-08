using System.Windows.Forms;

namespace TennisCoutBooker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void bookingWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var inputElements = this.bookingWebBrowser.Document.DomDocument;
        }
    }
}
