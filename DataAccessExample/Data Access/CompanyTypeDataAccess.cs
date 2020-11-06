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
    public class CompanyTypeDataAccess
    {
        public CompanyType Save(CompanyType company_type)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_TYPE_SP_SAVE " +
                    $"{company_type.company_type_id}, " +
                    $"'{company_type.company_type_desc}', " +
                    $"{company_type.entered_by}, " +
                    $"'{company_type.entered_guid}', " +
                    $"{company_type.last_modified_by}, " +
                    $"'{company_type.last_modified_date}', " +
                    $"'{company_type.sysdate}', " +
                    $"{company_type.active_flag} ";

                return cnn.Query<CompanyType>(sql).FirstOrDefault(); ;
            }
        }

        public List<CompanyType> Retrieve()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_TYPE_SP_RETRIEVE 0 ";

                return cnn.Query<CompanyType>(sql).ToList();
            }
        }

        public CompanyType Retrieve(string company_type_id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_TYPE_SP_RETRIEVE " +
                    $"{company_type_id} ";

                return cnn.Query<CompanyType>(sql).FirstOrDefault();
            }
        }

        public void Delete(string company_type_id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = $"EXEC COMPANY_TYPE_SP_DELETE " +
                    $"{company_type_id} ";

                cnn.Execute(sql);
            }
        }
    }
}