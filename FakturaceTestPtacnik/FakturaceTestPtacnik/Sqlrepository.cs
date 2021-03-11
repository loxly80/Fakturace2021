using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FakturaceTestPtacnik
{
    public class Sqlrepository
    {
        public string ConnectionString { get; set; }
        
        public Sqlrepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Zakaznik> NactiZakazniky(string sloupecTrideni, bool sestupne)
        {
            List<Zakaznik> zakaznici = new List<Zakaznik>();

            using(SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("",sqlConnection))
                {
                    sqlCommand.CommandText = $"select * from Zakaznici order by {sloupecTrideni}{(sestupne ? " desc" : "")}";
                    sqlConnection.Open();
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while(sqlDataReader.Read())
                        {
                            zakaznici.Add(new Zakaznik(Convert.ToInt32(sqlDataReader["IdZakaznika"]), Convert.ToString(sqlDataReader["Jmeno"]), Convert.ToString(sqlDataReader["TypZakaznika"]),
                                Convert.ToString(sqlDataReader["Adresa"]), Convert.ToInt32(sqlDataReader["ICO"]), Convert.ToString(sqlDataReader["Email"]), Convert.ToInt32(sqlDataReader["Telefon"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zakaznici;
        }

        public List<Zbozi> NactiZbozi()
        {
            List<Zbozi> zbozi = new List<Zbozi>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from Zbozi", sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zbozi.Add(new Zbozi(Convert.ToInt32(dataReader["IdZbozi"]), Convert.ToString(dataReader["Nazev"]), Convert.ToInt32(dataReader["CenaBezDPH"]),
                                Convert.ToString(dataReader["NaSklade"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zbozi;
        }

        public void PridatZbozi(Zbozi zbozi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = "insert into Zbozi (Nazev, CenaBezDPH, NaSklade) values (@Nazev, @CenaBezDPH, @NaSklade)";
                    sqlCommand.Parameters.AddWithValue("Nazev", zbozi.Nazev);
                    sqlCommand.Parameters.AddWithValue("CenaBezDPH", zbozi.CenaBezDPH);
                    sqlCommand.Parameters.AddWithValue("NaSklade", "ano");
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public void UpravitZbozi(Zbozi zbozi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"update Zbozi set Nazev=@Nazev, CenaBezDPH=@CenaBezDPH, NaSklade=@NaSklade where IdZbozi = {zbozi.Id}";
                    sqlCommand.Parameters.AddWithValue("Nazev", zbozi.Nazev);
                    sqlCommand.Parameters.AddWithValue("CenaBezDPH", zbozi.CenaBezDPH);
                    sqlCommand.Parameters.AddWithValue("NaSklade", zbozi.NaSklade);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public void SmazZbozi(Zbozi zbozi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"delete from Zbozi where IdZbozi={zbozi.Id}";
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public List<Zbozi> NactiZboziNaSklade()
        {
            List<Zbozi> zboziNaSklade = new List<Zbozi>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = "select * from Zbozi where NaSklade=@NaSklade";
                    sqlCommand.Parameters.AddWithValue("NaSklade", "ano");
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zboziNaSklade.Add(new Zbozi(Convert.ToInt32(dataReader["IdZbozi"]), Convert.ToString(dataReader["Nazev"]), Convert.ToInt32(dataReader["CenaBezDPH"]),
                                Convert.ToString(dataReader["NaSklade"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zboziNaSklade;
        }

        public void PridejZboziDoFaktury(Zakaznik zakaznik, Zbozi zbozi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand($"insert into Fakturace (IdZakaznika, IdZbozi, DatumFakturace) values ({zakaznik.Id}, {zbozi.Id}, getdate())", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public void VratZboziDoSkladu(Zakaznik zakaznik, Zbozi zbozi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand($"delete from Fakturace where IdZakaznika={zakaznik.Id} and IdZbozi={zbozi.Id}", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        public List<Zbozi> NactiZboziFaktury(Zakaznik zakaznik)
        {
            List<Zbozi> zboziFaktury = new List<Zbozi>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("", sqlConnection))
                {
                    sqlCommand.CommandText = $"select z.* from Fakturace f join Zbozi z on f.IdZbozi=z.IdZbozi join Zakaznici c on f.IdZakaznika=c.IdZakaznika where c.IdZakaznika={zakaznik.Id}";
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            zboziFaktury.Add(new Zbozi(Convert.ToInt32(dataReader["IdZbozi"]), Convert.ToString(dataReader["Nazev"]), Convert.ToInt32(dataReader["CenaBezDPH"]),
                                Convert.ToString(dataReader["NaSklade"])));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return zboziFaktury;
        }
    }
}
