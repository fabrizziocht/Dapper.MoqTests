﻿namespace Dapper.MoqTests
{
    using System.Data;

    internal class MockDbParameter : IDbDataParameter
    {
        public DbType DbType { get; set; }
        public ParameterDirection Direction { get; set; }
        // ReSharper disable UnusedAutoPropertyAccessor.Global
        public bool IsNullable { get; set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Global
        public string ParameterName { get; set; }
        public string SourceColumn { get; set; }
        public DataRowVersion SourceVersion { get; set; }
        public object Value { get; set; }
        public byte Precision { get; set; }
        public byte Scale { get; set; }
        public int Size { get; set; }
    }
}