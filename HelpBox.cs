using System.Windows.Forms;
using CQE.Classes;

namespace CQE
{
    public partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();

            foreach (Control cc in panel1.Controls)
            {
                if (cc.AccessibleDescription != null)
                {
                    string[] locatestring = cc.AccessibleDescription.Split("|".ToCharArray());
                    cc.Text = Language.Dictionary[locatestring[0]][locatestring[1]];
                }
            }
        }
    }
}
