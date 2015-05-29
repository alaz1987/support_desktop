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
    public partial class OrderDetailForm : Form
    {
        public int id { get; set; }
        public int category_id { get; set; }

        public OrderDetailForm()
        {
            InitializeComponent();
            if (category_id != 1)
            {
                // нужно скрыть поля
                model.Visible = false;
                serial_number.Visible = false;
                model_label.Text = "";
                serial_label.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            bool flag2 = false;
            int time;
            int cp;

            // save order
            try
            {
                time = Int32.Parse(time_hours.Text);
                flag1 = true;
            }   catch
            {
                MessageBox.Show("Время должно быть числом!");
                flag1 = false;
            }

            if (flag1 == true)
            {
                try
                {
                    cp = Int32.Parse(complexity.Text);
                    if (cp < 1 || cp > 10)
                    {
                        MessageBox.Show("Сложность измеряется числом от 1 до 10!");
                        flag2 = false;
                    }
                    else
                    {
                        flag2 = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Сложность измеряется числом от 1 до 10!");
                    flag2 = false;
                }
            }

            if (flag1 == true && flag2 == true)
            {
                time = Int32.Parse(time_hours.Text);
                cp = Int32.Parse(complexity.Text);
                int stat = status.SelectedIndex;
                stat = stat + 1;
                string stat_real = "";
                switch (stat)
                {
                    case 1:
                        stat_real = "accept";
                        break;
                    case 2:
                        stat_real = "work";
                        break;
                    case 3:
                        stat_real = "cancel";
                        break;
                    case 4:
                        stat_real = "done";
                        break;
                    case 5:
                        stat_real = "new";
                        break;
                }
                string command = DBHelper.CallLocalDataBase("UPDATE Orders SET complexity='" + cp + "', time_hours='" + time + "', status_code='" + stat_real + "' WHERE id='"+id+"'", false);
                MessageBox.Show(command);
                
                string login = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
                string pass = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);

                RootObjectPutOrder order = new RootObjectPutOrder();
                order.id = id;
                order.login = login;
                order.password = pass;
                order.fields = new FieldsOrder();
                order.fields.complexity = cp.ToString();
                order.fields.status_code = stat_real;
                order.fields.time_hours = time.ToString();

                string json = JsonConvert.SerializeObject(order);

                string req = DBHelper.PutOrder(json);
                MessageBox.Show(req);
            }

            // close form
            //this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить эту заявку?", "Предупреждение", MessageBoxButtons.OKCancel);
            switch (res)
            {
                case DialogResult.OK:
                    {
                        string command = DBHelper.CallLocalDataBase("DELETE FROM Orders WHERE id='" + id + "'", false);
                        MessageBox.Show(command);
                        
                        string login = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
                        string pass = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);

                        RootObjectPutOrder order = new RootObjectPutOrder();
                        order.id = id;
                        order.login = login;
                        order.password = pass;

                        string json = JsonConvert.SerializeObject(order);

                        string req = DBHelper.DeleteOrder(json);
                        MessageBox.Show(req);

                        break;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }
            }
        }
    }
}
