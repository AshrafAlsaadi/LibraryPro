using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryPro.Logic.Services
{
    class CategoryService
    {
        public static bool categoryInsert(int id,string name)
        {
            return DBHelper.executeData("categoryInsert",()=>categoryParameterInsert(id,name, DBHelper.command));
            
        }
        //to add insert parameter to storeProcedure
        private static void categoryParameterInsert(int Id,string Name,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
        }
       
        public static bool categoryDelete(int id)
        {
            return DBHelper.executeData("categoryDelete", () => categoryParameterDelete(id,  DBHelper.command));
            
        }
        //to add delete parameter to storeProcedure
        private static void categoryParameterDelete(int Id,  SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
           
        }
        public static bool categoryUpdate(int id, string name)
        {
            return DBHelper.executeData("categoryUpdate", () => categoryParameterUpdate(id, name, DBHelper.command));
           
        }
        //to add update parameter to storeProcedure
        private static void categoryParameterUpdate(int Id, string Name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
        }
    }
}
