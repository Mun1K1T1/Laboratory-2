﻿namespace Laboratory_2
{
    partial class MainPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.SecondNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LogInBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SignUpBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SignBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.LogBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.NurseRadBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.DoctorRadBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.PatientRadBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NurseRadBtn);
            this.groupBox1.Controls.Add(this.DoctorRadBtn);
            this.groupBox1.Controls.Add(this.PatientRadBtn);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.IdTxtBox);
            this.groupBox1.Controls.Add(this.SecondNameTxtBox);
            this.groupBox1.Controls.Add(this.FirstNameTxtBox);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.LogInBtn);
            this.groupBox1.Controls.Add(this.SignUpBtn);
            this.groupBox1.Location = new System.Drawing.Point(4, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(197, 150);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(119, 24);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "Who are you:";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(158, 95);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(327, 22);
            this.IdTxtBox.TabIndex = 26;
            // 
            // SecondNameTxtBox
            // 
            this.SecondNameTxtBox.Location = new System.Drawing.Point(158, 59);
            this.SecondNameTxtBox.Name = "SecondNameTxtBox";
            this.SecondNameTxtBox.Size = new System.Drawing.Size(327, 22);
            this.SecondNameTxtBox.TabIndex = 25;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(158, 23);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(327, 22);
            this.FirstNameTxtBox.TabIndex = 24;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 95);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(31, 24);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Id:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 59);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 24);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Second name:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "First name:";
            // 
            // LogInBtn
            // 
            this.LogInBtn.AutoSize = true;
            this.LogInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogInBtn.Depth = 0;
            this.LogInBtn.Icon = null;
            this.LogInBtn.Location = new System.Drawing.Point(124, 269);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogInBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Primary = false;
            this.LogInBtn.Size = new System.Drawing.Size(76, 36);
            this.LogInBtn.TabIndex = 18;
            this.LogInBtn.Text = "Log in";
            this.LogInBtn.UseVisualStyleBackColor = true;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignUpBtn.Depth = 0;
            this.SignUpBtn.Icon = null;
            this.SignUpBtn.Location = new System.Drawing.Point(297, 269);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SignUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Primary = false;
            this.SignUpBtn.Size = new System.Drawing.Size(88, 36);
            this.SignUpBtn.TabIndex = 17;
            this.SignUpBtn.Text = "Sign up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // SignBtn
            // 
            this.SignBtn.AutoSize = true;
            this.SignBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignBtn.Depth = 0;
            this.SignBtn.Icon = null;
            this.SignBtn.Location = new System.Drawing.Point(96, 330);
            this.SignBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SignBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Primary = false;
            this.SignBtn.Size = new System.Drawing.Size(88, 36);
            this.SignBtn.TabIndex = 1;
            this.SignBtn.Text = "Sign Up";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.AutoSize = true;
            this.LogBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogBtn.Depth = 0;
            this.LogBtn.Icon = null;
            this.LogBtn.Location = new System.Drawing.Point(309, 330);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Primary = false;
            this.LogBtn.Size = new System.Drawing.Size(76, 36);
            this.LogBtn.TabIndex = 2;
            this.LogBtn.Text = "Log In";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // NurseRadBtn
            // 
            this.NurseRadBtn.AutoSize = true;
            this.NurseRadBtn.Depth = 0;
            this.NurseRadBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.NurseRadBtn.Location = new System.Drawing.Point(201, 197);
            this.NurseRadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NurseRadBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NurseRadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NurseRadBtn.Name = "NurseRadBtn";
            this.NurseRadBtn.Ripple = true;
            this.NurseRadBtn.Size = new System.Drawing.Size(76, 30);
            this.NurseRadBtn.TabIndex = 31;
            this.NurseRadBtn.TabStop = true;
            this.NurseRadBtn.Text = "Nurse";
            this.NurseRadBtn.UseVisualStyleBackColor = true;
            // 
            // DoctorRadBtn
            // 
            this.DoctorRadBtn.AutoSize = true;
            this.DoctorRadBtn.Depth = 0;
            this.DoctorRadBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.DoctorRadBtn.Location = new System.Drawing.Point(338, 197);
            this.DoctorRadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DoctorRadBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DoctorRadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoctorRadBtn.Name = "DoctorRadBtn";
            this.DoctorRadBtn.Ripple = true;
            this.DoctorRadBtn.Size = new System.Drawing.Size(82, 30);
            this.DoctorRadBtn.TabIndex = 30;
            this.DoctorRadBtn.TabStop = true;
            this.DoctorRadBtn.Text = "Doctor";
            this.DoctorRadBtn.UseVisualStyleBackColor = true;
            // 
            // PatientRadBtn
            // 
            this.PatientRadBtn.AutoSize = true;
            this.PatientRadBtn.Depth = 0;
            this.PatientRadBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.PatientRadBtn.Location = new System.Drawing.Point(61, 197);
            this.PatientRadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PatientRadBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PatientRadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PatientRadBtn.Name = "PatientRadBtn";
            this.PatientRadBtn.Ripple = true;
            this.PatientRadBtn.Size = new System.Drawing.Size(85, 30);
            this.PatientRadBtn.TabIndex = 29;
            this.PatientRadBtn.TabStop = true;
            this.PatientRadBtn.Text = "Patient";
            this.PatientRadBtn.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 387);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.SignBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainPage";
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.TextBox SecondNameTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton LogInBtn;
        private MaterialSkin.Controls.MaterialFlatButton SignUpBtn;
        private MaterialSkin.Controls.MaterialFlatButton SignBtn;
        private MaterialSkin.Controls.MaterialFlatButton LogBtn;
        private MaterialSkin.Controls.MaterialRadioButton NurseRadBtn;
        private MaterialSkin.Controls.MaterialRadioButton DoctorRadBtn;
        private MaterialSkin.Controls.MaterialRadioButton PatientRadBtn;
    }
}

