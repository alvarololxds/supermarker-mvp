using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using Supermarket.mvp.Models;
using System.Reflection.Metadata.Ecma335;

namespace Supermarket.mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository

    {
        public PayModeRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();

        }
        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PayModeModel> GetAll()
        {
            var payModeList=new List<PayModeModel>();
            using(var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection=connection;
                command.CommandText = "Select * From PayMode ORDER BY Pay_Mode_Id Desc";
                using(var reader = command.ExecuteReader())
                {
                    var payModeModel = new PayModeModel
                    {
                        Id = (int)reader["Pay_Mode_Id"],
                        Name = reader["Pay_Mode_Name"].ToString(),
                        Observations = reader["Pay_Mode_Observation"].ToString()
                    };
                    payModeList.Add(payModeModel);
                }
                
            }
            return payModeList;
        }
        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList=new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;
            using (var connection=new SqlConnection(connectionString))
            using (var command=new SqlCommand())
            {
                connection.Open();
                command.Connection=connection;
                command.CommandText = @"SELECT * FROM PayMode Where Pay_Mode_Id=@id or Pay_Mode_Name Like @name+ '%' Order By Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value=payModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeName;
                using (var reader=command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel
                        {
                            Id = (int)reader["Pay_Mode_Id"],
                            Name = reader["Pay_Mode_Name"].ToString(),
                            Observations = reader["Pay_Mode_Observation"].ToString()
                        };
                        payModeList.Add(payModeModel) ;
                    }
                }
            }
            return payModeList;
        }
    }
}
