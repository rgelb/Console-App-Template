using ConsoleApp.Entities;
using ConsoleApp.Settings;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp.Data {
    public class TrioAccess : Database
    {
        public TrioAccess() {
            connectionString = App.ConnectionStrings.Trio;
        }

        /// <summary>
        /// Example of a single item query
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Listing GetById(int id) {
            string sql = $@"select Address, Latitude, Longitude
                            from Listing l (nolock)
                            where ListingID = @Id";

            using (IDbConnection db = new SqlConnection(connectionString)) {
                return db.Query<Listing>(sql, new { id }).SingleOrDefault();
            }
        }

        /// <summary>
        /// Example of a list query
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public List<Listing> Search(string address) {

            string sql = $@"select Address, Latitude, Longitude
                            from Listing l (nolock)
                            where Address = @Address";

            using (IDbConnection db = new SqlConnection(connectionString)) {
                return db.Query<Listing>(sql, new { Address = address }).ToList();
            }
        }
    }
}
