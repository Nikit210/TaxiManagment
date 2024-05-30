using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagment
{
    public class SimpleRecord
    {
        public long id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name;
        }

    }

    public class User : SimpleRecord
    {
        public string password { get; set; }
        public bool admin { get; set; }
    }

    public class Car
    { 
        public string number { get; set; } 
        public string model  { get; set; }
        public string color { get; set; }
        public override string ToString()
        { 
        return $"{number} {model} ({color})";
        }
    }

    public class Driver : SimpleRecord
    { 
        public string phone { get; set; }
        public string telegram { get; set; }
        public string auto_number { get; set; }
    }
    public class DriverViewRecord
    {
        public long id { get; set; }
        public string driver_name { get; set; }
        public string driver_phone { get; set; }
        public string car { get; set; }
        public override string ToString()
        {
            return $"{driver_name} ({driver_phone}), {car}";
        }
    }
    public class Order
    { 
        public long id { get; set; }
        public long? iddriver { get; set; }
        public DateTime order_date { get; set; }
        public string place_from { get; set;}
        public string place_to { get; set;}
        public double price { get; set;}
        public int status { get; set;}
        public string client_phone { get; set;}
        public long iduser { get; set;}
    }

    public class OrderViewRecord
    {
        public long id { get; set; }
        public DateTime order_date { get; set; }
        public string client_phone { get; set; }
        public string place_from { get; set; }
        public string place_to { get; set; }
        public long? iddriver { get; set; }
        public string driver_name { get; set; }
        public string driver_phone { get; set; }
        public string car { get; set; }
        public double price { get; set; }
        public long iduser { get; set; }
        public string user_name { get; set; }
        public string status { get; set; }
    }

    public class Filter
    {
        public string client_phone { get; set; } = string.Empty;
        public string place_from { get; set; } = string.Empty;
        public string place_to { get; set; } = string.Empty;
        public string driver_name { get; set; } = string.Empty;
        public string status { get; set;} = string.Empty;
        public string responsible { get; set; } = string.Empty;
        /// <summary>
        /// Сбросить все фильтры
        /// </summary>
        public void Clear()
        {
            client_phone = string.Empty;
            place_from = string.Empty;
            place_to = string.Empty;
            driver_name = string.Empty;
            status = string.Empty;
            responsible = string.Empty;

    }
}
}
