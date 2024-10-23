namespace GestaoObras
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label_Username = new Label();
            label_Password = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_Login = new Button();
            button_Clear = new Button();
            button_Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 97);
            label1.Name = "label1";
            label1.Size = new Size(281, 27);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Constructly";
            label1.Click += label1_Click;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Username.Location = new Point(73, 199);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(108, 21);
            label_Username.TabIndex = 1;
            label_Username.Text = "Username :";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Password.Location = new Point(73, 280);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(100, 21);
            label_Password.TabIndex = 2;
            label_Password.Text = "Password :";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(210, 197);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(232, 27);
            textBox_Username.TabIndex = 3;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(210, 274);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(232, 27);
            textBox_Password.TabIndex = 4;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(348, 361);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 5;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(210, 361);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 29);
            button_Clear.TabIndex = 6;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Register
            // 
            button_Register.Location = new Point(210, 408);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(232, 29);
            button_Register.TabIndex = 7;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            button_Register.Click += button_Register_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 461);
            Controls.Add(button_Register);
            Controls.Add(button_Clear);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_Username;
        private Label label_Password;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_Login;
        private Button button_Clear;
        private Button button_Register;
    }
}