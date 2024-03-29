﻿namespace VideoHouseGoldy79.Data
{
    using System;
    using System.Threading.Tasks;

    using VideoHouseGoldy79.Data.Common;

    using Microsoft.EntityFrameworkCore;

    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(VideoHouseGoldy79DbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public VideoHouseGoldy79DbContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
