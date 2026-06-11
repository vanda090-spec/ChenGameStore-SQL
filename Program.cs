using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace StoreDB
{  
    internal class Program
    {
        public static string MyDataBaseConnection = "server=localhost\\SQLEXPRESS;";
        public static void CreateDB()
        {
            try
            {
                SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection +"Integrated Security=SSPI;");
                SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                mysqlCommand.CommandText = "create database ChenGameStore";
                mysqlConnection.Open();
                int message = mysqlCommand.ExecuteNonQuery();
                Console.WriteLine(message + " row affected");
                mysqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DropDB()
        {
            try
            {
                SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "Integrated Security=SSPI;");
                SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                mysqlCommand.CommandText = "drop database ChenGameStore;";
                mysqlConnection.Open();
                int message = mysqlCommand.ExecuteNonQuery();
                Console.WriteLine(message + " row affected");
                mysqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CreateTable()
        {
            try
            {
                
                   
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection+"database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "create table Games" +
                                "(GameID int primary key," +
                                "GameName nvarchar(100) not null," +
                                "GamePrice float," +
                                "GameCategory nvarchar(100)," +
                                "GameDateAdded date default getdate() );";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                            
                        }
                   
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "create table Workers" +
                                "(WorkerID int primary key," +
                                "WorkerName nvarchar(100) not null," +
                                "WorkerRole nvarchar(100)," +
                                "WorkerSalary float)";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                           
                        }

                {
                    SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                    SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                    mysqlCommand.CommandText = "create table Orders" +
                        "(OrderID int primary key," +
                        "GameID int ," +
                        "OrderCount int, " +
                        "OrderDate date default getdate() ," +
                        "WorkerID int ," +
                        "constraint FK_Orders_Games " +
                        "foreign key (GameID) " +
                        "references Games(GameID) ," +
                        "constraint FK_Orders_Workers " +
                        "foreign key (WorkerID) " +
                        "references Workers(WorkerID));";
                    mysqlConnection.Open();
                    int message = mysqlCommand.ExecuteNonQuery();
                    Console.WriteLine(message + " row affected");
                    mysqlConnection.Close();

                }  
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DropTable(int num)
        {
            
            switch (num)
            {
                case 1:

                    try
                    {

                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlConnection.Open();
                        mysqlCommand.CommandText = "drop table Orders";
                        int message = mysqlCommand.ExecuteNonQuery();
                        Console.WriteLine(message + " row affected");
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:

                    try
                    {

                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlConnection.Open();
                        mysqlCommand.CommandText = "drop table Workers";
                        int message = mysqlCommand.ExecuteNonQuery();
                        Console.WriteLine(message + " row affected");
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:

                    try
                    {

                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlConnection.Open();
                        mysqlCommand.CommandText = "drop table Games";
                        int message = mysqlCommand.ExecuteNonQuery();
                        Console.WriteLine(message + " row affected");
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Back to menu...");
                        break;
                    }
            }
        }
        public static void InsertIntoTable(int num)
        {
           
                try
                {
                    SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                    SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                    mysqlCommand.CommandText = "insert into Games (GameID,GameName,GamePrice,GameCategory) " +
                        "values" +
                        "(11,'The Isle',73.95,'Survival')," +
                        "(12,'SCUM',67.98,'Survival')," +
                        "(13,'Rust',145.00,'Survival')," +
                        "(21,'Battlefield',299.00,'Action')," +
                        "(22,'Squad',189.95,'Action')," +
                        "(23,'Arma 3',284.95,'Action')," +
                        "(31,'Guild Wars',73.99,'MMORPG')," +
                        "(32,'V Rising',131.95,'MMORPG')," +
                        "(33,'Diablo IV',201.00,'MMORPG');";
                    mysqlConnection.Open();
                    int message = mysqlCommand.ExecuteNonQuery();
                    Console.WriteLine(message + " row affected");
                    mysqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                    SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                    mysqlCommand.CommandText = "insert into Workers values" +
                        "(1,'Ella','Store manager',18000)," +
                        "(2,'Gabriel','Manager',15000)," +
                        "(3,'Dana','Cashier',11000)," +
                        "(4,'Tali','Cashier',11000)," +
                        "(5,'Avi','Seller',12000)," +
                        "(6,'Mishel','Seller',12000);";
                    mysqlConnection.Open();
                    int message = mysqlCommand.ExecuteNonQuery();
                    Console.WriteLine(message + " row affected");
                    mysqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                try
                {
                    SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                    SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                    mysqlCommand.CommandText = "insert into Orders values" +
                        "\n(1001,11,2,'2025-01-03',1)," +
                        "\n(1002,12,4,'2025-01-03',1)," +
                        "\n(1003,13,5,'2025-01-03',1)," +
                        "\n(1004,21,4,'2025-12-08',1)," +
                        "\n(1005,22,6,'2025-12-08',1)," +
                        "\n(1006,23,10,'2025-12-08',1)," +
                        "\n(1007,31,3,'2025-04-03',1)," +
                        "\n(1008,32,2,'2025-04-03',1)," +
                        "\n(1009,33,6,'2025-04-03',1)," +
                        "\n(1111,11,2,'2025-05-17',2)," +
                        "\n(1112,12,5,'2025-05-17',2)," +
                        "\n(1113,13,7,'2025-05-17',2)," +
                        "\n(1114,21,9,'2025-05-06',2)," +
                        "\n(1115,22,8,'2025-05-06',2)," +
                        "\n(2221,23,10,'2025-05-06',2)," +
                        "\n(2222,31,5,'2025-07-09',2)," +
                        "\n(2223,32,4,'2025-07-09',2)," +
                        "\n(2224,33,3,'2025-07-09',2)," +
                        "\n(2225,11,16,'2025-08-20',3), " +
                        "\n(2226,12,15,'2025-08-20',3)," +
                        "\n(2227,13,11,'2025-08-20',3)," +
                        "\n(2228,21,11,'2025-07-19',3), " +
                        "\n(2229,22,12,'2025-07-19',3)," +
                        "\n(3331,23,16,'2025-07-19',3)," +
                        "\n(3332,31,17,'2025-12-30',3)," +
                        "\n(3333,32,12,'2025-12-30',3), " +
                        "\n(3334,33,14,'2025-12-30',3)," +
                        "\n(3335,11,15,'2025-06-09',4)," +
                        "\n(3336,12,14,'2025-06-09',4)," +
                        "\n(3337,13,12,'2025-06-09',4)," +
                        "\n(3338,21,13,'2025-02-10',4)," +
                        "\n(3339,22,18,'2025-02-10',4)," +
                        "\n(4441,23,19,'2025-02-10',4)," +
                        "\n(4442,31,17,'2025-03-11',4)," +
                        "\n(4443,32,16,'2025-03-11',4)," +
                        "\n(4445,33,12,'2025-03-11',4)," +
                        "\n(4446,11,40,'2025-06-18',5)," +
                        "\n(4447,12,32,'2025-06-18',5)," +
                        "\n(4448,13,50,'2025-06-18',5)," +
                        "\n(4449,21,45,'2025-06-18',5)," +
                        "\n(5551,22,35,'2025-04-21',5)," +
                        "\n(5552,23,27,'2025-04-21',5)," +
                        "\n(5553,31,49,'2025-01-30',5)," +
                        "\n(5554,32,55,'2025-01-30',5)," +
                        "\n(5555,33,36,'2025-01-30',5), " +
                        "\n(5556,11,63,'2025-03-19',6)," +
                        "\n(5557,12,76,'2025-03-19',6)," +
                        "\n(5558,13,85,'2025-03-19',6), " +
                        "\n(6661,21,49,'2025-05-25',6)," +
                        "\n(6662,22,55,'2025-05-25',6)," +
                        "\n(6663,23,32,'2025-05-25',6)," +
                        "\n(6664,31,15,'2025-06-16',6), " +
                        "\n(6665,32,10,'2025-06-16',6)," +
                        "\n(6666,33,5,'2025-06-16',6);" +
                        "\n";
                    mysqlConnection.Open();
                    int message = mysqlCommand.ExecuteNonQuery();
                    Console.WriteLine(message + " row affected");
                    mysqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            if (num == 1)
            {
                Console.WriteLine("Back to menu...");
            }
        }   
        public static void DeleteContentByID(int num)
        {
            switch (num)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter Game ID:");
                        int id = int.Parse(Console.ReadLine());
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "delete from Games where GameID="+id+"";
                        mysqlConnection.Open();
                        int message = mysqlCommand.ExecuteNonQuery();
                        Console.WriteLine(message + " row affected");
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            
            case 2:
                try
                {
                        Console.WriteLine("Enter Worker ID:");
                        int id = int.Parse(Console.ReadLine());
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                    mysqlCommand.CommandText = "delete from Workers where WorkerID="+id+"";
                    mysqlConnection.Open();
                    int message = mysqlCommand.ExecuteNonQuery();
                    Console.WriteLine(message + " row affected");
                    mysqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;

                case 3:
                    try
                    {
                        Console.WriteLine("Enter Order ID:");
                        int id = int.Parse(Console.ReadLine());
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "delete from Orders where OrderID="+id+"";
                        mysqlConnection.Open();
                        int message = mysqlCommand.ExecuteNonQuery();
                        Console.WriteLine(message + " row affected");
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Back to menu...");
                        break;
                    }
            }
        }
        public static void ShowTablesByNumber(int num)
        {
            switch (num)
            {
                case 1:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select * from Games";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,-5}{1,-45}{2,-12:F}{3,-15} {4,-12}",
                            "ID", "Name", "Price(NIS)", "Category","Games Date");
                        Console.WriteLine("============================================================================================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,-5}{1,-45}{2,-12:F}{3,-15}{4,-12}",
                                mysqlDataReader["GameID"],
                                mysqlDataReader["GameName"],
                                mysqlDataReader["GamePrice"],
                                mysqlDataReader["GameCategory"],
                                ((DateTime)mysqlDataReader["GameDateAdded"]).ToString("yyyy-MM-dd"));
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select * from Workers";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,-6}{1,-15}{2,-20}{3,-12}",
                            "ID", "Name", "Role", "Salary(NIS)");
                        Console.WriteLine("=========================================================================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,-6}{1,-15}{2,-20}{3,-12}",
                                mysqlDataReader["WorkerID"],
                                mysqlDataReader["WorkerName"],
                                mysqlDataReader["WorkerRole"],
                                mysqlDataReader["WorkerSalary"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select * from Orders";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,-8}{1,-10}{2,-12}{3,-15}{4,-10}",
                            "OrderID","GameID","OrderCount","OrderDate","WorkerID");
                        Console.WriteLine("=========================================================================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,-8}{1,-10}{2,-12}{3,-15}{4,-10}",
                                mysqlDataReader["OrderID"],
                                mysqlDataReader["GameID"],
                                mysqlDataReader["OrderCount"],
                               ((DateTime)mysqlDataReader["OrderDate"]).ToString("yyyy-MM-dd"),
                                mysqlDataReader["WorkerID"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter year:");
                    string year = Console.ReadLine();
                    Console.WriteLine("Enter month:");
                    string month = Console.ReadLine();
                    Console.WriteLine("Enter day:");
                    string day = Console.ReadLine();
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select * from Orders where OrderDate='"+year+month+day+"';";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,-8}{1,-10}{2,-12}{3,-15}{4,-10}",
                            "OrderID", "GameID", "OrderCount", "OrderDate", "WorkerID");
                        Console.WriteLine("=========================================================================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,-8}{1,-10}{2,-12}{3,-15}{4,-10}",
                                mysqlDataReader["OrderID"],
                                mysqlDataReader["GameID"],
                                mysqlDataReader["OrderCount"],
                               ((DateTime)mysqlDataReader["OrderDate"]).ToString("yyyy-MM-dd"),
                                mysqlDataReader["WorkerID"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Back to menu...");
                        break;
                    }
            }  
        }
        public static void UpdateTableByID()
        {
            Console.WriteLine("Choose table to update:");
            Console.WriteLine("1.Games\n2.Workers\n3.Orders\n4.Back\nChoose: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("What do you want to update?\n" +
                        "1.Game Name\n" +
                        "2.Game Price\n" +
                        "3.Game Category\n" +
                        "4.Back");
                    int option1 = int.Parse(Console.ReadLine());
                    if (option1 == 1)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new game name:");
                        string str=Console.ReadLine();
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Games set GameName='"+str+"' where GameID="+id+"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option1 == 2)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new game price:");
                        float price = float.Parse(Console.ReadLine());
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Games set GamePrice=" +price+" where GameID="+id+"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option1 == 3)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new game category:");
                        string str = Console.ReadLine();
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Games set GameCategory='"+str+"' where GameID="+id+"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option1 == 4)
                    {
                        Console.WriteLine("Back to menu...");
                        return;
                    }
                    break;
                case 2:
                    Console.WriteLine("What do you want to update?\n" +
                        "1. Name\n" +
                        "2. Role\n" +
                        "3. Salary\n" +
                        "4.Back");
                    int option2 = int.Parse(Console.ReadLine());
                    if (option2 == 1)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new worker name:");
                        string str = Console.ReadLine();
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Workers set WorkerName='" + str + "' where WorkerID=" + id + "";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option2 == 2)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new worker role:");
                        string role = Console.ReadLine();
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Workers set WorkerRole='" + role + "' where WorkerID=" + id + "";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option2 == 3)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new worker salary:");
                        double newsalary = double.Parse(Console.ReadLine());
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Workers set WorkerSalary=" + newsalary+ " where WorkerID=" + id + "";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option2 == 4)
                    {
                        Console.WriteLine("Back to menu...");
                        return;
                    }
                    break;         
                case 3:
                    Console.WriteLine("What do you want to update?\n" +
                        "1.Game ID\n" +
                        "2.Order count\n" +
                        "3.Order date\n" +
                        "4.Worker ID\n" +
                        "5.Back");
                    int option3 = int.Parse(Console.ReadLine()); 
                    if (option3 == 1)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new game id:");
                        int gameID = int.Parse(Console.ReadLine());
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Orders set GameID=" +gameID+" where OrderID=" +id+ "";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option3 == 2)
                    {
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new order count:");
                        int ordersCount = int.Parse(Console.ReadLine());
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Orders set OrderCount="+ordersCount+" where OrderID=" +id+"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option3 == 3)
                    {

                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new year\nEnter new month\nEnter new day:");
                        int year = int.Parse(Console.ReadLine()); int month = int.Parse(Console.ReadLine()); int day = int.Parse(Console.ReadLine());
                        DateTime orderDate = new DateTime(year,month,day);
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Orders set OrderDate='" +orderDate.ToString("yyyy-MM-dd")+ "' where OrderID=" +id +"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option3 == 4)
                    {

                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine()); 
                        Console.WriteLine("Enter new worker id:");
                        int workerID = int.Parse(Console.ReadLine());
                        try
                        {
                            SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                            SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                            mysqlCommand.CommandText = "update Orders set WorkerID=" +workerID+" where OrderID=" +id +"";
                            mysqlConnection.Open();
                            int message = mysqlCommand.ExecuteNonQuery();
                            Console.WriteLine(message + " row affected");
                            mysqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (option3 == 5)
                    {
                        Console.WriteLine("Back to menu...");
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("Back to menu...");
                    break;
            }
        }
        public static void JoinTables()
        {
            try
            {
                SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                mysqlCommand.CommandText = "select" +
                    "\nOrders.OrderID," +
                    "\nOrders.OrderDate," +
                    "\nWorkers.WorkerName," +
                    "\nGames.GameName" +
                    "\nfrom Orders" +
                    "\ninner join Workers on Orders.WorkerID=Workers.WorkerID" +
                    "\ninner join Games on Orders.GameID=Games.GameID";
                mysqlConnection.Open();
                SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                Console.WriteLine("{0,-8}{1,-12}{2,-12}{3,-15}",
                        "OrderID", "OrderDate", "WorkerName", "GameName");
                Console.WriteLine("==========================================");
                while (mysqlDataReader.Read())
                {
                    Console.WriteLine("{0,-8}{1,-12}{2,-12}{3,-15}",
                               mysqlDataReader["OrderID"],
                               ((DateTime)mysqlDataReader["OrderDate"]).ToString("yyyy-MM-dd"),
                               mysqlDataReader["WorkerName"],
                               mysqlDataReader["GameName"]);
                } 
                mysqlDataReader.Close();
                mysqlConnection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CountOrders(int num) 
        {
            switch (num)
            {
                case 1:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select Games.GameName, sum(Orders.OrderCount) as TotalOfOrders" +
                            "\nfrom Orders" +
                            "\ninner join Games" +
                            "\non Orders.GameID = Games.GameID" +
                            "\ngroup by Games.GameName";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,11}\t{1,11}",
                       "GameName", "TotalOfOrders");
                        Console.WriteLine("==============================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,11}\t{1,11}",
                                       mysqlDataReader["GameName"],
                                       mysqlDataReader["TotalOfOrders"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select Games.GameName, max(Orders.OrderCount) as MaxOfOrders" +
                            "\nfrom Orders" +
                            "\ninner join Games" +
                            "\non Orders.GameID = Games.GameID" +
                            "\ngroup by Games.GameName";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,11}\t{1,11}",
                       "GameName", "MaxOfOrders");
                        Console.WriteLine("==============================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,11}\t{1,11}",
                                       mysqlDataReader["GameName"],
                                       mysqlDataReader["MaxOfOrders"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select Games.GameName, min(Orders.OrderCount) as MinOfOrders" +
                            "\nfrom Orders" +
                            "\ninner join Games" +
                            "\non Orders.GameID = Games.GameID" +
                            "\ngroup BY Games.GameName";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,11}\t{1,11}",
                       "GameName"," MinOfOrders");
                        Console.WriteLine("==============================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,11}\t{1,11}",
                                       mysqlDataReader["GameName"],
                                       mysqlDataReader["MinOfOrders"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        SqlConnection mysqlConnection = new SqlConnection(MyDataBaseConnection + "database=ChenGameStore;Integrated Security=SSPI;");
                        SqlCommand mysqlCommand = mysqlConnection.CreateCommand();
                        mysqlCommand.CommandText = "select " +
                            "Workers." +
                            "WorkerID," +
                            "Workers.WorkerName," +
                            "sum(Orders.OrderCount) as TotalofSales" +
                            "\nfrom Orders"+
                            "\ninner join Workers on Orders.WorkerID=Workers.WorkerID"+
                            "\ngroup by Workers.WorkerID,WorkerName" +
                            "\norder by TotalOfSales desc";
                        mysqlConnection.Open();
                        SqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                        Console.WriteLine("{0,-10}{1,-15}{2,-25}",
                        "WorkerID","WorkerName","TotalOfSales");
                        Console.WriteLine("=======================================");
                        while (mysqlDataReader.Read())
                        {
                            Console.WriteLine("{0,-10}{1,-15}{2,-25}",
                                       mysqlDataReader["WorkerID"],
                                       mysqlDataReader["WorkerName"],
                                       mysqlDataReader["TotalOfSales"]);
                        }
                        mysqlDataReader.Close();
                        mysqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                  break;
                case 5:
                    return;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("1.Create ChenGameStore DB: ");
                Console.WriteLine("2.Drop ChenGameStore DB: ");
                Console.WriteLine("3.Create Table: ");
                Console.WriteLine("4.Drop Table: ");
                Console.WriteLine("5.Delete Table content by id: (Optional)");
                Console.WriteLine("6.Show Tables: ");
                Console.WriteLine("7.Insert Table options: ");
                Console.WriteLine("8.Update Table options: ");
                Console.WriteLine("10.Join Tables:");
                Console.WriteLine("11.Count Orders:");
                Console.WriteLine("12.Exit");
                Console.WriteLine("==============================================");
                Console.Write("Choose option: ");
                int options = int.Parse(Console.ReadLine());
                if(options<1 || options >12)
                {

                    continue;
                }
                switch (options)
                {
                    case 1:

                        CreateDB();
                        break;
                    case 2:
                        DropDB();
                        break;
                    case 3:
                        CreateTable();
                        break;
                    case 4:
                        Console.WriteLine("Drop By Order:\n" +
                            "1.Orders\n" +
                            "2.Workers\n" +
                            "3.Games\n" +
                            "4.Back");
                        DropTable(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("1.Games\n2.Workers\n3.Orders\n4.Back\nChoose: "); 
                        DeleteContentByID(int.Parse(Console.ReadLine()));
                        break;
                    case 6:
                        Console.WriteLine("1.Games\n2.Workers\n3.Orders\n4.Orders by date\n5.Back\nChoose: "); 
                        ShowTablesByNumber(int.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        Console.WriteLine("1.Back to menu option");
                        InsertIntoTable(int.Parse(Console.ReadLine()));
                        break;
                    case 8:
                        UpdateTableByID();
                        break;
                    case 10:
                        JoinTables();
                        break;
                    case 11:
                        Console.WriteLine("1.Total orders \n2.Max orders\n3.Minimun orders\n4.Total worker sales\n5.Back\nChoose: ");
                        CountOrders(int.Parse(Console.ReadLine()));
                        break;
                    case 12: Console.WriteLine("Good Bye!"); 
                        return;
                }
                Console.WriteLine("press any key..");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
