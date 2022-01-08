
namespace AsyncTest
{
    partial class FormAsyncTest
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
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonNomal = new System.Windows.Forms.Button();
            this.buttonTaskRun = new System.Windows.Forms.Button();
            this.buttonAwait = new System.Windows.Forms.Button();
            this.buttonWait = new System.Windows.Forms.Button();
            this.buttonAsync = new System.Windows.Forms.Button();
            this.buttonAsyncTaskWait = new System.Windows.Forms.Button();
            this.buttonAsyncAwait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 21;
            this.listBoxOutput.Location = new System.Drawing.Point(41, 28);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(428, 508);
            this.listBoxOutput.TabIndex = 0;
            // 
            // buttonNomal
            // 
            this.buttonNomal.Location = new System.Drawing.Point(503, 28);
            this.buttonNomal.Name = "buttonNomal";
            this.buttonNomal.Size = new System.Drawing.Size(122, 82);
            this.buttonNomal.TabIndex = 1;
            this.buttonNomal.Text = "通常\r\n（同期処理）";
            this.buttonNomal.UseVisualStyleBackColor = true;
            this.buttonNomal.Click += new System.EventHandler(this.buttonNomal_Click);
            // 
            // buttonTaskRun
            // 
            this.buttonTaskRun.Location = new System.Drawing.Point(503, 134);
            this.buttonTaskRun.Name = "buttonTaskRun";
            this.buttonTaskRun.Size = new System.Drawing.Size(122, 82);
            this.buttonTaskRun.TabIndex = 2;
            this.buttonTaskRun.Text = "非同期\r\n（Task.Run()）\r\n";
            this.buttonTaskRun.UseVisualStyleBackColor = true;
            this.buttonTaskRun.Click += new System.EventHandler(this.buttonTaskRun_Click);
            // 
            // buttonAwait
            // 
            this.buttonAwait.Location = new System.Drawing.Point(503, 246);
            this.buttonAwait.Name = "buttonAwait";
            this.buttonAwait.Size = new System.Drawing.Size(122, 82);
            this.buttonAwait.TabIndex = 3;
            this.buttonAwait.Text = "非同期\r\n（await）\r\n";
            this.buttonAwait.UseVisualStyleBackColor = true;
            this.buttonAwait.Click += new System.EventHandler(this.buttonAwait_Click);
            // 
            // buttonWait
            // 
            this.buttonWait.Location = new System.Drawing.Point(648, 246);
            this.buttonWait.Name = "buttonWait";
            this.buttonWait.Size = new System.Drawing.Size(140, 82);
            this.buttonWait.TabIndex = 4;
            this.buttonWait.Text = "非同期\r\n（Task.Wait()）\r\n";
            this.buttonWait.UseVisualStyleBackColor = true;
            this.buttonWait.Click += new System.EventHandler(this.buttonWait_Click);
            // 
            // buttonAsync
            // 
            this.buttonAsync.Location = new System.Drawing.Point(503, 356);
            this.buttonAsync.Name = "buttonAsync";
            this.buttonAsync.Size = new System.Drawing.Size(122, 82);
            this.buttonAsync.TabIndex = 5;
            this.buttonAsync.Text = "非同期\r\n（async）\r\n";
            this.buttonAsync.UseVisualStyleBackColor = true;
            this.buttonAsync.Click += new System.EventHandler(this.buttonAsync_Click);
            // 
            // buttonAsyncTaskWait
            // 
            this.buttonAsyncTaskWait.Location = new System.Drawing.Point(648, 465);
            this.buttonAsyncTaskWait.Name = "buttonAsyncTaskWait";
            this.buttonAsyncTaskWait.Size = new System.Drawing.Size(140, 82);
            this.buttonAsyncTaskWait.TabIndex = 7;
            this.buttonAsyncTaskWait.Text = "非同期\r\n（async/\r\n  Task.Waite()）\r\n";
            this.buttonAsyncTaskWait.UseVisualStyleBackColor = true;
            this.buttonAsyncTaskWait.Click += new System.EventHandler(this.buttonAsyncTaskWait_Click);
            // 
            // buttonAsyncAwait
            // 
            this.buttonAsyncAwait.Location = new System.Drawing.Point(503, 465);
            this.buttonAsyncAwait.Name = "buttonAsyncAwait";
            this.buttonAsyncAwait.Size = new System.Drawing.Size(122, 82);
            this.buttonAsyncAwait.TabIndex = 6;
            this.buttonAsyncAwait.Text = "非同期\r\n（await）\r\n";
            this.buttonAsyncAwait.UseVisualStyleBackColor = true;
            this.buttonAsyncAwait.Click += new System.EventHandler(this.buttonAsyncAwait_Click);
            // 
            // FormAsyncTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.buttonAsyncTaskWait);
            this.Controls.Add(this.buttonAsyncAwait);
            this.Controls.Add(this.buttonAsync);
            this.Controls.Add(this.buttonWait);
            this.Controls.Add(this.buttonAwait);
            this.Controls.Add(this.buttonTaskRun);
            this.Controls.Add(this.buttonNomal);
            this.Controls.Add(this.listBoxOutput);
            this.Name = "FormAsyncTest";
            this.Text = "非同期処理テスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonNomal;
        private System.Windows.Forms.Button buttonTaskRun;
        private System.Windows.Forms.Button buttonAwait;
        private System.Windows.Forms.Button buttonWait;
        private System.Windows.Forms.Button buttonAsync;
        private System.Windows.Forms.Button buttonAsyncTaskWait;
        private System.Windows.Forms.Button buttonAsyncAwait;
    }
}

