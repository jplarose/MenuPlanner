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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblServings = new System.Windows.Forms.Label();
            this.txtCalPerServing = new System.Windows.Forms.TextBox();
            this.lblCalPerServing = new System.Windows.Forms.Label();
            this.rtxtRecipeInstructions = new System.Windows.Forms.RichTextBox();
            this.lblRecipeInstructions = new System.Windows.Forms.Label();
            this.btnMyRecipes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMealPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(13, 73);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(351, 20);
            this.txtMealName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient,
            this.Qty,
            this.Unit});
            this.dataGridView1.Location = new System.Drawing.Point(19, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Ingredient
            // 
            this.Ingredient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ingredient.HeaderText = "Ingredient";
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(19, 397);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(177, 20);
            this.txtIngredient.TabIndex = 8;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(203, 397);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(53, 20);
            this.txtQty.TabIndex = 9;
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(263, 397);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(101, 21);
            this.cboUnit.TabIndex = 10;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(19, 378);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(54, 13);
            this.lblIngredient.TabIndex = 11;
            this.lblIngredient.Text = "Ingredient";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(203, 377);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 12;
            this.lblQty.Text = "Qty";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(263, 378);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "Unit";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(370, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(10, 96);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(48, 13);
            this.lblServings.TabIndex = 17;
            this.lblServings.Text = "Servings";
            // 
            // txtCalPerServing
            // 
            this.txtCalPerServing.Location = new System.Drawing.Point(67, 112);
            this.txtCalPerServing.Name = "txtCalPerServing";
            this.txtCalPerServing.Size = new System.Drawing.Size(103, 20);
            this.txtCalPerServing.TabIndex = 18;
            // 
            // lblCalPerServing
            // 
            this.lblCalPerServing.AutoSize = true;
            this.lblCalPerServing.Location = new System.Drawing.Point(68, 96);
            this.lblCalPerServing.Name = "lblCalPerServing";
            this.lblCalPerServing.Size = new System.Drawing.Size(102, 13);
            this.lblCalPerServing.TabIndex = 19;
            this.lblCalPerServing.Text = "Calories Per Serving";
            // 
            // rtxtRecipeInstructions
            // 
            this.rtxtRecipeInstructions.Location = new System.Drawing.Point(13, 155);
            this.rtxtRecipeInstructions.Name = "rtxtRecipeInstructions";
            this.rtxtRecipeInstructions.Size = new System.Drawing.Size(513, 220);
            this.rtxtRecipeInstructions.TabIndex = 20;
            this.rtxtRecipeInstructions.Text = "";
            // 
            // lblRecipeInstructions
            // 
            this.lblRecipeInstructions.AutoSize = true;
            this.lblRecipeInstructions.Location = new System.Drawing.Point(12, 136);
            this.lblRecipeInstructions.Name = "lblRecipeInstructions";
            this.lblRecipeInstructions.Size = new System.Drawing.Size(98, 13);
            this.lblRecipeInstructions.TabIndex = 21;
            this.lblRecipeInstructions.Text = "Recipe Instructions";
            // 
            // btnMyRecipes
            // 
            this.btnMyRecipes.Location = new System.Drawing.Point(12, 29);
            this.btnMyRecipes.Name = "btnMyRecipes";
            this.btnMyRecipes.Size = new System.Drawing.Size(127, 23);
            this.btnMyRecipes.TabIndex = 22;
            this.btnMyRecipes.Text = "My Recipes";
            this.btnMyRecipes.UseVisualStyleBackColor = true;
            this.btnMyRecipes.Click += new System.EventHandler(this.btnMyRecipes_Click);
            // 
            // frmMealEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 610);
            this.Controls.Add(this.btnMyRecipes);
            this.Controls.Add(this.lblRecipeInstructions);
            this.Controls.Add(this.rtxtRecipeInstructions);
            this.Controls.Add(this.lblCalPerServing);
            this.Controls.Add(this.txtCalPerServing);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbMealPic);
            this.Controls.Add(this.chkSaveMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmMealEntry";
            this.Text = "{Meal Text}";
            ((System.ComponentModel.ISupportInitialize)(this.pbMealPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.TextBox txtCalPerServing;
        private System.Windows.Forms.Label lblCalPerServing;
        private System.Windows.Forms.RichTextBox rtxtRecipeInstructions;
        private System.Windows.Forms.Label lblRecipeInstructions;
        private System.Windows.Forms.Button btnMyRecipes;
    }
}