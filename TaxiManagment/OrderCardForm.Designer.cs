namespace TaxiManagment
{
    partial class OrderCardForm
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
            this.reject_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderdate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.placeFrom_textBox = new System.Windows.Forms.TextBox();
            this.placeTo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.driver_textBox = new System.Windows.Forms.TextBox();
            this.choiceDriver_button = new System.Windows.Forms.Button();
            this.responsible_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reject_button
            // 
            this.reject_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reject_button.Location = new System.Drawing.Point(642, 55);
            this.reject_button.Name = "reject_button";
            this.reject_button.Size = new System.Drawing.Size(113, 23);
            this.reject_button.TabIndex = 22;
            this.reject_button.Text = "Отмена";
            this.reject_button.UseVisualStyleBackColor = true;
            this.reject_button.Click += new System.EventHandler(this.reject_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept_button.Location = new System.Drawing.Point(642, 12);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(113, 23);
            this.accept_button.TabIndex = 21;
            this.accept_button.Text = "ОК";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // phone_maskedTextBox
            // 
            this.phone_maskedTextBox.Location = new System.Drawing.Point(137, 42);
            this.phone_maskedTextBox.Mask = "+7 (999) 999-99-99";
            this.phone_maskedTextBox.Name = "phone_maskedTextBox";
            this.phone_maskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.phone_maskedTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ном. тел. закаазчика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Дата и время:";
            // 
            // orderdate_dateTimePicker
            // 
            this.orderdate_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.orderdate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderdate_dateTimePicker.Location = new System.Drawing.Point(137, 8);
            this.orderdate_dateTimePicker.Name = "orderdate_dateTimePicker";
            this.orderdate_dateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.orderdate_dateTimePicker.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пункт отправления:";
            // 
            // placeFrom_textBox
            // 
            this.placeFrom_textBox.Location = new System.Drawing.Point(137, 81);
            this.placeFrom_textBox.Name = "placeFrom_textBox";
            this.placeFrom_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeFrom_textBox.TabIndex = 28;
            // 
            // placeTo_textBox
            // 
            this.placeTo_textBox.Location = new System.Drawing.Point(137, 118);
            this.placeTo_textBox.Name = "placeTo_textBox";
            this.placeTo_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeTo_textBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Пункт назначения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = " Статус:";
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(137, 189);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(110, 20);
            this.price_textBox.TabIndex = 33;
            // 
            // status_comboBox
            // 
            this.status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Создан",
            "Принят",
            "Выполняется",
            "Выполнен",
            "Отменён"});
            this.status_comboBox.Location = new System.Drawing.Point(137, 226);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(125, 21);
            this.status_comboBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Водитель:";
            // 
            // driver_textBox
            // 
            this.driver_textBox.Location = new System.Drawing.Point(137, 152);
            this.driver_textBox.Name = "driver_textBox";
            this.driver_textBox.ReadOnly = true;
            this.driver_textBox.Size = new System.Drawing.Size(435, 20);
            this.driver_textBox.TabIndex = 36;
            // 
            // choiceDriver_button
            // 
            this.choiceDriver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiceDriver_button.Location = new System.Drawing.Point(575, 150);
            this.choiceDriver_button.Name = "choiceDriver_button";
            this.choiceDriver_button.Size = new System.Drawing.Size(30, 25);
            this.choiceDriver_button.TabIndex = 37;
            this.choiceDriver_button.Text = "...";
            this.choiceDriver_button.UseVisualStyleBackColor = true;
            this.choiceDriver_button.Click += new System.EventHandler(this.choiceDriver_button_Click);
            // 
            // responsible_label
            // 
            this.responsible_label.AutoSize = true;
            this.responsible_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responsible_label.ForeColor = System.Drawing.Color.Red;
            this.responsible_label.Location = new System.Drawing.Point(13, 276);
            this.responsible_label.Name = "responsible_label";
            this.responsible_label.Size = new System.Drawing.Size(127, 16);
            this.responsible_label.TabIndex = 38;
            this.responsible_label.Text = "Ответственный:";
            // 
            // OrderCardForm
            // 
            this.AcceptButton = this.accept_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.reject_button;
            this.ClientSize = new System.Drawing.Size(768, 306);
            this.Controls.Add(this.responsible_label);
            this.Controls.Add(this.choiceDriver_button);
            this.Controls.Add(this.driver_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.placeTo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placeFrom_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderdate_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reject_button);
            this.Controls.Add(this.accept_button);
            this.Name = "OrderCardForm";
            this.Text = "Заказ такси";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reject_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.MaskedTextBox phone_maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker orderdate_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox placeFrom_textBox;
        private System.Windows.Forms.TextBox placeTo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox driver_textBox;
        private System.Windows.Forms.Button choiceDriver_button;
        private System.Windows.Forms.Label responsible_label;
    }
}