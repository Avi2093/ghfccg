using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    namespace ApiRestfulExample.Data
    {
        public class RestAPIDbContext : DbContext
        {
            public RestAPIDbContext(DbContextOptions<RestAPIDbContext> options)
                : base(options)
            {
            }

            public DbSet<ApiData> ApiData { get; set; }
        }

        public class ApiData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }


