using ContactsTestTask.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsTestTask.Repository
{
    internal interface IRepository
    {
        Task<DataTable> GetContacts();
        void UpdateContact(Contact _contact);
        void InsertContact(Contact _contact);
        void DeleteContact(int id);
    }
}
