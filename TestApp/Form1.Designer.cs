
namespace TestApp
{
    partial class Form1
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
            this.cbVoiceList = new System.Windows.Forms.ComboBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbVoiceList
            // 
            this.cbVoiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiceList.FormattingEnabled = true;
            this.cbVoiceList.Location = new System.Drawing.Point(97, 22);
            this.cbVoiceList.Name = "cbVoiceList";
            this.cbVoiceList.Size = new System.Drawing.Size(200, 25);
            this.cbVoiceList.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // gbTest
            // 
            this.gbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTest.Controls.Add(this.btnSpeak);
            this.gbTest.Controls.Add(this.txtContent);
            this.gbTest.Controls.Add(this.label2);
            this.gbTest.Controls.Add(this.label1);
            this.gbTest.Controls.Add(this.cbVoiceList);
            this.gbTest.Enabled = false;
            this.gbTest.Location = new System.Drawing.Point(12, 41);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(360, 269);
            this.gbTest.TabIndex = 2;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeak.Location = new System.Drawing.Point(97, 240);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 3;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(97, 53);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(257, 181);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "Hello world.你好世界！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voice:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.gbTest);
            this.Controls.Add(this.btnInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVoiceList;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
    }
}

