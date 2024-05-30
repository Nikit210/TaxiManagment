namespace TaxiManagment
{
    partial class DriversForm
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
            this.name_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telegram_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicle_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(666, 108);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(113, 23);
            this.delete_button.TabIndex = 17;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(666, 61);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(113, 23);
            this.edit_button.TabIndex = 16;
            this.edit_button.Text = "Изменить";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(666, 18);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 23);
            this.add_button.TabIndex = 15;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ФИО:";
            // 
            // name_comboBox
            // 
            this.name_comboBox.FormattingEnabled = true;
            this.name_comboBox.Location = new System.Drawing.Point(100, 13);
            this.name_comboBox.Name = "name_comboBox";
            this.name_comboBox.Size = new System.Drawing.Size(458, 21);
            this.name_comboBox.TabIndex = 19;
            this.name_comboBox.SelectedIndexChanged += new System.EventHandler(this.OnDriverNameChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ном. тел.:";
            // 
            // phone_maskedTextBox
            // 
            this.phone_maskedTextBox.Location = new System.Drawing.Point(100, 58);
            this.phone_maskedTextBox.Mask = "+7 (999) 999-99-99";
            this.phone_maskedTextBox.Name = "phone_maskedTextBox";
            this.phone_maskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.phone_maskedTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Телеграм:";
            // 
            // telegram_textBox
            // 
            this.telegram_textBox.Location = new System.Drawing.Point(100, 99);
            this.telegram_textBox.Name = "telegram_textBox";
            this.telegram_textBox.Size = new System.Drawing.Size(117, 20);
            this.telegram_textBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Транспортное средство:";
            // 
            // vehicle_comboBox
            // 
            this.vehicle_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicle_comboBox.FormattingEnabled = true;
            this.vehicle_comboBox.Location = new System.Drawing.Point(100, 138);
            this.vehicle_comboBox.Name = "vehicle_comboBox";
            this.vehicle_comboBox.Size = new System.Drawing.Size(528, 21);
            this.vehicle_comboBox.TabIndex = 25;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 189);
            this.Controls.Add(this.vehicle_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telegram_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone_maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DriversForm";
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox name_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox phone_maskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telegram_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vehicle_comboBox;
    }
}