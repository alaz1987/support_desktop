using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// библиотеки для работы с базами данных
using System.Data.Sql;
using System.Data.SqlClient;
// для парсинга json
using Newtonsoft.Json;
using System.Web;
using System.IO;
using System.Net;

namespace SupportApp
{
    public class DatumGetOrders
    {
        public string id { get; set; }
        public string user_sender { get; set; }
        public string user_answer { get; set; }
        public string priority_id { get; set; }
        public string date_create { get; set; }
        public object date_finish { get; set; }
        public string date_update { get; set; }
        public string date_deadline { get; set; }
        public string date_start { get; set; }
        public string status_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category_id { get; set; }
        public object model { get; set; }
        public object serial_number { get; set; }
        public string sender_location { get; set; }
        public string sender_name { get; set; }
        public string sender_position { get; set; }
        public string time_hours { get; set; }
        public string complexity { get; set; }
        public string user_sender_login { get; set; }
        public string user_sender_name { get; set; }
        public string user_sender_lastname { get; set; }
        public string user_sender_secondname { get; set; }
        public string priority_name { get; set; }
        public string priority_code { get; set; }
        public string status_code { get; set; }
        public string status_name { get; set; }
        public string category_name { get; set; }
    }

    public class RootObjectDatumGetOrders
    {
        public bool result { get; set; }
        public bool error { get; set; }
        public List<DatumGetOrders> data { get; set; }
    }

    public class FieldsOrder
    {
        public string complexity { get; set; }
        public string time_hours { get; set; }
        public string status_code { get; set; }
    }

    public class RootObjectPutOrder
    {
        public int id { get; set; }
        public FieldsOrder fields { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }

    class DBHelper
    {
        /// <summary>
        /// Переменная с путем подключения к базе
        /// </summary>
        private static string StringConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\support.mdf;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Метод, в котором происходит обращение к локальной базе данных
        /// </summary>
        /// <remarks>
        /// Первое входящее значение - строка с запросом к базе данных,
        /// второе входящее значение - флаг, принимающий true или false. Если true, значит нужно вернуть результат, полученный от выполнения запроса, если false и нет ошибок, вернуть идентификатор "OK".
        /// </remarks>
        public static string CallLocalDataBase(string CommandToDB, bool Returned)
        {
            string ret = "";
            try
            {
                SqlConnection conn = new SqlConnection(StringConnect);
                conn.Open();

                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = CommandToDB;

                if (Returned == true)
                {
                    string request_string = Convert.ToString(myCommand.ExecuteScalar());
                    return request_string;
                }
                else
                {
                    int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                    if (UspeshnoeIzmenenie != 0)
                    {
                        ret = "Изменения внесены".ToString();
                    }
                    else
                    {
                        ret = "Не удалось внести изменения".ToString();
                    }

                }

                conn.Close();
                return ret;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        /// <summary>
        /// Метод, в котором происходит отправка запроса на получение данных о заказах
        /// </summary>
        public static RootObjectDatumGetOrders GetOrders()
        {
            string url = DBHelper.CallLocalDataBase("SELECT Url FROM Options", true);
            string port = DBHelper.CallLocalDataBase("SELECT Port FROM Options", true);
            string login = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
            string pass = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);

            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(@"" + url + "/api/orders/get?login=" + login + "&password=" + pass);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string orders_get = sr.ReadToEnd();
            RootObjectDatumGetOrders json = JsonConvert.DeserializeObject<RootObjectDatumGetOrders>(orders_get);

            return json;
        }

        /// <summary>
        /// Метод, который посылает запрос на изменения 
        /// </summary>
        public static string PutOrder(string json)
        {
            string url = DBHelper.CallLocalDataBase("SELECT Url FROM Options", true);
            string port = DBHelper.CallLocalDataBase("SELECT Port FROM Options", true);
            string login = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
            string pass = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);

            var baseAddress = url+"/api/order/update";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "PUT";

            string parsedContent = json;
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            try
            {
                RootObjectDatumGetOrders m = JsonConvert.DeserializeObject<RootObjectDatumGetOrders>(content);

                if (m.result == false)
                    return m.error.ToString();
                else
                    return "Данные на сайте успешно обновлены";
            } catch
            {
                return content;
            }
            

        }

