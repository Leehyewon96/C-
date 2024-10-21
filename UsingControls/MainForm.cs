namespace UsingControls
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach(FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }

        void ChageFont()
        {
            if(cboFont.SelectedIndex < 0)
            {
                return;
            }

            FontStyle style = FontStyle.Regular;

            if(chkBold.Checked)
            {
                style |= FontStyle.Bold;
            }

            if(chkItalic.Checked)
            {
                style |= FontStyle.Italic;
            }

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChageFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChageFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChageFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modal Form";
            form.Width = 300;
            form.Height = 100;
            form.BackColor = Color.Red;
            form.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modaless Form";
            form.Width = 300;
            form.Height = 300;
            form.BackColor = Color.Green;
            form.Show();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach(TreeNode node in tvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        void TreeToList(TreeNode node)
        {
            lvDummy.Items.Add(
                new ListViewItem(
                    new string[] { node.Text,
                    node.FullPath.Count(f => f == '\\').ToString()}));

            foreach(TreeNode n in node.Nodes)
            {
                TreeToList(n);
            }
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
