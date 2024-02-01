using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ContactsTestTask.Models;
using System.Diagnostics.Contracts;

namespace ContactsTestTask.Repository
{
    internal class Repository : IRepository
    {
        private readonly SqlConnection _sqlConnection;
        public Repository(string connectionString) 
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }

        public async Task<DataTable> GetContacts()
        {
            using (SqlCommand cmd = new SqlCommand("GetContacts", _sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                var contactReader = await cmd.ExecuteReaderAsync();
                dt.Load(contactReader, LoadOption.Upsert);
                return dt;
            }
        }

        public void UpdateContact(Contact _contact)
        {
            using (SqlCommand cmd = new SqlCommand("UpdateContact", _sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContactID", _contact.Id);
                cmd.Parameters.AddWithValue("@FullName", _contact.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", _contact.PhoneNumber);
                cmd.Parameters.AddWithValue("@BirthDate", _contact.BirthDay);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertContact(Contact _contact)
        {
            using (SqlCommand cmd = new SqlCommand("AddContact", _sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", _contact.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", _contact.PhoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", _contact.BirthDay);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteContact(int id) 
        {
            using (SqlCommand cmd = new SqlCommand("DeleteContact", _sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContactID", id);
                cmd.ExecuteNonQuery();
            }
        }
        ~Repository() 
        {
            _sqlConnection.Close();
        }
    }
}