        /// <summary>
        /// Метод, который посылает запрос на удаление
        /// </summary>
        public static string DeleteOrder(string json)
        {
            string url = DBHelper.CallLocalDataBase("SELECT Url FROM Options", true);
            string port = DBHelper.CallLocalDataBase("SELECT Port FROM Options", true);
            string login = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
            string pass = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);

            var baseAddress = url + "/api/order/delete";

            var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "DELETE";

            string parsedContent = json;
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(parsedContent);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            var content = sr.ReadToEnd();

            try
            {
                RootObjectDatumGetOrders m = JsonConvert.DeserializeObject<RootObjectDatumGetOrders>(content);

                if (m.result == false)
                    return m.error.ToString();
                else
                    return "Заявка успешно удалена";
            }
            catch
            {
                return content;
            }


        }

        /// <summary>
        /// Метод, в котором мы добавляем данные о заказах в базу данных
        /// </summary>
        public static string InsertToDBOrders(RootObjectDatumGetOrders orders, DataGridView table_with_order, Label new_order_label)
        {
            if (orders.result == true)
            {
                string answer = "";
                int news = 0;

                for (int i = 0; i < Int32.Parse(orders.data.Count.ToString()); i++)
                {
                    string id = orders.data[i].id;
                    string user_sender = orders.data[i].user_sender;
                    string user_answer = orders.data[i].user_answer;
                    string priority_id = orders.data[i].priority_id;
                    string date_create = "";
                    try
                    {
                        date_create = orders.data[i].date_create.ToString();
                    }
                    catch
                    {
                        date_create = "";
                    }
                    string date_finish = "";
                    try
                    {
                        date_finish = orders.data[i].date_finish.ToString();
                    }   catch
                    {
                        date_finish = "";
                    }
                    string date_update = "";
                    try
                    {
                        date_update = orders.data[i].date_update.ToString();
                    }
                    catch
                    {
                        date_update = "";
                    }
                    string date_deadline = "";
                    try
                    {
                        date_deadline = orders.data[i].date_deadline.ToString();
                    }
                    catch
                    {
                        date_deadline = "";
                    }
                    string date_start = "";
                    try
                    {
                        date_start = orders.data[i].date_start.ToString();
                    }
                    catch
                    {
                        date_start = "";
                    }
                    string status_id = orders.data[i].status_id;
                    string name = orders.data[i].name;
                    string description = orders.data[i].description;
                    string category_id = orders.data[i].category_id;
                    string model = "";
                    try
                    {
                        model = orders.data[i].model.ToString();
                    }
                    catch
                    {
                        model = "";
                    }
                    string serial_number = "";
                    try
                    {
                        serial_number = orders.data[i].serial_number.ToString();
                    }
                    catch
                    {
                        serial_number = "";
                    }
                    string sender_location = orders.data[i].sender_location;
                    string sender_name = orders.data[i].sender_name;
                    string sender_position = orders.data[i].sender_position;
                    string time_hours = orders.data[i].time_hours;
                    string complexity = orders.data[i].complexity;
                    string user_sender_login = orders.data[i].user_sender_login;
                    string user_sender_name = orders.data[i].user_sender_name;
                    string user_sender_lastname = orders.data[i].user_sender_lastname;
                    string user_sender_secondname = orders.data[i].user_sender_secondname;
                    string priority_name = orders.data[i].priority_name;
                    string priority_code = orders.data[i].priority_code;
                    string status_code = orders.data[i].status_code;
                    string status_name = orders.data[i].status_name;
                    string category_name = orders.data[i].category_name;

                    if (status_code == "new") news++;

                    string commandToDb = "INSERT INTO Orders (id, user_sender, user_answer, priority_id, date_create, date_finish, " +
                        "date_update, date_deadline, date_start, status_id, name, description, " +
                        "category_id, model, serial_number, sender_location, sender_name, sender_position, " +
                        "time_hours, complexity, user_sender_login, user_sender_name, user_sender_lastname, " +
                        "user_sender_secondname, priority_name, priority_code, status_code, status_name, " +
                        "category_name) VALUES (" +
                            "'" + id + "', " +
                            "'" + user_sender + "', " +
                            "'" + user_answer + "', " +
                            "'" + priority_id + "', ";
                     if (date_create != "" || date_create != null)
                         commandToDb += "'" + date_create + "', ";
                     else
                         commandToDb += "null, ";

                    /*if (date_finish != "" || date_finish != null)
                       commandToDb += "'" + date_finish + "', ";
                   else
                       commandToDb += "null, ";

                   if (date_update != "" || date_update != null)
                        commandToDb += "'" + date_update + "', ";
                    else
                        commandToDb += "null, ";

                    if (date_deadline != "" || date_deadline != null)
                        commandToDb += "'" + date_deadline + "', ";
                    else
                        commandToDb += "null, ";

                    if (date_start != "" || date_start != null)
                        commandToDb += "'" + date_start + "', ";
                    else
                        commandToDb += "null, ";*/

                    commandToDb += "null, null, null, null, ";

                    commandToDb += "'" + status_id + "', " +
                            "'" + name + "', " +
                            "'" + description + "', " +
                            "'" + category_id + "', " +
                            "'" + model + "', " +
                            "'" + serial_number + "', " +
                            "'" + sender_location + "', " +
                            "'" + sender_name + "', " +
                            "'" + sender_position + "', " +
                            "'" + time_hours + "', " +
                            "'" + complexity + "', " +
                            "'" + user_sender_login + "', " +
                            "'" + user_sender_name + "', " +
                            "'" + user_sender_lastname + "', " +
                            "'" + user_sender_secondname + "', " +
                            "'" + priority_name + "', " +
                            "'" + priority_code + "', " +
                            "'" + status_code + "', " +
                            "'" + status_name + "', " +
                            "'" + category_name + "' " +
                        ");";

                    answer = DBHelper.CallLocalDataBase(commandToDb, false);
                }

                new_order_label.Text = news.ToString();

                //Создаем экземпляр FullDataTable, в который будут помещаться данные
                DataTable FullDataTable = new DataTable();
                //Создаем экземпляр FullDataTable для получения структуры таблицы из базы данных
                DataTable ShemaDataTable = new DataTable();
                SqlDataReader dataReader;
                //Создаем объект objectRow для получения информации о числе столбцов
                object[] objectRow;
                //Создаем объект myDataRow для помещения записей
                DataRow myDataRow;

                try
                {
                    SqlConnection connect = new SqlConnection(StringConnect);
                    connect.Open();
                    SqlCommand Command = connect.CreateCommand();
                    Command.CommandText = "SELECT * FROM Orders";
                    dataReader = Command.ExecuteReader();
                    //Вызываем метод GetSchemaTable, который получает схему таблицы из базы
                    //и передает ее объекту ShemaDataTable
                    ShemaDataTable = dataReader.GetSchemaTable();
                    //Свойство FieldCount возвращает число столбцов для текущей записей.
                    //Передаем это значение объекту objectRow
                    objectRow = new object[dataReader.FieldCount];
                    //Определяем структуру объекта FullDataTable
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        FullDataTable.Columns.Add(ShemaDataTable.Rows[i]["ColumnName"].ToString(),
                        ((System.Type)ShemaDataTable.Rows[i]["DataType"]));
                    }
                    //Добавляем записи в объект FullDataTable
                    while (dataReader.Read())
                    {
                        dataReader.GetValues(objectRow);
                        myDataRow = FullDataTable.Rows.Add(objectRow);
                    }
                    //Определяем источник данных для элемента dataGrid1
                    table_with_order.DataSource = FullDataTable;
                    dataReader.Close();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return answer;
            }else
            {
                return "Error";
            }
        }
    }
}
