namespace CMPE1600ICA10
{
    partial class MainForm
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
            this.UI_CheckBox_ShowColorDialog = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_ShowSizeDialog = new System.Windows.Forms.CheckBox();
            this.UI_Label_DrawingColor = new System.Windows.Forms.Label();
            this.UI_Label_CircleSize = new System.Windows.Forms.Label();
            this.UI_Label_ColorBox = new System.Windows.Forms.Label();
            this.UI_Label_CircleSize0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_CheckBox_ShowColorDialog
            // 
            this.UI_CheckBox_ShowColorDialog.AutoSize = true;
            this.UI_CheckBox_ShowColorDialog.Location = new System.Drawing.Point(22, 27);
            this.UI_CheckBox_ShowColorDialog.Name = "UI_CheckBox_ShowColorDialog";
            this.UI_CheckBox_ShowColorDialog.Size = new System.Drawing.Size(113, 17);
            this.UI_CheckBox_ShowColorDialog.TabIndex = 2;
            this.UI_CheckBox_ShowColorDialog.Text = "Show Color Dialog";
            this.UI_CheckBox_ShowColorDialog.UseVisualStyleBackColor = true;
            this.UI_CheckBox_ShowColorDialog.CheckedChanged += new System.EventHandler(this.UI_CheckBox_ShowColorDialog_CheckedChanged);
            // 
            // UI_CheckBox_ShowSizeDialog
            // 
            this.UI_CheckBox_ShowSizeDialog.AutoSize = true;
            this.UI_CheckBox_ShowSizeDialog.Location = new System.Drawing.Point(22, 51);
            this.UI_CheckBox_ShowSizeDialog.Name = "UI_CheckBox_ShowSizeDialog";
            this.UI_CheckBox_ShowSizeDialog.Size = new System.Drawing.Size(109, 17);
            this.UI_CheckBox_ShowSizeDialog.TabIndex = 3;
            this.UI_CheckBox_ShowSizeDialog.Text = "Show Size Dialog";
            this.UI_CheckBox_ShowSizeDialog.UseVisualStyleBackColor = true;
            this.UI_CheckBox_ShowSizeDialog.CheckedChanged += new System.EventHandler(this.UI_CheckBox_ShowSizeDialog_CheckedChanged);
            // 
            // UI_Label_DrawingColor
            // 
            this.UI_Label_DrawingColor.AutoSize = true;
            this.UI_Label_DrawingColor.Location = new System.Drawing.Point(239, 27);
            this.UI_Label_DrawingColor.Name = "UI_Label_DrawingColor";
            this.UI_Label_DrawingColor.Size = new System.Drawing.Size(76, 13);
            this.UI_Label_DrawingColor.TabIndex = 4;
            this.UI_Label_DrawingColor.Text = "Drawing Color:";
            // 
            // UI_Label_CircleSize
            // 
            this.UI_Label_CircleSize.AutoSize = true;
            this.UI_Label_CircleSize.Location = new System.Drawing.Point(239, 52);
            this.UI_Label_CircleSize.Name = "UI_Label_CircleSize";
            this.UI_Label_CircleSize.Size = new System.Drawing.Size(59, 13);
            this.UI_Label_CircleSize.TabIndex = 5;
            this.UI_Label_CircleSize.Text = "Circle Size:";
            // 
            // UI_Label_ColorBox
            // 
            this.UI_Label_ColorBox.BackColor = System.Drawing.Color.White;
            this.UI_Label_ColorBox.Location = new System.Drawing.Point(321, 27);
            this.UI_Label_ColorBox.Name = "UI_Label_ColorBox";
            this.UI_Label_ColorBox.Size = new System.Drawing.Size(61, 17);
            this.UI_Label_ColorBox.TabIndex = 6;
            // 
            // UI_Label_CircleSize0
            // 
            this.UI_Label_CircleSize0.AutoSize = true;
            this.UI_Label_CircleSize0.Location = new System.Drawing.Point(324, 51);
            this.UI_Label_CircleSize0.Name = "UI_Label_CircleSize0";
            this.UI_Label_CircleSize0.Size = new System.Drawing.Size(19, 13);
            this.UI_Label_CircleSize0.TabIndex = 7;
            this.UI_Label_CircleSize0.Text = "10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 109);
            this.Controls.Add(this.UI_Label_CircleSize0);
            this.Controls.Add(this.UI_Label_ColorBox);
            this.Controls.Add(this.UI_Label_CircleSize);
            this.Controls.Add(this.UI_Label_DrawingColor);
            this.Controls.Add(this.UI_CheckBox_ShowSizeDialog);
            this.Controls.Add(this.UI_CheckBox_ShowColorDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(440, 148);
            this.MinimumSize = new System.Drawing.Size(440, 148);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_CheckBox_ShowColorDialog;
        private System.Windows.Forms.CheckBox UI_CheckBox_ShowSizeDialog;
        private System.Windows.Forms.Label UI_Label_DrawingColor;
        private System.Windows.Forms.Label UI_Label_CircleSize;
        private System.Windows.Forms.Label UI_Label_ColorBox;
        private System.Windows.Forms.Label UI_Label_CircleSize0;
    }
}

