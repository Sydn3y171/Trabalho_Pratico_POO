namespace GestaoObras
{
    partial class Register
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
            textBox_Username = new TextBox();
            label_Username = new Label();
            label_Password = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button_Register = new Button();
            button_Clear = new Button();
            SuspendLayout();
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(271, 159);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(232, 27);
            textBox_Username.TabIndex = 4;
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Username.Location = new Point(117, 165);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(108, 21);
            label_Username.TabIndex = 5;
            label_Username.Text = "Username :";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Password.Location = new Point(117, 266);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(100, 21);
            label_Password.TabIndex = 6;
            label_Password.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 75);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 8;
            label1.Text = "Creat account";
            // 
            // button_Register
            // 
            button_Register.Location = new Point(409, 351);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(94, 29);
            button_Register.TabIndex = 9;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(271, 351);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 29);
            button_Clear.TabIndex = 10;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 452);
            Controls.Add(button_Clear);
            Controls.Add(button_Register);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(textBox_Username);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox textBox_Username;
        private Label label_Username;
        private Label label_Password;
        private TextBox textBox1;
        private Label label1;
        private Button button_Register;
        private Button button_Clear;
    }
}