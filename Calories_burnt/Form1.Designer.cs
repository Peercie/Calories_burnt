namespace Calories_burnt
{
    partial class frmMain
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.gbExercise = new System.Windows.Forms.GroupBox();
            this.rbtnRunning = new System.Windows.Forms.RadioButton();
            this.rbtnCycling = new System.Windows.Forms.RadioButton();
            this.rbtnRowing = new System.Windows.Forms.RadioButton();
            this.lstbxOutput = new System.Windows.Forms.ListBox();
            this.btnCalories = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(13, 26);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(92, 13);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Enter body weight";
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(112, 26);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(100, 20);
            this.txtbxWeight.TabIndex = 1;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(218, 29);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(20, 13);
            this.lblKg.TabIndex = 2;
            this.lblKg.Text = "Kg";
            // 
            // gbExercise
            // 
            this.gbExercise.Controls.Add(this.rbtnRowing);
            this.gbExercise.Controls.Add(this.rbtnCycling);
            this.gbExercise.Controls.Add(this.rbtnRunning);
            this.gbExercise.Location = new System.Drawing.Point(244, 26);
            this.gbExercise.Name = "gbExercise";
            this.gbExercise.Size = new System.Drawing.Size(114, 134);
            this.gbExercise.TabIndex = 3;
            this.gbExercise.TabStop = false;
            this.gbExercise.Text = "Exercise";
            // 
            // rbtnRunning
            // 
            this.rbtnRunning.AutoSize = true;
            this.rbtnRunning.Location = new System.Drawing.Point(6, 57);
            this.rbtnRunning.Name = "rbtnRunning";
            this.rbtnRunning.Size = new System.Drawing.Size(65, 17);
            this.rbtnRunning.TabIndex = 0;
            this.rbtnRunning.TabStop = true;
            this.rbtnRunning.Text = "Running";
            this.rbtnRunning.UseVisualStyleBackColor = true;
            // 
            // rbtnCycling
            // 
            this.rbtnCycling.AutoSize = true;
            this.rbtnCycling.Location = new System.Drawing.Point(6, 34);
            this.rbtnCycling.Name = "rbtnCycling";
            this.rbtnCycling.Size = new System.Drawing.Size(59, 17);
            this.rbtnCycling.TabIndex = 4;
            this.rbtnCycling.TabStop = true;
            this.rbtnCycling.Text = "Cycling";
            this.rbtnCycling.UseVisualStyleBackColor = true;
            // 
            // rbtnRowing
            // 
            this.rbtnRowing.AutoSize = true;
            this.rbtnRowing.Location = new System.Drawing.Point(6, 80);
            this.rbtnRowing.Name = "rbtnRowing";
            this.rbtnRowing.Size = new System.Drawing.Size(61, 17);
            this.rbtnRowing.TabIndex = 4;
            this.rbtnRowing.TabStop = true;
            this.rbtnRowing.Text = "Rowing";
            this.rbtnRowing.UseVisualStyleBackColor = true;
            // 
            // lstbxOutput
            // 
            this.lstbxOutput.FormattingEnabled = true;
            this.lstbxOutput.Location = new System.Drawing.Point(16, 60);
            this.lstbxOutput.Name = "lstbxOutput";
            this.lstbxOutput.Size = new System.Drawing.Size(228, 186);
            this.lstbxOutput.TabIndex = 4;
            // 
            // btnCalories
            // 
            this.btnCalories.Location = new System.Drawing.Point(251, 167);
            this.btnCalories.Name = "btnCalories";
            this.btnCalories.Size = new System.Drawing.Size(107, 38);
            this.btnCalories.TabIndex = 5;
            this.btnCalories.Text = "Show calories burned";
            this.btnCalories.UseVisualStyleBackColor = true;
            this.btnCalories.Click += new System.EventHandler(this.btnCalories_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalories);
            this.Controls.Add(this.lstbxOutput);
            this.Controls.Add(this.gbExercise);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtbxWeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "frmMain";
            this.Text = "Calories burned through exercise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            this.gbExercise.ResumeLayout(false);
            this.gbExercise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.GroupBox gbExercise;
        private System.Windows.Forms.RadioButton rbtnRowing;
        private System.Windows.Forms.RadioButton rbtnCycling;
        private System.Windows.Forms.RadioButton rbtnRunning;
        private System.Windows.Forms.ListBox lstbxOutput;
        private System.Windows.Forms.Button btnCalories;
        private System.Windows.Forms.Button btnExit;
    }
}

