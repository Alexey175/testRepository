namespace testTemplate
{
    partial class FormCreatorWord
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
            this.buttonCreateForm = new System.Windows.Forms.Button();
            this.textBoxDeveloped = new System.Windows.Forms.TextBox();
            this.textBoxChecked = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.labelDeveloped = new System.Windows.Forms.Label();
            this.labelChecked = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesintation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateForm
            // 
            this.buttonCreateForm.Location = new System.Drawing.Point(152, 158);
            this.buttonCreateForm.Name = "buttonCreateForm";
            this.buttonCreateForm.Size = new System.Drawing.Size(103, 23);
            this.buttonCreateForm.TabIndex = 5;
            this.buttonCreateForm.Text = "Создать форму";
            this.buttonCreateForm.UseVisualStyleBackColor = true;
            this.buttonCreateForm.Click += new System.EventHandler(this.buttonCreateForm_Click);
            // 
            // textBoxDeveloped
            // 
            this.textBoxDeveloped.Location = new System.Drawing.Point(99, 42);
            this.textBoxDeveloped.Name = "textBoxDeveloped";
            this.textBoxDeveloped.Size = new System.Drawing.Size(156, 20);
            this.textBoxDeveloped.TabIndex = 1;
            // 
            // textBoxChecked
            // 
            this.textBoxChecked.Location = new System.Drawing.Point(99, 68);
            this.textBoxChecked.Name = "textBoxChecked";
            this.textBoxChecked.Size = new System.Drawing.Size(156, 20);
            this.textBoxChecked.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(99, 122);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(156, 20);
            this.textBoxDesignation.TabIndex = 4;
            // 
            // labelDeveloped
            // 
            this.labelDeveloped.AutoSize = true;
            this.labelDeveloped.Location = new System.Drawing.Point(12, 45);
            this.labelDeveloped.Name = "labelDeveloped";
            this.labelDeveloped.Size = new System.Drawing.Size(67, 13);
            this.labelDeveloped.TabIndex = 6;
            this.labelDeveloped.Text = "Разработал";
            // 
            // labelChecked
            // 
            this.labelChecked.AutoSize = true;
            this.labelChecked.Location = new System.Drawing.Point(12, 71);
            this.labelChecked.Name = "labelChecked";
            this.labelChecked.Size = new System.Drawing.Size(57, 13);
            this.labelChecked.TabIndex = 7;
            this.labelChecked.Text = "Проверил";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Наименование";
            // 
            // labelDesintation
            // 
            this.labelDesintation.AutoSize = true;
            this.labelDesintation.Location = new System.Drawing.Point(12, 125);
            this.labelDesintation.Name = "labelDesintation";
            this.labelDesintation.Size = new System.Drawing.Size(74, 13);
            this.labelDesintation.TabIndex = 9;
            this.labelDesintation.Text = "Обозначение";
            // 
            // FormCreatorWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 195);
            this.Controls.Add(this.labelDesintation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelChecked);
            this.Controls.Add(this.labelDeveloped);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxChecked);
            this.Controls.Add(this.textBoxDeveloped);
            this.Controls.Add(this.buttonCreateForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 234);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(288, 234);
            this.Name = "FormCreatorWord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание WORD документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateForm;
        private System.Windows.Forms.TextBox textBoxDeveloped;
        private System.Windows.Forms.TextBox textBoxChecked;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label labelDeveloped;
        private System.Windows.Forms.Label labelChecked;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesintation;
    }
}

