﻿namespace VideoHouseGoldy79.Services.Data
{
    using System.Collections.Generic;

    public interface ISettingsService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
