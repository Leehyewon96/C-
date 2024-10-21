namespace AsyncFileIOWinForm
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
            lblSource = new Label();
            lblTarget = new Label();
            txtSource = new TextBox();
            txtTarget = new TextBox();
            btnFindSource = new Button();
            btnFindTarget = new Button();
            btnAsyncCopy = new Button();
            btnSyncCopy = new Button();
            btnCancel = new Button();
            pbCopy = new ProgressBar();
            SuspendLayout();
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(65, 70);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(55, 20);
            lblSource.TabIndex = 0;
            lblSource.Text = "Source";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(70, 129);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(52, 20);
            lblTarget.TabIndex = 1;
            lblTarget.Text = "Target";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(162, 70);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(461, 27);
            txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(162, 129);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(461, 27);
            txtTarget.TabIndex = 3;
            // 
            // btnFindSource
            // 
            btnFindSource.Location = new Point(652, 68);
            btnFindSource.Name = "btnFindSource";
            btnFindSource.Size = new Size(94, 29);
            btnFindSource.TabIndex = 4;
            btnFindSource.Text = "...";
            btnFindSource.UseVisualStyleBackColor = true;
            btnFindSource.Click += btnFindSource_Click;
            // 
            // btnFindTarget
            // 
            btnFindTarget.Location = new Point(652, 129);
            btnFindTarget.Name = "btnFindTarget";
            btnFindTarget.Size = new Size(94, 29);
            btnFindTarget.TabIndex = 5;
            btnFindTarget.Text = "...";
            btnFindTarget.UseVisualStyleBackColor = true;
            btnFindTarget.Click += btnFindTarget_Click;
            // 
            // btnAsyncCopy
            // 
            btnAsyncCopy.Location = new Point(65, 235);
            btnAsyncCopy.Name = "btnAsyncCopy";
            btnAsyncCopy.Size = new Size(137, 29);
            btnAsyncCopy.TabIndex = 6;
            btnAsyncCopy.Text = "Async Copy";
            btnAsyncCopy.UseVisualStyleBackColor = true;
            btnAsyncCopy.Click += btnAsyncCopy_Click;
            // 
            // btnSyncCopy
            // 
            btnSyncCopy.Location = new Point(332, 235);
            btnSyncCopy.Name = "btnSyncCopy";
            btnSyncCopy.Size = new Size(143, 29);
            btnSyncCopy.TabIndex = 7;
            btnSyncCopy.Text = "Sync Copy";
            btnSyncCopy.UseVisualStyleBackColor = true;
            btnSyncCopy.Click += btnSyncCopy_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(599, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbCopy
            // 
            pbCopy.Location = new Point(65, 339);
            pbCopy.Name = "pbCopy";
            pbCopy.Size = new Size(681, 29);
            pbCopy.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbCopy);
            Controls.Add(btnCancel);
            Controls.Add(btnSyncCopy);
            Controls.Add(btnAsyncCopy);
            Controls.Add(btnFindTarget);
            Controls.Add(btnFindSource);
            Controls.Add(txtTarget);
            Controls.Add(txtSource);
            Controls.Add(lblTarget);
            Controls.Add(lblSource);
            Name = "MainForm";
            Text = "Async File Copy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSource;
        private Label lblTarget;
        private TextBox txtSource;
        private TextBox txtTarget;
        private Button btnFindSource;
        private Button btnFindTarget;
        private Button btnAsyncCopy;
        private Button btnSyncCopy;
        private Button btnCancel;
        private ProgressBar pbCopy;
    }
}
