using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Common;

namespace CodeFirstNewDatabaseSample
{
   class CommandInterceptor : IDbCommandInterceptor
   {
      void IDbCommandInterceptor.NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
      {
      }

      void IDbCommandInterceptor.NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
      {
         Console.WriteLine(command.CommandText);
         //interceptionContext.Result = 0;
      }

      void IDbCommandInterceptor.ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
      {
      }

      void IDbCommandInterceptor.ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
      {
         Console.WriteLine(command.CommandText);
      }

      void IDbCommandInterceptor.ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
      {
      }

      void IDbCommandInterceptor.ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
      {
         Console.WriteLine(command.CommandText);
      }
   }
}
