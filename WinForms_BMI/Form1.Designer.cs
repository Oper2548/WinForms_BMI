namespace WinForms_BMI
{
    partial class Height
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
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnBMI = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(202, 132);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(202, 198);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(202, 267);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 4;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(569, 132);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(143, 103);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "คำนวณกัน";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 72);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 139);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "อายุของคุณ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 205);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "ความสูงหล่ะ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 274);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "หนังเท่าไหร่";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 23);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "คำนวณค่า BMI";
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ActiveCaption;
            lblResult.Location = new Point(62, 317);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(687, 108);
            lblResult.TabIndex = 10;
            lblResult.Text = "นี้คือ BMI ของคุณ";
            lblResult.Click += lblResult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(569, 255);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 39);
            btnClear.TabIndex = 11;
            btnClear.Text = "รีๆๆ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Height
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "Height";
            Text = "Form1";
            Load += Height_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnBMI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblResult;
        private Button btnClear;
    }
}
