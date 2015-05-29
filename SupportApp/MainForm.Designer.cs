namespace SupportApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.order_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_order_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redact = new System.Windows.Forms.Button();
            this.table_with_order = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersenderloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersendernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersenderlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersendersecondnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timehoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complexityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useranswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.supportDataSet1 = new SupportApp.supportDataSet1();
            this.supportDataSet = new SupportApp.supportDataSet();
            this.ordersTableAdapter = new SupportApp.supportDataSetTableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new SupportApp.supportDataSet1TableAdapters.OrdersTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_with_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.paramsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.order_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.new_order_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.order_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Синхронизация с сайтом";
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Location = new System.Drawing.Point(147, 64);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(0, 13);
            this.order_label.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Получено всего заявок:";
            // 
            // new_order_label
            // 
            this.new_order_label.AutoSize = true;
            this.new_order_label.Location = new System.Drawing.Point(162, 89);
            this.new_order_label.Name = "new_order_label";
            this.new_order_label.Size = new System.Drawing.Size(0, 13);
            this.new_order_label.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Получено новых заявок:";
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(15, 26);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(164, 23);
            this.order_btn.TabIndex = 0;
            this.order_btn.Text = "Проверить заявки";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.redact);
            this.groupBox2.Controls.Add(this.table_with_order);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 452);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица заявок";
            // 
            // redact
            // 
            this.redact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redact.Location = new System.Drawing.Point(189, 423);
            this.redact.Name = "redact";
            this.redact.Size = new System.Drawing.Size(244, 23);
            this.redact.TabIndex = 1;
            this.redact.Text = "Редактировать выбранную заявку";
            this.redact.UseVisualStyleBackColor = true;
            this.redact.Click += new System.EventHandler(this.redact_Click);
            // 
            // table_with_order
            // 
            this.table_with_order.AllowUserToAddRows = false;
            this.table_with_order.AllowUserToDeleteRows = false;
            this.table_with_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_with_order.AutoGenerateColumns = false;
            this.table_with_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_with_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_with_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categorynameDataGridViewTextBoxColumn,
            this.prioritynameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialnumberDataGridViewTextBoxColumn,
            this.datecreateDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.dateupdateDataGridViewTextBoxColumn,
            this.datedeadlineDataGridViewTextBoxColumn,
            this.usersenderloginDataGridViewTextBoxColumn,
            this.usersendernameDataGridViewTextBoxColumn,
            this.usersenderlastnameDataGridViewTextBoxColumn,
            this.usersendersecondnameDataGridViewTextBoxColumn,
            this.sendernameDataGridViewTextBoxColumn,
            this.senderpositionDataGridViewTextBoxColumn,
            this.senderlocationDataGridViewTextBoxColumn,
            this.statusnameDataGridViewTextBoxColumn,
            this.timehoursDataGridViewTextBoxColumn,
            this.complexityDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.usersenderDataGridViewTextBoxColumn,
            this.useranswerDataGridViewTextBoxColumn,
            this.priorityidDataGridViewTextBoxColumn,
            this.datefinishDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.prioritycodeDataGridViewTextBoxColumn,
            this.statuscodeDataGridViewTextBoxColumn});
            this.table_with_order.DataSource = this.ordersBindingSource2;
            this.table_with_order.Location = new System.Drawing.Point(14, 31);
            this.table_with_order.Name = "table_with_order";
            this.table_with_order.Size = new System.Drawing.Size(604, 370);
            this.table_with_order.TabIndex = 0;
            this.table_with_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_with_order_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioritynameDataGridViewTextBoxColumn
            // 
            this.prioritynameDataGridViewTextBoxColumn.DataPropertyName = "priority_name";
            this.prioritynameDataGridViewTextBoxColumn.HeaderText = "Приоритет заявки";
            this.prioritynameDataGridViewTextBoxColumn.Name = "prioritynameDataGridViewTextBoxColumn";
            this.prioritynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель оборудования";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialnumberDataGridViewTextBoxColumn
            // 
            this.serialnumberDataGridViewTextBoxColumn.DataPropertyName = "serial_number";
            this.serialnumberDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.serialnumberDataGridViewTextBoxColumn.Name = "serialnumberDataGridViewTextBoxColumn";
            this.serialnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecreateDataGridViewTextBoxColumn
            // 
            this.datecreateDataGridViewTextBoxColumn.DataPropertyName = "date_create";
            this.datecreateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.datecreateDataGridViewTextBoxColumn.Name = "datecreateDataGridViewTextBoxColumn";
            this.datecreateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateupdateDataGridViewTextBoxColumn
            // 
            this.dateupdateDataGridViewTextBoxColumn.DataPropertyName = "date_update";
            this.dateupdateDataGridViewTextBoxColumn.HeaderText = "Дата изменения";
            this.dateupdateDataGridViewTextBoxColumn.Name = "dateupdateDataGridViewTextBoxColumn";
            this.dateupdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datedeadlineDataGridViewTextBoxColumn
            // 
            this.datedeadlineDataGridViewTextBoxColumn.DataPropertyName = "date_deadline";
            this.datedeadlineDataGridViewTextBoxColumn.HeaderText = "Крайний срок";
            this.datedeadlineDataGridViewTextBoxColumn.Name = "datedeadlineDataGridViewTextBoxColumn";
            this.datedeadlineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersenderloginDataGridViewTextBoxColumn
            // 
            this.usersenderloginDataGridViewTextBoxColumn.DataPropertyName = "user_sender_login";
            this.usersenderloginDataGridViewTextBoxColumn.HeaderText = "Email пользователя";
            this.usersenderloginDataGridViewTextBoxColumn.Name = "usersenderloginDataGridViewTextBoxColumn";
            this.usersenderloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersendernameDataGridViewTextBoxColumn
            // 
            this.usersendernameDataGridViewTextBoxColumn.DataPropertyName = "user_sender_name";
            this.usersendernameDataGridViewTextBoxColumn.HeaderText = "Имя пользователя";
            this.usersendernameDataGridViewTextBoxColumn.Name = "usersendernameDataGridViewTextBoxColumn";
            this.usersendernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersenderlastnameDataGridViewTextBoxColumn
            // 
            this.usersenderlastnameDataGridViewTextBoxColumn.DataPropertyName = "user_sender_lastname";
            this.usersenderlastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия пользователя";
            this.usersenderlastnameDataGridViewTextBoxColumn.Name = "usersenderlastnameDataGridViewTextBoxColumn";
            this.usersenderlastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersendersecondnameDataGridViewTextBoxColumn
            // 
            this.usersendersecondnameDataGridViewTextBoxColumn.DataPropertyName = "user_sender_secondname";
            this.usersendersecondnameDataGridViewTextBoxColumn.HeaderText = "Отчество пользователя";
            this.usersendersecondnameDataGridViewTextBoxColumn.Name = "usersendersecondnameDataGridViewTextBoxColumn";
            this.usersendersecondnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendernameDataGridViewTextBoxColumn
            // 
            this.sendernameDataGridViewTextBoxColumn.DataPropertyName = "sender_name";
            this.sendernameDataGridViewTextBoxColumn.HeaderText = "Имя заявителя";
            this.sendernameDataGridViewTextBoxColumn.Name = "sendernameDataGridViewTextBoxColumn";
            this.sendernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderpositionDataGridViewTextBoxColumn
            // 
            this.senderpositionDataGridViewTextBoxColumn.DataPropertyName = "sender_position";
            this.senderpositionDataGridViewTextBoxColumn.HeaderText = "Должность заявителя";
            this.senderpositionDataGridViewTextBoxColumn.Name = "senderpositionDataGridViewTextBoxColumn";
            this.senderpositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderlocationDataGridViewTextBoxColumn
            // 
            this.senderlocationDataGridViewTextBoxColumn.DataPropertyName = "sender_location";
            this.senderlocationDataGridViewTextBoxColumn.HeaderText = "Местоположение";
            this.senderlocationDataGridViewTextBoxColumn.Name = "senderlocationDataGridViewTextBoxColumn";
            this.senderlocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusnameDataGridViewTextBoxColumn
            // 
            this.statusnameDataGridViewTextBoxColumn.DataPropertyName = "status_name";
            this.statusnameDataGridViewTextBoxColumn.HeaderText = "Статус заявки";
            this.statusnameDataGridViewTextBoxColumn.Name = "statusnameDataGridViewTextBoxColumn";
            this.statusnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timehoursDataGridViewTextBoxColumn
            // 
            this.timehoursDataGridViewTextBoxColumn.DataPropertyName = "time_hours";
            this.timehoursDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timehoursDataGridViewTextBoxColumn.Name = "timehoursDataGridViewTextBoxColumn";
            this.timehoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complexityDataGridViewTextBoxColumn
            // 
            this.complexityDataGridViewTextBoxColumn.DataPropertyName = "complexity";
            this.complexityDataGridViewTextBoxColumn.HeaderText = "Сложность";
            this.complexityDataGridViewTextBoxColumn.Name = "complexityDataGridViewTextBoxColumn";
            this.complexityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersenderDataGridViewTextBoxColumn
            // 
            this.usersenderDataGridViewTextBoxColumn.DataPropertyName = "user_sender";
            this.usersenderDataGridViewTextBoxColumn.HeaderText = "user_sender";
            this.usersenderDataGridViewTextBoxColumn.Name = "usersenderDataGridViewTextBoxColumn";
            this.usersenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersenderDataGridViewTextBoxColumn.Visible = false;
            // 
            // useranswerDataGridViewTextBoxColumn
            // 
            this.useranswerDataGridViewTextBoxColumn.DataPropertyName = "user_answer";
            this.useranswerDataGridViewTextBoxColumn.HeaderText = "user_answer";
            this.useranswerDataGridViewTextBoxColumn.Name = "useranswerDataGridViewTextBoxColumn";
            this.useranswerDataGridViewTextBoxColumn.ReadOnly = true;
            this.useranswerDataGridViewTextBoxColumn.Visible = false;
            // 
            // priorityidDataGridViewTextBoxColumn
            // 
            this.priorityidDataGridViewTextBoxColumn.DataPropertyName = "priority_id";
            this.priorityidDataGridViewTextBoxColumn.HeaderText = "priority_id";
            this.priorityidDataGridViewTextBoxColumn.Name = "priorityidDataGridViewTextBoxColumn";
            this.priorityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityidDataGridViewTextBoxColumn.Visible = false;
            // 
            // datefinishDataGridViewTextBoxColumn
            // 
            this.datefinishDataGridViewTextBoxColumn.DataPropertyName = "date_finish";
            this.datefinishDataGridViewTextBoxColumn.HeaderText = "date_finish";
            this.datefinishDataGridViewTextBoxColumn.Name = "datefinishDataGridViewTextBoxColumn";
            this.datefinishDataGridViewTextBoxColumn.ReadOnly = true;
            this.datefinishDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusidDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Visible = false;
            // 
            // prioritycodeDataGridViewTextBoxColumn
            // 
            this.prioritycodeDataGridViewTextBoxColumn.DataPropertyName = "priority_code";
            this.prioritycodeDataGridViewTextBoxColumn.HeaderText = "priority_code";
            this.prioritycodeDataGridViewTextBoxColumn.Name = "prioritycodeDataGridViewTextBoxColumn";
            this.prioritycodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prioritycodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statuscodeDataGridViewTextBoxColumn
            // 
            this.statuscodeDataGridViewTextBoxColumn.DataPropertyName = "status_code";
            this.statuscodeDataGridViewTextBoxColumn.HeaderText = "status_code";
            this.statuscodeDataGridViewTextBoxColumn.Name = "statuscodeDataGridViewTextBoxColumn";
            this.statuscodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.supportDataSet1;
            // 
            // supportDataSet1
            // 
            this.supportDataSet1.DataSetName = "supportDataSet1";
            this.supportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supportDataSet
            // 
            this.supportDataSet.DataSetName = "supportDataSet";
            this.supportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(657, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Support App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_with_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView table_with_order;
        private supportDataSet supportDataSet;
        private supportDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private supportDataSet1 supportDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private supportDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        public System.Windows.Forms.Label new_order_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedeadlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersenderloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersenderlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersendersecondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timehoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complexityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useranswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button redact;
    }
}

