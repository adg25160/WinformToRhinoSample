using System.Windows.Forms;

namespace SampleCsWinForms.Forms
{
  public partial class SampleCsModelessForm : Form
  {
    public SampleCsModelessForm()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello, world.");
        }
    }
}
