namespace TaxiManagment
{
    partial class FilterForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.placeTo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.placeFrom_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.driver_textBox = new System.Windows.Forms.TextBox();
            this.clientPhone_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Водитель:";
            // 
            // placeTo_textBox
            // 
            this.placeTo_textBox.Location = new System.Drawing.Point(133, 120);
            this.placeTo_textBox.Name = "placeTo_textBox";
            this.placeTo_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeTo_textBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Пункт назначения:";
            // 
            // placeFrom_textBox
            // 
            this.placeFrom_textBox.Location = new System.Drawing.Point(133, 83);
            this.placeFrom_textBox.Name = "placeFrom_textBox";
            this.placeFrom_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeFrom_textBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Пункт отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ном. тел. закаазчика:";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(603, 56);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(113, 23);
            this.clear_button.TabIndex = 37;
            this.clear_button.Text = "Сбросить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.reject_button_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(603, 13);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(113, 23);
            this.set_button.TabIndex = 36;
            this.set_button.Text = "Установить";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // driver_textBox
            // 
            this.driver_textBox.Location = new System.Drawing.Point(133, 46);
            this.driver_textBox.Name = "driver_textBox";
            this.driver_textBox.Size = new System.Drawing.Size(274, 20);
            this.driver_textBox.TabIndex = 45;
            // 
            // clientPhone_textBox
            // 
            this.clientPhone_textBox.Location = new System.Drawing.Point(133, 12);
            this.clientPhone_textBox.Name = "clientPhone_textBox";
            this.clientPhone_textBox.Size = new System.Drawing.Size(132, 20);
            this.clientPhone_textBox.TabIndex = 46;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 167);
            this.Controls.Add(this.clientPhone_textBox);
            this.Controls.Add(this.driver_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.placeTo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placeFrom_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.set_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.Text = "Установка фильтров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox placeTo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox placeFrom_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.TextBox driver_textBox;
        private System.Windows.Forms.TextBox clientPhone_textBox;
    }
}