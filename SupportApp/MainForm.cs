using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// для парсинга json
using Newtonsoft.Json;

namespace SupportApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm form = new AboutBoxForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamsForm form = new ParamsForm();
            form.ShowDialog();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                // получаем заказы
                RootObjectDatumGetOrders orders = DBHelper.GetOrders();
                order_label.Text = orders.data.Count.ToString();
                // добавляем заказы в бд
                DataGridView dv = table_with_order;
                Label lb = new_order_label;
                MessageBox.Show(DBHelper.InsertToDBOrders(orders, dv, lb));
            /*} catch
            {
                MessageBox.Show("Не удалось отправить запрос к удаленному серверу. Проверьте подключение к интернету.");
            }*/
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supportDataSet1.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter1.Fill(this.supportDataSet1.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supportDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.supportDataSet.Orders);

        }

        private void table_with_order_CellContentClickFunc(object sender)
        {
            
            try
            {
                // получаем заказы
                RootObjectDatumGetOrders orders = DBHelper.GetOrders();
                order_label.Text = orders.data.Count.ToString();

                int this_id = table_with_order.CurrentRow.Index; // строка по которой кликнули
                // заполняем ту форму в зависимости от того, какую строку выбрали
                OrderDetailForm od = new OrderDetailForm();
                od.Text = "Редактирование заявки " + orders.data[this_id].name;
                od.id = Int32.Parse(orders.data[this_id].id);
                od.name.Text = orders.data[this_id].name;
                od.name2.Text = orders.data[this_id].name;
                od.description.Text = orders.data[this_id].description;
                od.category_name.Text = orders.data[this_id].category_name;
                od.priority_name.Text = orders.data[this_id].priority_name;
                //od.model.Text = orders.data[this_id].model.ToString();
                //od.serial_number.Text = orders.data[this_id].serial_number.ToString();
                od.date_create.Text = orders.data[this_id].date_create.ToString();
                //od.date_start.Text = orders.data[this_id].date_start.ToString();
                //od.date_update.Text = orders.data[this_id].date_update.ToString();
                //od.date_deadline.Text = orders.data[this_id].date_deadline.ToString();
                od.user_sender_login.Text = orders.data[this_id].user_sender_login.ToString();
                od.user_sender_name.Text = orders.data[this_id].user_sender_name.ToString();
                od.user_sender_lastname.Text = orders.data[this_id].user_sender_lastname.ToString();
                od.user_sender_secondname.Text = orders.data[this_id].user_sender_secondname.ToString();
                od.sender_name.Text = orders.data[this_id].sender_name.ToString();
                od.sender_position.Text = orders.data[this_id].sender_position.ToString();
                od.sender_location.Text = orders.data[this_id].sender_location.ToString();
                od.status.Text = orders.data[this_id].status_name.ToString();
                od.time_hours.Text = orders.data[this_id].time_hours;
                od.complexity.Text = orders.data[this_id].complexity;
                var stat = Int32.Parse(orders.data[this_id].status_id) - 1;
                od.status.SelectedItem = stat;
                od.category_id = Int32.Parse(orders.data[this_id].category_id);
                od.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось отправить запрос к удаленному серверу. Проверьте подключение к интернету. "+ex);
            }
        }

        private void table_with_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table_with_order_CellContentClickFunc(sender);
        }

        private void redact_Click(object sender, EventArgs e)
        {
            table_with_order_CellContentClickFunc(sender);
        }
    }
}
