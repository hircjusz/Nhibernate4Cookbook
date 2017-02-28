using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eg.Core;
using NH4CookbookHelpers;
using NHibernate;
using NHibernate.Cfg;

namespace ConfigByFNH
{
    public class Recipe : BaseMappingRecipe
    {

        protected override void Configure(Configuration cfg)
        {
            cfg.AddAssembly(typeof(Product).Assembly);
        }
        protected override void AddInitialData(ISession session)
        {
            session.Save(new Product
            {
                Name = "Car",
                Description = "A nice red car",
                UnitPrice = 300
            });
        }
    }
}
