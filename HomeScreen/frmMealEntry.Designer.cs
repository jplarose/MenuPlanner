namespace HomeScreen
{
    partial class frmMealEntry
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSaveMeal = new System.Windows.Forms.CheckBox();
            this.pbMealPic = new System.Windows.Forms.PictureBox();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMealPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(13, 48);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(125, 20);
            this.txtMealName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // chkSaveMeal
            // 
            this.chkSaveMeal.AutoSize = true;
            this.chkSaveMeal.Checked = true;
            this.chkSaveMeal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveMeal.Location = new System.Drawing.Point(253, 579);
            this.chkSaveMeal.Name = "chkSaveMeal";
            this.chkSaveMeal.Size = new System.Drawing.Size(111, 17);
            this.chkSaveMeal.TabIndex = 4;
            this.chkSaveMeal.Text = "Add to My Meals?";
            this.chkSaveMeal.UseVisualStyleBackColor = true;
            // 
            // pbMealPic
            // 
            this.pbMealPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbMealPic.Location = new System.Drawing.Point(396, 29);
            this.pbMealPic.Name = "pbMealPic";
            this.pbMealPic.Size = new System.Drawing.Size(130, 120);
            this.pbMealPic.TabIndex = 5;
            this.pbMealPic.TabStop = false;
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.Location = new System.Drawing.Point(45, 385);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(156, 95);
            this.lbIngredients.TabIndex = 6;
            // 
            // frmMealEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 610);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.pbMealPic);
            this.Controls.Add(this.chkSaveMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmMealEntry";
            this.Text = "{Meal Text}";
            ((System.ComponentModel.ISupportInitialize)(this.pbMealPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSaveMeal;
        private System.Windows.Forms.PictureBox pbMealPic;
        private System.Windows.Forms.ListBox lbIngredients;
    }
}