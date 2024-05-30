namespace TaxiManagment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.admin_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.users_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orders_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrder_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeOrder_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrder_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cars_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivers_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersByPeriod_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.main_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOrder_ContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderContext_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderContext_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrderCard_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            this.main_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_ToolStripMenuItem,
            this.orders_ToolStripMenuItem,
            this.reference_ToolStripMenuItem,
            this.reports_ToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Size = new System.Drawing.Size(1500, 24);
            this.main_menuStrip.TabIndex = 0;
            this.main_menuStrip.Text = "menuStrip1";
            // 
            // admin_ToolStripMenuItem
            // 
            this.admin_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.users_StripMenuItem,
            this.changePassword_ToolStripMenuItem});
            this.admin_ToolStripMenuItem.Name = "admin_ToolStripMenuItem";
            this.admin_ToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.admin_ToolStripMenuItem.Text = "Администрирование";
            // 
            // users_StripMenuItem
            // 
            this.users_StripMenuItem.Name = "users_StripMenuItem";
            this.users_StripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.users_StripMenuItem.Text = "Управление списком пользователей";
            this.users_StripMenuItem.Click += new System.EventHandler(this.users_StripMenuItem_Click);
            // 
            // changePassword_ToolStripMenuItem
            // 
            this.changePassword_ToolStripMenuItem.Name = "changePassword_ToolStripMenuItem";
            this.changePassword_ToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.changePassword_ToolStripMenuItem.Text = "Изменить свой пароль";
            this.changePassword_ToolStripMenuItem.Click += new System.EventHandler(this.changePassword_ToolStripMenuItem_Click);
            // 
            // orders_ToolStripMenuItem
            // 
            this.orders_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrder_ToolStripMenuItem,
            this.changeOrder_ToolStripMenuItem,
            this.deleteOrder_ToolStripMenuItem});
            this.orders_ToolStripMenuItem.Name = "orders_ToolStripMenuItem";
            this.orders_ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.orders_ToolStripMenuItem.Text = "Заказы";
            // 
            // addOrder_ToolStripMenuItem
            // 
            this.addOrder_ToolStripMenuItem.Name = "addOrder_ToolStripMenuItem";
            this.addOrder_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addOrder_ToolStripMenuItem.Text = "Добавить";
            this.addOrder_ToolStripMenuItem.Click += new System.EventHandler(this.addOrder_ToolStripMenuItem_Click);
            // 
            // changeOrder_ToolStripMenuItem
            // 
            this.changeOrder_ToolStripMenuItem.Name = "changeOrder_ToolStripMenuItem";
            this.changeOrder_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.changeOrder_ToolStripMenuItem.Text = "Изменить";
            this.changeOrder_ToolStripMenuItem.Click += new System.EventHandler(this.changeOrder_ToolStripMenuItem_Click);
            // 
            // deleteOrder_ToolStripMenuItem
            // 
            this.deleteOrder_ToolStripMenuItem.Name = "deleteOrder_ToolStripMenuItem";
            this.deleteOrder_ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteOrder_ToolStripMenuItem.Text = "Удалить";
            this.deleteOrder_ToolStripMenuItem.Click += new System.EventHandler(this.deleteOrder_ToolStripMenuItem_Click);
            // 
            // reference_ToolStripMenuItem
            // 
            this.reference_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cars_ToolStripMenuItem,
            this.drivers_ToolStripMenuItem});
            this.reference_ToolStripMenuItem.Name = "reference_ToolStripMenuItem";
            this.reference_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.reference_ToolStripMenuItem.Text = "Справочники";
            // 
            // cars_ToolStripMenuItem
            // 
            this.cars_ToolStripMenuItem.Name = "cars_ToolStripMenuItem";
            this.cars_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cars_ToolStripMenuItem.Text = "Транспортные средства";
            this.cars_ToolStripMenuItem.Click += new System.EventHandler(this.cars_ToolStripMenuItem_Click);
            // 
            // drivers_ToolStripMenuItem
            // 
            this.drivers_ToolStripMenuItem.Name = "drivers_ToolStripMenuItem";
            this.drivers_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.drivers_ToolStripMenuItem.Text = "Водители";
            this.drivers_ToolStripMenuItem.Click += new System.EventHandler(this.drivers_ToolStripMenuItem_Click);
            // 
            // reports_ToolStripMenuItem
            // 
            this.reports_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersByPeriod_ToolStripMenuItem});
            this.reports_ToolStripMenuItem.Name = "reports_ToolStripMenuItem";
            this.reports_ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reports_ToolStripMenuItem.Text = "Отчёты";
            // 
            // ordersByPeriod_ToolStripMenuItem
            // 
            this.ordersByPeriod_ToolStripMenuItem.Name = "ordersByPeriod_ToolStripMenuItem";
            this.ordersByPeriod_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersByPeriod_ToolStripMenuItem.Text = "Заказы за период";
            this.ordersByPeriod_ToolStripMenuItem.Click += new System.EventHandler(this.ordersByPeriod_ToolStripMenuItem_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(7, 27);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(122, 23);
            this.filter_button.TabIndex = 1;
            this.filter_button.Text = "Настройки фильтров";
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
            this.orders_dataGridView.ContextMenuStrip = this.main_contextMenuStrip;
            this.orders_dataGridView.Location = new System.Drawing.Point(12, 57);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.ReadOnly = true;
            this.orders_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders_dataGridView.Size = new System.Drawing.Size(1466, 477);
            this.orders_dataGridView.TabIndex = 2;
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
            dataGridViewCellStyle6.NullValue = "0";
            this.iddriver.DefaultCellStyle = dataGridViewCellStyle6;
            this.iddriver.HeaderText = "ИД Водителя";
            this.iddriver.Name = "iddriver";
            this.iddriver.ReadOnly = true;
            this.iddriver.Visible = false;
            // 
            // driver_name
            // 
            this.driver_name.DataPropertyName = "driver_name";
            dataGridViewCellStyle7.NullValue = " ";
            this.driver_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.driver_name.HeaderText = "Водитель";
            this.driver_name.Name = "driver_name";
            this.driver_name.ReadOnly = true;
            this.driver_name.Width = 150;
            // 
            // driver_phone
            // 
            this.driver_phone.DataPropertyName = "driver_phone";
            dataGridViewCellStyle8.NullValue = " ";
            this.driver_phone.DefaultCellStyle = dataGridViewCellStyle8;
            this.driver_phone.HeaderText = "Тел. водителя";
            this.driver_phone.Name = "driver_phone";
            this.driver_phone.ReadOnly = true;
            // 
            // car
            // 
            this.car.DataPropertyName = "car";
            dataGridViewCellStyle9.NullValue = " ";
            this.car.DefaultCellStyle = dataGridViewCellStyle9;
            this.car.HeaderText = "Транспортное средство";
            this.car.Name = "car";
            this.car.ReadOnly = true;
            this.car.Width = 200;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle10;
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
            // main_contextMenuStrip
            // 
            this.main_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrder_ContextToolStripMenuItem,
            this.editOrderContext_ToolStripMenuItem,
            this.deleteOrderContext_ToolStripMenuItem,
            this.showOrderCard_ToolStripMenuItem});
            this.main_contextMenuStrip.Name = "main_contextMenuStrip";
            this.main_contextMenuStrip.Size = new System.Drawing.Size(215, 92);
            // 
            // addOrder_ContextToolStripMenuItem
            // 
            this.addOrder_ContextToolStripMenuItem.Name = "addOrder_ContextToolStripMenuItem";
            this.addOrder_ContextToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addOrder_ContextToolStripMenuItem.Text = "Довавить заказ";
            this.addOrder_ContextToolStripMenuItem.Click += new System.EventHandler(this.addOrder_ToolStripMenuItem_Click);
            // 
            // editOrderContext_ToolStripMenuItem
            // 
            this.editOrderContext_ToolStripMenuItem.Name = "editOrderContext_ToolStripMenuItem";
            this.editOrderContext_ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editOrderContext_ToolStripMenuItem.Text = "Изменить заказ";
            this.editOrderContext_ToolStripMenuItem.Click += new System.EventHandler(this.changeOrder_ToolStripMenuItem_Click);
            // 
            // deleteOrderContext_ToolStripMenuItem
            // 
            this.deleteOrderContext_ToolStripMenuItem.Name = "deleteOrderContext_ToolStripMenuItem";
            this.deleteOrderContext_ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteOrderContext_ToolStripMenuItem.Text = "Удалить заказ";
            this.deleteOrderContext_ToolStripMenuItem.Click += new System.EventHandler(this.deleteOrder_ToolStripMenuItem_Click);
            // 
            // showOrderCard_ToolStripMenuItem
            // 
            this.showOrderCard_ToolStripMenuItem.Name = "showOrderCard_ToolStripMenuItem";
            this.showOrderCard_ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.showOrderCard_ToolStripMenuItem.Text = "Показать карточку заказа";
            this.showOrderCard_ToolStripMenuItem.Click += new System.EventHandler(this.showOrderCard_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 546);
            this.Controls.Add(this.orders_dataGridView);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.main_menuStrip);
            this.MainMenuStrip = this.main_menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Диспетчерская такси";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
            this.main_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem admin_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem users_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassword_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reference_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cars_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivers_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reports_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersByPeriod_ToolStripMenuItem;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.ToolStripMenuItem orders_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrder_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOrder_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrder_ToolStripMenuItem;
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
        private System.Windows.Forms.ContextMenuStrip main_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addOrder_ContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderContext_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderContext_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrderCard_ToolStripMenuItem;
    }
}