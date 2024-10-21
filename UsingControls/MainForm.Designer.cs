namespace UsingControls
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpFont = new GroupBox();
            groupBox1 = new GroupBox();
            txtSampleText = new TextBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            cboFont = new ComboBox();
            lblFont = new Label();
            grpBar = new GroupBox();
            pgDummy = new ProgressBar();
            tbDummy = new TrackBar();
            grpForm = new GroupBox();
            btnMsgBox = new Button();
            btnModaless = new Button();
            btnModal = new Button();
            grpTreeList = new GroupBox();
            lvDummy = new ListView();
            btnAddChild = new Button();
            btnAddRoot = new Button();
            tvDummy = new TreeView();
            grpFont.SuspendLayout();
            grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).BeginInit();
            grpForm.SuspendLayout();
            grpTreeList.SuspendLayout();
            SuspendLayout();
            // 
            // grpFont
            // 
            grpFont.Controls.Add(groupBox1);
            grpFont.Controls.Add(txtSampleText);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Controls.Add(cboFont);
            grpFont.Controls.Add(lblFont);
            grpFont.Location = new Point(72, 49);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(583, 192);
            grpFont.TabIndex = 0;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox,CheckBox,TextBox";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 68);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(57, 125);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(462, 27);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello, C#";
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Location = new Point(355, 67);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(76, 24);
            chkItalic.TabIndex = 3;
            chkItalic.Text = "이탤릭";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Location = new Point(288, 67);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(61, 24);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(109, 65);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(151, 28);
            cboFont.TabIndex = 1;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(52, 65);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(39, 20);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font";
            // 
            // grpBar
            // 
            grpBar.Controls.Add(pgDummy);
            grpBar.Controls.Add(tbDummy);
            grpBar.Location = new Point(72, 247);
            grpBar.Name = "grpBar";
            grpBar.Size = new Size(583, 151);
            grpBar.TabIndex = 1;
            grpBar.TabStop = false;
            grpBar.Text = "TrackBar && ProgressBar";
            // 
            // pgDummy
            // 
            pgDummy.Location = new Point(31, 85);
            pgDummy.Maximum = 20;
            pgDummy.Name = "pgDummy";
            pgDummy.Size = new Size(500, 29);
            pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            tbDummy.Location = new Point(31, 37);
            tbDummy.Maximum = 20;
            tbDummy.Name = "tbDummy";
            tbDummy.Size = new Size(514, 56);
            tbDummy.TabIndex = 0;
            tbDummy.Value = 20;
            tbDummy.Scroll += tbDummy_Scroll;
            // 
            // grpForm
            // 
            grpForm.Controls.Add(btnMsgBox);
            grpForm.Controls.Add(btnModaless);
            grpForm.Controls.Add(btnModal);
            grpForm.Location = new Point(76, 437);
            grpForm.Name = "grpForm";
            grpForm.Size = new Size(580, 120);
            grpForm.TabIndex = 2;
            grpForm.TabStop = false;
            grpForm.Text = "Modal&&Madaless";
            // 
            // btnMsgBox
            // 
            btnMsgBox.Location = new Point(381, 57);
            btnMsgBox.Name = "btnMsgBox";
            btnMsgBox.Size = new Size(160, 29);
            btnMsgBox.TabIndex = 2;
            btnMsgBox.Text = "Messagebox";
            btnMsgBox.UseVisualStyleBackColor = true;
            btnMsgBox.Click += btnMsgBox_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(215, 57);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(94, 29);
            btnModaless.TabIndex = 1;
            btnModaless.Text = "Modaless";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(50, 57);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(94, 29);
            btnModal.TabIndex = 0;
            btnModal.Text = "Modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // grpTreeList
            // 
            grpTreeList.Controls.Add(lvDummy);
            grpTreeList.Controls.Add(btnAddChild);
            grpTreeList.Controls.Add(btnAddRoot);
            grpTreeList.Controls.Add(tvDummy);
            grpTreeList.Location = new Point(72, 577);
            grpTreeList.Name = "grpTreeList";
            grpTreeList.Size = new Size(583, 318);
            grpTreeList.TabIndex = 3;
            grpTreeList.TabStop = false;
            grpTreeList.Text = "TreeView&&ListView";
            // 
            // lvDummy
            // 
            lvDummy.Location = new Point(368, 36);
            lvDummy.Name = "lvDummy";
            lvDummy.Size = new Size(185, 221);
            lvDummy.TabIndex = 3;
            lvDummy.UseCompatibleStateImageBehavior = false;
            lvDummy.View = View.Details;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(131, 283);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(94, 29);
            btnAddChild.TabIndex = 2;
            btnAddChild.Text = "자식 추가";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += this.btnAddChild_Click;
            // 
            // btnAddRoot
            // 
            btnAddRoot.Location = new Point(31, 283);
            btnAddRoot.Name = "btnAddRoot";
            btnAddRoot.Size = new Size(94, 29);
            btnAddRoot.TabIndex = 1;
            btnAddRoot.Text = "루트 추가";
            btnAddRoot.UseVisualStyleBackColor = true;
            btnAddRoot.Click += btnAddRoot_Click;
            // 
            // tvDummy
            // 
            tvDummy.Location = new Point(31, 36);
            tvDummy.Name = "tvDummy";
            tvDummy.Size = new Size(186, 221);
            tvDummy.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 935);
            Controls.Add(grpTreeList);
            Controls.Add(grpForm);
            Controls.Add(grpBar);
            Controls.Add(grpFont);
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            grpBar.ResumeLayout(false);
            grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).EndInit();
            grpForm.ResumeLayout(false);
            grpTreeList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFont;
        private TextBox txtSampleText;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private ComboBox cboFont;
        private Label lblFont;
        private GroupBox groupBox1;
        private GroupBox grpBar;
        private TrackBar tbDummy;
        private ProgressBar pgDummy;
        private GroupBox grpForm;
        private Button btnModal;
        private Button btnMsgBox;
        private Button btnModaless;
        private GroupBox grpTreeList;
        private TreeView tvDummy;
        private ListView lvDummy;
        private Button btnAddChild;
        private Button btnAddRoot;
    }
}
