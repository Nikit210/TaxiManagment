namespace TaxiManagment
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTo_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.clientPhone_textBox = new System.Windows.Forms.TextBox();
            this.driver_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.placeTo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.placeFrom_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.responsible_textBox = new System.Windows.Forms.TextBox();
            this.responsible_label = new System.Windows.Forms.Label();
            this.filter_button = new System.Windows.Forms.Button();
            this.orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sum_label = new System.Windows.Forms.Label();
            this.showCard_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата начала:";
            // 
            // dateFrom_dateTimePicker
            // 
            this.dateFrom_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateFrom_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom_dateTimePicker.Location = new System.Drawing.Point(141, 10);
            this.dateFrom_dateTimePicker.Name = "dateFrom_dateTimePicker";
            this.dateFrom_dateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.dateFrom_dateTimePicker.TabIndex = 27;
            // 
            // dateTo_dateTimePicker
            // 
            this.dateTo_dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTo_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo_dateTimePicker.Location = new System.Drawing.Point(738, 10);
            this.dateTo_dateTimePicker.Name = "dateTo_dateTimePicker";
            this.dateTo_dateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.dateTo_dateTimePicker.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Дата окончания:";
            // 
            // clientPhone_textBox
            // 
            this.clientPhone_textBox.Location = new System.Drawing.Point(141, 48);
            this.clientPhone_textBox.Name = "clientPhone_textBox";
            this.clientPhone_textBox.Size = new System.Drawing.Size(132, 20);
            this.clientPhone_textBox.TabIndex = 54;
            // 
            // driver_textBox
            // 
            this.driver_textBox.Location = new System.Drawing.Point(343, 50);
            this.driver_textBox.Name = "driver_textBox";
            this.driver_textBox.Size = new System.Drawing.Size(274, 20);
            this.driver_textBox.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Водитель:";
            // 
            // placeTo_textBox
            // 
            this.placeTo_textBox.Location = new System.Drawing.Point(738, 89);
            this.placeTo_textBox.Name = "placeTo_textBox";
            this.placeTo_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeTo_textBox.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Пункт назначения:";
            // 
            // placeFrom_textBox
            // 
            this.placeFrom_textBox.Location = new System.Drawing.Point(141, 89);
            this.placeFrom_textBox.Name = "placeFrom_textBox";
            this.placeFrom_textBox.Size = new System.Drawing.Size(435, 20);
            this.placeFrom_textBox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Пункт отправления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ном. тел. закаазчика:";
            // 
            // responsible_textBox
            // 
            this.responsible_textBox.Location = new System.Drawing.Point(738, 49);
            this.responsible_textBox.Name = "responsible_textBox";
            this.responsible_textBox.Size = new System.Drawing.Size(274, 20);
            this.responsible_textBox.TabIndex = 56;
            // 
            // responsible_label
            // 
            this.responsible_label.AutoSize = true;
            this.responsible_label.Location = new System.Drawing.Point(632, 52);
            this.responsible_label.Name = "responsible_label";
            this.responsible_label.Size = new System.Drawing.Size(89, 13);
            this.responsible_label.TabIndex = 55;
            this.responsible_label.Text = "Ответственный:";
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(1222, 47);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(122, 23);
            this.filter_button.TabIndex = 57;
            this.filter_button.Text = "Применить фильтры";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // orders_dataGridView
            // 
            this.orders_dataGridView.AllowUserToAddRows = false;
            this.orders_dataGridView.AllowUserToDeleteRows = false;
            this.orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.order_date,
            this.client_phone,
            this.place_from,
            this.place_to,
            this.iddriver,
            this.driver_name,
            this.driver_phone,
            this.car,
            this.price,
            this.iduser,
            this.user_name,
            this.status});
            this.orders_dataGridView.Location = new System.Drawing.Point(13, 122);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.ReadOnly = true;
            this.orders_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders_dataGridView.Size = new System.Drawing.Size(1466, 477);
            this.orders_dataGridView.TabIndex = 58;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Ном.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "Дата";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 80;
            // 
            // client_phone
            // 
            this.client_phone.DataPropertyName = "client_phone";
            this.client_phone.HeaderText = "Тел. клиента";
            this.client_phone.Name = "client_phone";
            this.client_phone.ReadOnly = true;
            // 
            // place_from
            // 
            this.place_from.DataPropertyName = "place_from";
            this.place_from.HeaderText = "Место отправления";
            this.place_from.Name = "place_from";
            this.place_from.ReadOnly = true;
            this.place_from.Width = 200;
            // 
            // place_to
            // 
            this.place_to.DataPropertyName = "place_to";
            this.place_to.HeaderText = "Место прибытия";
            this.place_to.Name = "place_to";
            this.place_to.ReadOnly = true;
            this.place_to.Width = 200;
            // 
            // iddriver
            // 
            this.iddriver.DataPropertyName = "iddriver";
            dataGridViewCellStyle11.NullValue = "0";
            this.iddriver.DefaultCellStyle = dataGridViewCellStyle11;
            this.iddriver.HeaderText = "ИД Водителя";
            this.iddriver.Name = "iddriver";
            this.iddriver.ReadOnly = true;
            this.iddriver.Visible = false;
            // 
            // driver_name
            // 
            this.driver_name.DataPropertyName = "driver_name";
            dataGridViewCellStyle12.NullValue = " ";
            this.driver_name.DefaultCellStyle = dataGridViewCellStyle12;
            this.driver_name.HeaderText = "Водитель";
            this.driver_name.Name = "driver_name";
            this.driver_name.ReadOnly = true;
            this.driver_name.Width = 150;
            // 
            // driver_phone
            // 
            this.driver_phone.DataPropertyName = "driver_phone";
            dataGridViewCellStyle13.NullValue = " ";
            this.driver_phone.DefaultCellStyle = dataGridViewCellStyle13;
            this.driver_phone.HeaderText = "Тел. водителя";
            this.driver_phone.Name = "driver_phone";
            this.driver_phone.ReadOnly = true;
            // 
            // car
            // 
            this.car.DataPropertyName = "car";
            dataGridViewCellStyle14.NullValue = " ";
            this.car.DefaultCellStyle = dataGridViewCellStyle14;
            this.car.HeaderText = "Транспортное средство";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            this.car.Width = 200;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle15;
            this.price.HeaderText = "Стоимость";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // iduser
            // 
            this.iduser.DataPropertyName = "iduser";
            this.iduser.HeaderText = "ИД пользователя";
            this.iduser.Name = "iduser";
            this.iduser.ReadOnly = true;
            this.iduser.Visible = false;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Ответственный";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // status_textBox
            // 
            this.status_textBox.Location = new System.Drawing.Point(1071, 49);
            this.status_textBox.Name = "status_textBox";
            this.status_textBox.Size = new System.Drawing.Size(132, 20);
            this.status_textBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1024, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Статус:";
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_label.Location = new System.Drawing.Point(16, 616);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(139, 16);
            this.sum_label.TabIndex = 61;
            this.sum_label.Text = "Сумма по закзам:";
            // 
            // showCard_button
            // 
            this.showCard_button.Location = new System.Drawing.Point(1222, 86);
            this.showCard_button.Name = "showCard_button";
            this.showCard_button.Size = new System.Drawing.Size(122, 23);
            this.showCard_button.TabIndex = 62;
            this.showCard_button.Text = "Показать карточку";
            this.showCard_button.UseVisualStyleBackColor = true;
            this.showCard_button.Click += new System.EventHandler(this.showCard_button_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 654);
            this.Controls.Add(this.showCard_button);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.status_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orders_dataGridView);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.responsible_textBox);
            this.Controls.Add(this.responsible_label);
            this.Controls.Add(this.clientPhone_textBox);
            this.Controls.Add(this.driver_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.placeTo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.placeFrom_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTo_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFrom_dateTimePicker);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.Text = "Заказы за период";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnPressKey);
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom_dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTo_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientPhone_textBox;
        private System.Windows.Forms.TextBox driver_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox placeTo_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox placeFrom_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox responsible_textBox;
        private System.Windows.Forms.Label responsible_label;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.DataGridView orders_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn car;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox status_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.Button showCard_button;
    }
}