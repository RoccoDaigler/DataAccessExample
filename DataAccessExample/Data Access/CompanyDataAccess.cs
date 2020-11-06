using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using DataAccessExample.Models;
using static DataAccessExample.Tools;

namespace DataAccessExample.Data_Access
{
    public class CompanyDataAccess
    {
        public Company Save(Company company)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_SP_SAVE " +
                    $"{company.company_id}, " +
                    $"'{company.company_name}', " +
                    $"'{company.bio_short}', " +
                    $"'{company.bio_long}', " +
                    $"'{company.address}', " +
                    $"'{company.city}', " +
                    $"'{company.state}', " +
                    $"'{company.zipcode}', " +
                    $"{company.company_type_id}, " +
                    $"{company.entered_by}, " +
                    $"'{company.entered_guid}', " +
                    $"{company.last_modified_by}, " +
                    $"'{company.last_modified_date}', " +
                    $"'{company.sysdate}', " +
                    $"{company.active_flag} ";

                return cnn.Query<Company>(sql).FirstOrDefault(); ;
            }
        }

        public List<Company> Retrieve()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_SP_RETRIEVE 0 ";

                return cnn.Query<Company>(sql).ToList();
            }
        }

        public Company Retrieve(string company_id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_SP_RETRIEVE " +
                    $"{company_id} ";

                return cnn.Query<Company>(sql).FirstOrDefault();
            }
        }

        public void Delete(string company_id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_SP_DELETE " +
                    $"{company_id} ";

                cnn.Execute(sql);
            }
        }
    }
}