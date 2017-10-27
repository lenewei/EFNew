using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Robin
{
   //I: assemblies
   //O: types in memory/files with generated DbContext
   public class Thor
   {
      public Thor()
      {
         const string QuantumAssembly = "Sungard.AvantGard.Quantum.External.*.dll";
         const string WorkingPath = @"C:\Projects\GitHub\EFNew\Robin\TestAssemblies";
         foreach (var file in Directory.GetFiles(WorkingPath, QuantumAssembly))
         {
            var assembly = Assembly.Load(file);
            foreach (var type in assembly.GetTypes())
            {
               //Generating a class file for each type
               var properties = type.GetProperties();
               var Methods = type.GetMethods();
               var members = type.GetMembers();
               var fields = type.GetFields();
               using (var strWriter = new StringWriter(WorkingPath))
               {
                  strWriter.WorkingPath
               }
            }            

         }
      }
   }

   //compile the project prepared by Thor and Loki, get sql in file
   public class Loki
   {

   }
}
