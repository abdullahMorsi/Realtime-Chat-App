namespace ChatDesktop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            msgbox = new TextBox();
            usernameBox = new TextBox();
            groupbox = new TextBox();
            label4 = new Label();
            sendGroupBtn = new Button();
            sendBtn = new Button();
            joinBtn = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 167);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 1;
            label2.Text = "Group Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 124);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Message";
            // 
            // msgbox
            // 
            msgbox.Location = new Point(177, 124);
            msgbox.Name = "msgbox";
            msgbox.Size = new Size(573, 27);
            msgbox.TabIndex = 3;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(177, 78);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(573, 27);
            usernameBox.TabIndex = 4;
            // 
            // groupbox
            // 
            groupbox.Location = new Point(177, 167);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(573, 27);
            groupbox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(187, 9);
            label4.Name = "label4";
            label4.Size = new Size(401, 50);
            label4.TabIndex = 6;
            label4.Text = "Abdullah Chat Desktop";
            // 
            // sendGroupBtn
            // 
            sendGroupBtn.ForeColor = Color.FromArgb(91, 79, 253);
            sendGroupBtn.Location = new Point(587, 215);
            sendGroupBtn.Name = "sendGroupBtn";
            sendGroupBtn.Size = new Size(162, 29);
            sendGroupBtn.TabIndex = 7;
            sendGroupBtn.Text = "Send to Group";
            sendGroupBtn.UseVisualStyleBackColor = true;
            // 
            // sendBtn
            // 
            sendBtn.ForeColor = Color.FromArgb(91, 79, 253);
            sendBtn.Location = new Point(176, 215);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(153, 29);
            sendBtn.TabIndex = 8;
            sendBtn.Text = "Send All";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // joinBtn
            // 
            joinBtn.ForeColor = Color.FromArgb(91, 79, 253);
            joinBtn.Location = new Point(374, 215);
            joinBtn.Name = "joinBtn";
            joinBtn.Size = new Size(160, 29);
            joinBtn.TabIndex = 9;
            joinBtn.Text = "Join Group";
            joinBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.FromArgb(103, 2, 240);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(40, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(709, 144);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(137, 127, 253);
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(joinBtn);
            Controls.Add(sendBtn);
            Controls.Add(sendGroupBtn);
            Controls.Add(label4);
            Controls.Add(groupbox);
            Controls.Add(usernameBox);
            Controls.Add(msgbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox msgbox;
        private TextBox usernameBox;
        private TextBox groupbox;
        private Label label4;
        private Button sendGroupBtn;
        private Button sendBtn;
        private Button joinBtn;
        private ListBox listBox1;
    }
}
