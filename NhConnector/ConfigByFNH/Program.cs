using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eg.Core;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Linq;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;

namespace ConfigByFNH
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe= new Recipe();
            recipe.LogEnabled = true;
            recipe.Run();
        //    log4net.Config.XmlConfigurator.Configure();

            //    var nhConfig = new Configuration().Configure();
            //    var mapper = new ConventionModelMapper();
            //    nhConfig.AddMapping(mapper.CompileMappingFor(new[] { typeof(TestClass) }));
            //    var schemaExport = new SchemaExport(nhConfig);
            //    schemaExport.Create(false, true);
            //    //var config = MsSqlConfiguration
            //    //    .MsSql2012
            //    //    .ConnectionString(connstr => connstr.FromConnectionStringWithKey("db"))
            //    //    .AdoNetBatchSize(100);

            //    //var nhConfig = Fluently.Configure()
            //    //    .Database(config).BuildConfiguration();
            //    //var sessionFactory = nhConfig.BuildSessionFactory();

            Console.WriteLine("NHibernate configured fluently!");
            Console.ReadKey();

        }
    }
}
