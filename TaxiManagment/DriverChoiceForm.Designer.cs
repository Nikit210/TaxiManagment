namespace TaxiManagment
{
    partial class DriverChoiceForm
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
            this.drivers_dataGridView = new System.Windows.Forms.DataGridView();
            this.reject_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drivers_dataGridView
            // 
            this.drivers_dataGridView.AllowUserToAddRows = false;
            this.drivers_dataGridView.AllowUserToDeleteRows = false;
            this.drivers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drivers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.driver_name,
            this.driver_phone,
            this.car});
            this.drivers_dataGridView.Location = new System.Drawing.Point(13, 13);
            this.drivers_dataGridView.Name = "drivers_dataGridView";
            this.drivers_dataGridView.ReadOnly = true;
            this.drivers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drivers_dataGridView.Size = new System.Drawing.Size(653, 357);
            this.drivers_dataGridView.TabIndex = 0;
            // 
            // reject_button
            // 
            this.reject_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reject_button.Location = new System.Drawing.Point(693, 60);
            this.reject_button.Name = "reject_button";
            this.reject_button.Size = new System.Drawing.Size(113, 23);
            this.reject_button.TabIndex = 24;
            this.reject_button.Text = "Отмена";
            this.reject_button.UseVisualStyleBackColor = true;
            // 
            // accept_button
            // 
            this.accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept_button.Location = new System.Drawing.Point(693, 17);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(113, 23);
            this.accept_button.TabIndex = 23;
            this.accept_button.Text = "ОК";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ИД";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // driver_name
            // 
            this.driver_name.DataPropertyName = "driver_name";
            this.driver_name.HeaderText = "ФИО";
            this.driver_name.Name = "driver_name";
            this.driver_name.ReadOnly = true;
            this.driver_name.Width = 200;
            // 
            // driver_phone
            // 
            this.driver_phone.DataPropertyName = "driver_phone";
            this.driver_phone.HeaderText = "Ном. тел.";
            this.driver_phone.Name = "driver_phone";
            this.driver_phone.ReadOnly = true;
            // 
            // car
            // 
            this.car.DataPropertyName = "car";
            this.car.HeaderText = "Транспортное средство";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            this.car.Width = 300;
            // 
            // DriverChoiceForm
            // 
            this.AcceptButton = this.accept_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.reject_button;
            this.ClientSize = new System.Drawing.Size(823, 389);
            this.Controls.Add(this.reject_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.drivers_dataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DriverChoiceForm";
            this.Text = "Свободные водители";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.drivers_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drivers_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.Button reject_button;
        private System.Windows.Forms.Button accept_button;
    }
}