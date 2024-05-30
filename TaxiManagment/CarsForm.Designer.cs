namespace TaxiManagment
{
    partial class CarsForm
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
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.number_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mark_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(702, 102);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(702, 55);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(702, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 12;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Транспортное средство:";
            // 
            // vehicle_comboBox
            // 
            this.vehicle_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicle_comboBox.FormattingEnabled = true;
            this.vehicle_comboBox.Location = new System.Drawing.Point(152, 11);
            this.vehicle_comboBox.Name = "vehicle_comboBox";
            this.vehicle_comboBox.Size = new System.Drawing.Size(528, 21);
            this.vehicle_comboBox.TabIndex = 16;
            this.vehicle_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnCarInListChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Гос. номер:";
            // 
            // number_maskedTextBox
            // 
            this.number_maskedTextBox.Location = new System.Drawing.Point(152, 46);
            this.number_maskedTextBox.Mask = "& 000 && 900";
            this.number_maskedTextBox.Name = "number_maskedTextBox";
            this.number_maskedTextBox.Size = new System.Drawing.Size(95, 20);
            this.number_maskedTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Марка авто:";
            // 
            // mark_textBox
            // 
            this.mark_textBox.Location = new System.Drawing.Point(152, 76);
            this.mark_textBox.Name = "mark_textBox";
            this.mark_textBox.Size = new System.Drawing.Size(328, 20);
            this.mark_textBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цвет:";
            // 
            // color_comboBox
            // 
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Items.AddRange(new object[] {
            "Белый",
            "Серый",
            "Синий",
            "Бордовый",
            "Красный",
            "Малиновый",
            "Серебристый",
            "Голубой",
            "Бежевый",
            "Чёрный"});
            this.color_comboBox.Location = new System.Drawing.Point(152, 111);
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.Size = new System.Drawing.Size(211, 21);
            this.color_comboBox.TabIndex = 22;
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 157);
            this.Controls.Add(this.color_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mark_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number_maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicle_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarsForm";
            this.Text = "Транспортные средства";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehicle_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox number_maskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mark_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox color_comboBox;
    }
}