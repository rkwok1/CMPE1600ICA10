namespace CMPE1600ICA10
{
    partial class Size
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
            this.UI_TrackBar_Size_MaxMin = new System.Windows.Forms.TrackBar();
            this.Label_min = new System.Windows.Forms.Label();
            this.Label_max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_Size_MaxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_TrackBar_Size_MaxMin
            // 
            this.UI_TrackBar_Size_MaxMin.Location = new System.Drawing.Point(12, 25);
            this.UI_TrackBar_Size_MaxMin.Name = "UI_TrackBar_Size_MaxMin";
            this.UI_TrackBar_Size_MaxMin.Size = new System.Drawing.Size(466, 45);
            this.UI_TrackBar_Size_MaxMin.TabIndex = 0;
            // 
            // Label_min
            // 
            this.Label_min.AutoSize = true;
            this.Label_min.Location = new System.Drawing.Point(12, 57);
            this.Label_min.Name = "Label_min";
            this.Label_min.Size = new System.Drawing.Size(19, 13);
            this.Label_min.TabIndex = 1;
            this.Label_min.Text = "10";
            // 
            // Label_max
            // 
            this.Label_max.AutoSize = true;
            this.Label_max.Location = new System.Drawing.Point(454, 57);
            this.Label_max.Name = "Label_max";
            this.Label_max.Size = new System.Drawing.Size(25, 13);
            this.Label_max.TabIndex = 2;
            this.Label_max.Text = "100";
            // 
            // Size
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 119);
            this.Controls.Add(this.Label_max);
            this.Controls.Add(this.Label_min);
            this.Controls.Add(this.UI_TrackBar_Size_MaxMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Size";
            this.Text = "Size";
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar_Size_MaxMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_TrackBar_Size_MaxMin;
        private System.Windows.Forms.Label Label_min;
        private System.Windows.Forms.Label Label_max;
    }
}