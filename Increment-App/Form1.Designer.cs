namespace Increment_App
{
    partial class IncrementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementForm));
            this.NumDisplay = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.Label_Goal = new System.Windows.Forms.Label();
            this.GoalBox = new System.Windows.Forms.TextBox();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumDisplay
            // 
            this.NumDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NumDisplay.AutoSize = true;
            this.NumDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDisplay.Location = new System.Drawing.Point(86, 0);
            this.NumDisplay.Name = "NumDisplay";
            this.NumDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumDisplay.Size = new System.Drawing.Size(98, 108);
            this.NumDisplay.TabIndex = 0;
            this.NumDisplay.Text = "0";
            this.NumDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NumDisplay.TextChanged += new System.EventHandler(this.NumDisplay_TextChanged);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(0, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(46, 39);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Subtract
            // 
            this.button_Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Subtract.Location = new System.Drawing.Point(0, 58);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(46, 39);
            this.button_Subtract.TabIndex = 2;
            this.button_Subtract.Text = "-";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.button_Subtract_Click);
            // 
            // Label_Goal
            // 
            this.Label_Goal.AutoSize = true;
            this.Label_Goal.Location = new System.Drawing.Point(69, 115);
            this.Label_Goal.Name = "Label_Goal";
            this.Label_Goal.Size = new System.Drawing.Size(29, 13);
            this.Label_Goal.TabIndex = 3;
            this.Label_Goal.Text = "Goal";
            // 
            // GoalBox
            // 
            this.GoalBox.Location = new System.Drawing.Point(105, 115);
            this.GoalBox.Name = "GoalBox";
            this.GoalBox.Size = new System.Drawing.Size(54, 20);
            this.GoalBox.TabIndex = 4;
            this.GoalBox.TextChanged += new System.EventHandler(this.GoalBox_TextChanged);
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(0, 131);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(46, 23);
            this.Button_Reset.TabIndex = 5;
            this.Button_Reset.Text = "Reset";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // IncrementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(224, 159);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.GoalBox);
            this.Controls.Add(this.Label_Goal);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.NumDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncrementForm";
            this.Text = "Increment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumDisplay;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Label Label_Goal;
        private System.Windows.Forms.TextBox GoalBox;
        private System.Windows.Forms.Button Button_Reset;
    }
}

