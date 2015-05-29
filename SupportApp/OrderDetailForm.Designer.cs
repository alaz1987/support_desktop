namespace SupportApp
{
    partial class OrderDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.serial_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.category_name = new System.Windows.Forms.TextBox();
            this.priority_name = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.serial_number = new System.Windows.Forms.TextBox();
            this.user_sender_login = new System.Windows.Forms.TextBox();
            this.user_sender_name = new System.Windows.Forms.TextBox();
            this.user_sender_lastname = new System.Windows.Forms.TextBox();
            this.user_sender_secondname = new System.Windows.Forms.TextBox();
            this.sender_name = new System.Windows.Forms.TextBox();
            this.sender_position = new System.Windows.Forms.TextBox();
            this.sender_location = new System.Windows.Forms.TextBox();
            this.time_hours = new System.Windows.Forms.TextBox();
            this.complexity = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.date_create = new System.Windows.Forms.TextBox();
            this.date_start = new System.Windows.Forms.TextBox();
            this.date_update = new System.Windows.Forms.TextBox();
            this.date_deadline = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(574, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактирование заявки:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Himalaya", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(250, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 22);
            this.name.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_deadline);
            this.panel1.Controls.Add(this.date_update);
            this.panel1.Controls.Add(this.date_start);
            this.panel1.Controls.Add(this.date_create);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.serial_number);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.priority_name);
            this.panel1.Controls.Add(this.category_name);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.serial_label);
            this.panel1.Controls.Add(this.model_label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.name2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 406);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название:";
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(140, 16);
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            this.name2.Size = new System.Drawing.Size(190, 20);
            this.name2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приоритет заявки";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(14, 207);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(120, 13);
            this.model_label.TabIndex = 5;
            this.model_label.Text = "Модель оборудования";
            // 
            // serial_label
            // 
            this.serial_label.AutoSize = true;
            this.serial_label.Location = new System.Drawing.Point(14, 237);
            this.serial_label.Name = "serial_label";
            this.serial_label.Size = new System.Drawing.Size(93, 13);
            this.serial_label.TabIndex = 6;
            this.serial_label.Text = "Серийный номер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата создания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата начала";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Дата изменения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Крайний срок";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.complexity);
            this.panel2.Controls.Add(this.time_hours);
            this.panel2.Controls.Add(this.sender_location);
            this.panel2.Controls.Add(this.sender_position);
            this.panel2.Controls.Add(this.sender_name);
            this.panel2.Controls.Add(this.user_sender_secondname);
            this.panel2.Controls.Add(this.user_sender_lastname);
            this.panel2.Controls.Add(this.user_sender_name);
            this.panel2.Controls.Add(this.user_sender_login);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(373, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 342);
            this.panel2.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email пользователя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Имя пользователя";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Фамилия пользователя";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Отчество пользователя";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Имя заявителя";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Должность заявителя";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Местоположение";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Статус заявки";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Время";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 302);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Сложность";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(655, 441);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(140, 144);
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Size = new System.Drawing.Size(190, 20);
            this.category_name.TabIndex = 11;
            // 
            // priority_name
            // 
            this.priority_name.Location = new System.Drawing.Point(140, 176);
            this.priority_name.Name = "priority_name";
            this.priority_name.ReadOnly = true;
            this.priority_name.Size = new System.Drawing.Size(190, 20);
            this.priority_name.TabIndex = 12;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(140, 205);
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Size = new System.Drawing.Size(190, 20);
            this.model.TabIndex = 13;
            // 
            // serial_number
            // 
            this.serial_number.Location = new System.Drawing.Point(140, 237);
            this.serial_number.Name = "serial_number";
            this.serial_number.ReadOnly = true;
            this.serial_number.Size = new System.Drawing.Size(190, 20);
            this.serial_number.TabIndex = 14;
            // 
            // user_sender_login
            // 
            this.user_sender_login.Location = new System.Drawing.Point(184, 18);
            this.user_sender_login.Name = "user_sender_login";
            this.user_sender_login.ReadOnly = true;
            this.user_sender_login.Size = new System.Drawing.Size(157, 20);
            this.user_sender_login.TabIndex = 10;
            // 
            // user_sender_name
            // 
            this.user_sender_name.Location = new System.Drawing.Point(184, 51);
            this.user_sender_name.Name = "user_sender_name";
            this.user_sender_name.ReadOnly = true;
            this.user_sender_name.Size = new System.Drawing.Size(157, 20);
            this.user_sender_name.TabIndex = 11;
            // 
            // user_sender_lastname
            // 
            this.user_sender_lastname.Location = new System.Drawing.Point(185, 83);
            this.user_sender_lastname.Name = "user_sender_lastname";
            this.user_sender_lastname.ReadOnly = true;
            this.user_sender_lastname.Size = new System.Drawing.Size(156, 20);
            this.user_sender_lastname.TabIndex = 12;
            // 
            // user_sender_secondname
            // 
            this.user_sender_secondname.Location = new System.Drawing.Point(185, 114);
            this.user_sender_secondname.Name = "user_sender_secondname";
            this.user_sender_secondname.ReadOnly = true;
            this.user_sender_secondname.Size = new System.Drawing.Size(156, 20);
            this.user_sender_secondname.TabIndex = 13;
            // 
            // sender_name
            // 
            this.sender_name.Location = new System.Drawing.Point(186, 149);
            this.sender_name.Name = "sender_name";
            this.sender_name.ReadOnly = true;
            this.sender_name.Size = new System.Drawing.Size(155, 20);
            this.sender_name.TabIndex = 14;
            // 
            // sender_position
            // 
            this.sender_position.Location = new System.Drawing.Point(186, 178);
            this.sender_position.Name = "sender_position";
            this.sender_position.ReadOnly = true;
            this.sender_position.Size = new System.Drawing.Size(155, 20);
            this.sender_position.TabIndex = 15;
            // 
            // sender_location
            // 
            this.sender_location.Location = new System.Drawing.Point(186, 206);
            this.sender_location.Name = "sender_location";
            this.sender_location.ReadOnly = true;
            this.sender_location.Size = new System.Drawing.Size(155, 20);
            this.sender_location.TabIndex = 16;
            // 
            // time_hours
            // 
            this.time_hours.Location = new System.Drawing.Point(186, 269);
            this.time_hours.Name = "time_hours";
            this.time_hours.Size = new System.Drawing.Size(155, 20);
            this.time_hours.TabIndex = 17;
            // 
            // complexity
            // 
            this.complexity.Location = new System.Drawing.Point(187, 299);
            this.complexity.Name = "complexity";
            this.complexity.Size = new System.Drawing.Size(154, 20);
            this.complexity.TabIndex = 18;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Принята",
            "В работе",
            "Отклонена",
            "Выполнена",
            "Новый"});
            this.status.Location = new System.Drawing.Point(185, 238);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(156, 21);
            this.status.TabIndex = 19;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(140, 48);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(190, 83);
            this.description.TabIndex = 19;
            this.description.Text = "";
            // 
            // date_create
            // 
            this.date_create.Location = new System.Drawing.Point(140, 268);
            this.date_create.Name = "date_create";
            this.date_create.ReadOnly = true;
            this.date_create.Size = new System.Drawing.Size(190, 20);
            this.date_create.TabIndex = 20;
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(140, 299);
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.Size = new System.Drawing.Size(190, 20);
            this.date_start.TabIndex = 21;
            // 
            // date_update
            // 
            this.date_update.Location = new System.Drawing.Point(139, 332);
            this.date_update.Name = "date_update";
            this.date_update.ReadOnly = true;
            this.date_update.Size = new System.Drawing.Size(191, 20);
            this.date_update.TabIndex = 22;
            // 
            // date_deadline
            // 
            this.date_deadline.Location = new System.Drawing.Point(138, 362);
            this.date_deadline.Name = "date_deadline";
            this.date_deadline.ReadOnly = true;
            this.date_deadline.Size = new System.Drawing.Size(192, 20);
            this.date_deadline.TabIndex = 23;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 476);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderDetailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label serial_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox name2;
        public System.Windows.Forms.TextBox priority_name;
        public System.Windows.Forms.TextBox category_name;
        public System.Windows.Forms.TextBox serial_number;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.TextBox sender_location;
        public System.Windows.Forms.TextBox sender_position;
        public System.Windows.Forms.TextBox sender_name;
        public System.Windows.Forms.TextBox user_sender_secondname;
        public System.Windows.Forms.TextBox user_sender_lastname;
        public System.Windows.Forms.TextBox user_sender_name;
        public System.Windows.Forms.TextBox user_sender_login;
        public System.Windows.Forms.ComboBox status;
        public System.Windows.Forms.TextBox complexity;
        public System.Windows.Forms.TextBox time_hours;
        public System.Windows.Forms.RichTextBox description;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.TextBox date_deadline;
        public System.Windows.Forms.TextBox date_update;
        public System.Windows.Forms.TextBox date_start;
        public System.Windows.Forms.TextBox date_create;
    }
}