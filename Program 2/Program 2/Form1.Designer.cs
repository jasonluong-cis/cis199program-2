namespace Program_2
{
    partial class Form1
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
            this.Instruction = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FreshmenRadio = new System.Windows.Forms.RadioButton();
            this.SophmoreRadio = new System.Windows.Forms.RadioButton();
            this.JuniorRadio = new System.Windows.Forms.RadioButton();
            this.SeniorRadio = new System.Windows.Forms.RadioButton();
            this.GraduateRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateOutput = new System.Windows.Forms.Label();
            this.TimeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Location = new System.Drawing.Point(12, 20);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(167, 13);
            this.Instruction.TabIndex = 0;
            this.Instruction.Text = "Enter 1st letter of your Last Name:";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(185, 17);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(93, 20);
            this.LastNameText.TabIndex = 1;
            // 
            // FreshmenRadio
            // 
            this.FreshmenRadio.AutoSize = true;
            this.FreshmenRadio.Location = new System.Drawing.Point(185, 46);
            this.FreshmenRadio.Name = "FreshmenRadio";
            this.FreshmenRadio.Size = new System.Drawing.Size(71, 17);
            this.FreshmenRadio.TabIndex = 2;
            this.FreshmenRadio.TabStop = true;
            this.FreshmenRadio.Text = "Freshmen";
            this.FreshmenRadio.UseVisualStyleBackColor = true;
            // 
            // SophmoreRadio
            // 
            this.SophmoreRadio.AutoSize = true;
            this.SophmoreRadio.Location = new System.Drawing.Point(185, 69);
            this.SophmoreRadio.Name = "SophmoreRadio";
            this.SophmoreRadio.Size = new System.Drawing.Size(73, 17);
            this.SophmoreRadio.TabIndex = 3;
            this.SophmoreRadio.TabStop = true;
            this.SophmoreRadio.Text = "Sophmore";
            this.SophmoreRadio.UseVisualStyleBackColor = true;
            // 
            // JuniorRadio
            // 
            this.JuniorRadio.AutoSize = true;
            this.JuniorRadio.Location = new System.Drawing.Point(185, 92);
            this.JuniorRadio.Name = "JuniorRadio";
            this.JuniorRadio.Size = new System.Drawing.Size(53, 17);
            this.JuniorRadio.TabIndex = 4;
            this.JuniorRadio.TabStop = true;
            this.JuniorRadio.Text = "Junior";
            this.JuniorRadio.UseVisualStyleBackColor = true;
            // 
            // SeniorRadio
            // 
            this.SeniorRadio.AutoSize = true;
            this.SeniorRadio.Location = new System.Drawing.Point(185, 115);
            this.SeniorRadio.Name = "SeniorRadio";
            this.SeniorRadio.Size = new System.Drawing.Size(55, 17);
            this.SeniorRadio.TabIndex = 5;
            this.SeniorRadio.TabStop = true;
            this.SeniorRadio.Text = "Senior";
            this.SeniorRadio.UseVisualStyleBackColor = true;
            // 
            // GraduateRadio
            // 
            this.GraduateRadio.AutoSize = true;
            this.GraduateRadio.Location = new System.Drawing.Point(185, 138);
            this.GraduateRadio.Name = "GraduateRadio";
            this.GraduateRadio.Size = new System.Drawing.Size(69, 17);
            this.GraduateRadio.TabIndex = 6;
            this.GraduateRadio.TabStop = true;
            this.GraduateRadio.Text = "Graduate";
            this.GraduateRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose your class standing:";
            // 
            // Submitbutton
            // 
            this.Submitbutton.Location = new System.Drawing.Point(86, 226);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(132, 23);
            this.Submitbutton.TabIndex = 8;
            this.Submitbutton.Text = "Submit";
            this.Submitbutton.UseVisualStyleBackColor = true;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(146, 164);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(33, 13);
            this.DayLabel.TabIndex = 9;
            this.DayLabel.Text = "Date:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(146, 184);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time:";
            // 
            // DateOutput
            // 
            this.DateOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateOutput.Location = new System.Drawing.Point(185, 157);
            this.DateOutput.Name = "DateOutput";
            this.DateOutput.Size = new System.Drawing.Size(93, 20);
            this.DateOutput.TabIndex = 11;
            // 
            // TimeOutput
            // 
            this.TimeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeOutput.Location = new System.Drawing.Point(185, 177);
            this.TimeOutput.Name = "TimeOutput";
            this.TimeOutput.Size = new System.Drawing.Size(93, 20);
            this.TimeOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TimeOutput);
            this.Controls.Add(this.DateOutput);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraduateRadio);
            this.Controls.Add(this.SeniorRadio);
            this.Controls.Add(this.JuniorRadio);
            this.Controls.Add(this.SophmoreRadio);
            this.Controls.Add(this.FreshmenRadio);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.Instruction);
            this.Name = "Form1";
            this.Text = "Spring Registration 2018";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.RadioButton FreshmenRadio;
        private System.Windows.Forms.RadioButton SophmoreRadio;
        private System.Windows.Forms.RadioButton JuniorRadio;
        private System.Windows.Forms.RadioButton SeniorRadio;
        private System.Windows.Forms.RadioButton GraduateRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateOutput;
        private System.Windows.Forms.Label TimeOutput;
    }
}

