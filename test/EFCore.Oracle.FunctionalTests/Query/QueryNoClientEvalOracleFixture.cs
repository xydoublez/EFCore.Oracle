// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Query
{
    public class QueryNoClientEvalOracleFixture : NorthwindQueryOracleFixture
    {
        protected override DbContextOptionsBuilder ConfigureOptions(DbContextOptionsBuilder dbContextOptionsBuilder)
            => dbContextOptionsBuilder.ConfigureWarnings(c => c.Default(WarningBehavior.Throw));
    }
}
