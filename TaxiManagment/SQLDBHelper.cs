using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Collections;
using System.Xml.Linq;

namespace TaxiManagment
{
    internal class BaseDBHelper : IDisposable
    {
        protected SqlConnection conn;
        protected string _errorText;
        /// <summary>
        ///  открыта ли БД
        /// </summary>
        public bool isOpened { get { return conn.State == System.Data.ConnectionState.Open; } }
        /// <summary>
        /// текст ошибки, если ошибки нет - пустое значение
        /// </summary>
        public string errorText { get { return _errorText; } }

        /// <summary>
        /// установление соединения с БД непосредственно в конструкторе
        /// </summary>
        public BaseDBHelper()
        {
            _errorText = "";
            String connectionString = AppSettings.Default.ConnectionString;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }

        }
        /// <summary>
        /// закрытие соединения
        /// </summary>
        public void Dispose()
        {
            if (isOpened) conn.Close();
        }

    }
    internal class DBHelper : BaseDBHelper
    {
        public DBHelper() : base() { }

        /// <summary>
        /// Получить список пользователей, авторизованных в системе
        /// </summary>
        /// <returns>Список пользователей</returns>
        public async Task<List<User>> GetUsers()
        {
            List<User> lst = null;
            string sqlText = $"select id, name, password, admin from Users order by name";
            try
            {
                var t = await conn.QueryAsync<User>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }
        /// <summary>
        /// Получить список пользователей ИС
        /// </summary>
        /// <returns>Список пользователей</returns>
        public async Task<List<User>> GetUsersLists()
        {
            List<User> lst = null;
            string sqlText = "select id, name, password, admin from dbo.Users where id > 1 order by name";
            try
            {
                var t = await conn.QueryAsync<User>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }

        /// <summary>
        /// Добавить запись о пользователе
        /// </summary>
        /// <param name="usr">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddUser(User usr)
        {
            int recs = 0;
            string sqlText = "insert into dbo.Users (name, password, admin) values(@pname, @ppwd, @padmin)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = usr.name, ppwd = usr.password, padmin = usr.admin ? 1 : 0 });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о пользователе
        /// </summary>
        /// <param name="usr">даные для изменения записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateUser(User usr)
        {
            int recs = 0;
            string sqlText = "update dbo.Users set name = @pname, password = @ppwd, admin = @padmin where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = usr.id, pname = usr.name, ppwd = usr.password, padmin = usr.admin ? 1 : 0 });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Удалить запись о пользователе
        /// </summary>
        /// <param name="id">идентификатор записи пользователя</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteUser(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.Users where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о пользователе
        /// </summary>
        /// <param name="id">идентификатор записи пользователя</param>
        /// <param name="pwd">пароль пользователя</param>
        /// <returns>1 - если пароль изменён, иначе - 0</returns>
        public int UpdateUserPassword(long id, string pwd)
        {
            int recs = 0;
            string sqlText = "update dbo.Users set password = @ppwd where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id, ppwd = pwd});
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }


        /// <summary>
        /// Получить список транспортных средств, числящихся за водителями
        /// <param name="linked">выдать только прикреплённые к водителю ТС (true) или все ТС (false)</param>
        /// </summary>
        /// <returns>Список ТС</returns>
        public async Task<List<Car>> GetCarsLists(bool linked = false)
        {
            List<Car> lst = null;
            string sqlText = "select number, model, color from Cars";
            if (linked)
                sqlText += " where number in (select auto_number from dbo.Drivers)";
            sqlText += " order by number";
            try
            {
                var t = await conn.QueryAsync<Car>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;

        }
        /// <summary>
        /// Добавить запись о транспортном средстве
        /// </summary>
        /// <param name="car">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddCar(Car car)
        {
            int recs = 0;
            string sqlText = "insert into dbo.Cars (number, model, color) values(@pnum, @pmodel, @pcol)";
            try
            {
                recs = conn.Execute(sqlText, new { pnum = car.number, pmodel = car.model, pcol = car.color });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о транспортном средстве
        /// </summary>
        /// <param name="car">даные для изменения записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateCar(Car car, string old_num)
        {
            int recs = 0;
            string sqlText = "update dbo.Cars set number = @pnum, model = @pmodel, color = @pcol where number = @poldnum";
            try
            {
                recs = conn.Execute(sqlText, new { pnum = car.number, pmodel = car.model, pcol = car.color, poldnum = old_num });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Удалить запись о транспортном средстве
        /// </summary>
        /// <param name="num">гос. номер транспортного средства</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteCar(string num)
        {
            int recs = 0;
            string sqlText = "delete from dbo.Cars where number = @pnum";
            try
            {
                recs = conn.Execute(sqlText, new { pnum = num });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Получить список водителей
        /// </summary>
        /// <returns>Список водителей</returns>
        public async Task<List<Driver>> GetDriversLists()
        {
            List<Driver> lst = null;
            string sqlText = "select id, name, phone, telegram, auto_number from dbo.Drivers order by name";
            try
            {
                var t = await conn.QueryAsync<Driver>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Получить список свободных водителей
        /// </summary>
        /// <returns>Список свободных водителей</returns>
        public async Task<List<DriverViewRecord>> GetFreeDriversLists()
        {
            List<DriverViewRecord> lst = null;
            string sqlText = "select id, driver_name, driver_phone, car from dbo.free_drivers_view order by driver_name";
            try
            {
                var t = await conn.QueryAsync<DriverViewRecord>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }


        /// <summary>
        /// Добавить запись о водителе
        /// </summary>
        /// <param name="drv">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddDriver(Driver drv)
        {
            int recs = 0;
            string sqlText = "insert into dbo.Drivers (name, phone, telegram, auto_number) values(@pname , @pphone, @ptel, @pnum)";
            try
            {
                recs = conn.Execute(sqlText, new { pname = drv.name, pphone = drv.phone, ptel = drv.telegram, pnum = drv.auto_number });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о водителе
        /// </summary>
        /// <param name="drv">даные для изменения записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateDriver(Driver drv)
        {
            int recs = 0;
            string sqlText = "update dbo.Drivers set name = @pname, phone = @pphone, telegram = @ptel, auto_number = @pnum where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = drv.id, pname = drv.name, pphone = drv.phone, ptel = drv.telegram, pnum = drv.auto_number });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Удалить запись о водителе
        /// </summary>
        /// <param name="id">идентификатор записи о водителе</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteDriver(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.Drivers where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Выдать объект с информацией о водителе и его ТС по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор водителя</param>
        /// <returns>Объект, в случае выполнения запроса без ошибки, иначе null</returns>
        public DriverViewRecord GetDriverById(long id)
        {
            DriverViewRecord drv = null;
            string sqlText = "select id, driver_name, driver_phone, car from dbo.driver_view where id = @pid";
            try
            {
                drv = conn.QueryFirstOrDefault<DriverViewRecord>(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return drv;

        }

        /// <summary>
        /// Выдать объект с информацией по заказу по его идентификатору
        /// </summary>
        /// <param name="id">идентификатор заказа</param>
        /// <returns>Объект, в случае выполнения запроса без ошибки, иначе null</returns>
        public Order GetOrderById(long id)
        {
            Order ord = null;
            string sqlText = "select id, iddriver, order_date, place_from, place_to, price, status, client_phone, iduser from dbo.Orders where id = @pid";
            try
            {
                ord = conn.QueryFirstOrDefault<Order>(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return ord;
        }

        /// <summary>
        /// Получить список заказов
        /// </summary>
        /// <returns>Список закзов при успешом выполнении запроса, иначе null</returns>
        public async Task<List<OrderViewRecord>> GetOrdersLists(Filter flt = null)
        {
            List<OrderViewRecord> lst = null;
             string sqlText = "select id,order_date,client_phone, place_from,place_to,iddriver,driver_name,driver_phone,car,price,iduser, " +
                "user_name, status from dbo.orders_view where 1 = 1";
            if(flt != null)
            {
                if (!string.IsNullOrEmpty(flt.driver_name.Trim()))
                    sqlText += $" and driver_name like '%{flt.driver_name}%'";
                if (!string.IsNullOrEmpty(flt.client_phone.Trim()))
                    sqlText += $" and client_phone like '%{flt.client_phone}%'";
                if (!string.IsNullOrEmpty(flt.place_from.Trim()))
                    sqlText += $" and place_from like '%{flt.place_from}%'";
                if (!string.IsNullOrEmpty(flt.place_to.Trim()))
                    sqlText += $" and place_to like '%{flt.place_to}%'";
                if (!string.IsNullOrEmpty(flt.status.Trim()))
                    sqlText += $" and status like '%{flt.status}%'";
                if (!string.IsNullOrEmpty(flt.responsible.Trim()))
                    sqlText += $" and iduser in (select id from dbo.users where name like '%{flt.responsible}%')";

            }

            try
            {
                var t = await conn.QueryAsync<OrderViewRecord>(sqlText);
                lst = t.ToList();
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return lst;
        }

        /// <summary>
        /// Добавить запись о заказе
        /// </summary>
        /// <param name="ord">даные для добавления записи</param>
        /// <returns>1 - если запись добавлена, иначе - 0</returns>
        public int AddOrder(Order ord)
        {
            int recs = 0;
            string sdate = ord.order_date.ToString("yyyyMMdd HH:mm");
            string sqlText = "insert into dbo.Orders (iddriver,order_date,client_phone, place_from, place_to, price, status, iduser ) " + 
                $" values(@piddriver,'{sdate}', @pphone, @pfrom, @pto, @pprice, @pst, @piduser )";
            try
            {
                recs = conn.Execute(sqlText, 
                    new { piddriver = ord.iddriver, pphone = ord.client_phone, 
                        pfrom = ord.place_from, pto = ord.place_to, pprice = ord.price, pst = ord.status, piduser = ord.iduser });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Изменить запись о заказе
        /// </summary>
        /// <param name="ord">даные для изменения записи</param>
        /// <returns>1 - если запись изменена, иначе - 0</returns>
        public int UpdateOrder(Order ord)
        {
            int recs = 0;
            string sdate = ord.order_date.ToString("yyyyMMdd HH:mm");
            string sqlText = $"update dbo.Orders set iddriver = @piddriver,order_date = '{sdate}',client_phone = @pphone, " +
                " place_from = @pfrom, place_to = @pto, price = @pprice, status = @pst, iduser = @piduser where id = @pid";
            try
            {
                recs = conn.Execute(sqlText,
                    new
                    {
                        pid = ord.id,
                        piddriver = ord.iddriver,
                        pphone = ord.client_phone,
                        pfrom = ord.place_from,
                        pto = ord.place_to,
                        pprice = ord.price,
                        pst = ord.status,
                        piduser = ord.iduser
                    });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Удалить запись о заказе
        /// </summary>
        /// <param name="id">идентификатор записи о заказе</param>
        /// <returns>1 - если запись удалена, иначе - 0</returns>
        public int DeleteOrder(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.Orders where id = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }


        /// <summary>
        /// Зарезервировать водителя, исполнителя заказа
        /// </summary>
        /// <param name="id">идентификатор записи о водителе</param>
        /// <returns>1 - если водитель зарезервирован, иначе - 0</returns>
        public int ReserveDriver(long id)
        {
            int recs = 0;
            string sqlText = "insert into dbo.Reserved(iddriver) values(@pid)";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }

        /// <summary>
        /// Зарезервировать водителя, исполнителя заказа
        /// </summary>
        /// <param name="id">идентификатор записи о водителе</param>
        /// <returns>1 - если водитель зарезервирован, иначе - 0</returns>
        public int FreeDriver(long id)
        {
            int recs = 0;
            string sqlText = "delete from dbo.Reserved where iddriver = @pid";
            try
            {
                recs = conn.Execute(sqlText, new { pid = id });
            }
            catch (Exception ex)
            {
                _errorText = ex.Message;
            }
            return recs;
        }


    }
}
