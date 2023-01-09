using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Notes.Controllers
{
    public class ApiNotController : Controller
    {
        List<Not> nots = new List<Not>

{
            new() { Title = "Tom", Content = "hgfhjhfkjg", Token_id = "1234567890"},
            new() { Title = "Bob", Content = "Bom", Token_id = "Tobik" },
            new() { Title = "Sam", Content = "Sam", Token_id = "Sam" },
            new() { Title = "Tom", Content = "Tom", Token_id = "Tom" },
        };

        [HttpGet]
        public IEnumerable<Not> GetNot()
        {
            IEnumerable<Not> nots = null;
            using (IDbConnection db = new SqlConnection("Data Source = (localdb)/MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                nots = db.GetAll<Not>();
            }
            return nots;
        }
        [HttpGet("{apiNotId}")]
        public Not? GetNotById(int id)
        {
            Not? not = null;
            using (IDbConnection db = new SqlConnection("Data Source = (localdb)/MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                not = db.Get<Not>(id);
            }
            return not;

        }


    }
}

