using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Connection
    {
        public OracleConnection con;
        string STRconnect;
        string DbUser = "SELVA2024";
        string DbSifre = "MANAGER";

        public bool DB()
        {
            try
            {
                string dataSource = "TEKNO.WORLD";

                DbUser = "SELVA2024";
                DbSifre = "RAUFKERIM";
               // STRconnect = "Direct=True;Host=(DESCRIPTION =(ADDRESS =(PROTOCOL = TCP)(HOST = 10.200.1.21)(PORT = 1521))(CONNECT_DATA =(SID = ORCL)));User ID=SELVA2024;Password=RAUFKERIM;Character Set=WE8ISO8859P1;Connection Timeout=20000;Login Prompt=False";
                STRconnect = "DATA SOURCE=" + dataSource + ";PASSWORD=" + DbSifre + ";PERSIST SECURITY INFO=True;USER ID=" + DbUser + ";";

                con = new OracleConnection(STRconnect);
                con.Open();
                return true;
                
            }
            catch (Exception Exp)
            {
                return false;
            }
        }
    }
}


/*
using System.Data;

namespace WindowsFormsApp1
{
    public class Connection
    {
        public OracleConnection con;
        private string STRconnect;
        private string DbUser = "SYSTEM"; // Oracle kullanıcısı
        private string DbSifre = "MANAGER"; // Oracle şifresi

        public bool DB()
        {
            try
            {
                string dataSource = "XE"; // Veritabanı adı

                STRconnect = $"DATA SOURCE={dataSource};PASSWORD={DbSifre};PERSIST SECURITY INFO=True;USER ID={DbUser};Connection Timeout=120";
                con = new OracleConnection(STRconnect);
                con.Open(); // Bağlantıyı burada açıyoruz
                return true;
            }
            catch (OracleException ex)
            {
                // Oracle özel hata mesajını göster
                Console.WriteLine("Oracle hatası: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Genel hata mesajını göster
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }
    }
    
}
*/






