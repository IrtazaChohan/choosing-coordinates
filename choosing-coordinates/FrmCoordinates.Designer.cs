
namespace choosing_coordinates
{
    partial class FrmCoordinates
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
            this.txtTextBox1 = new System.Windows.Forms.TextBox();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextBox1
            // 
            this.txtTextBox1.Location = new System.Drawing.Point(93, 93);
            this.txtTextBox1.Name = "txtTextBox1";
            this.txtTextBox1.Size = new System.Drawing.Size(81, 23);
            this.txtTextBox1.TabIndex = 0;
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(246, 93);
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.Size = new System.Drawing.Size(81, 23);
            this.txtTextBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quadrant Coordinate Calculator";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(163, 169);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 26);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "X Coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y Coordinates";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(93, 221);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Visible = false;
            // 
            // FrmCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 324);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.txtTextBox1);
            this.Name = "FrmCoordinates";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBox1;
        private System.Windows.Forms.TextBox txtTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}

