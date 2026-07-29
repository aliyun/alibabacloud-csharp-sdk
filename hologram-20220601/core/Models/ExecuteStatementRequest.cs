// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The maximum size of the response, in bytes. Default: 10,485,760 (10 MB). If the response size exceeds this limit, it is truncated, as indicated by the Truncated field in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("maxBytes")]
        [Validation(Required=false)]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// <para>The maximum number of rows to return. Default: 200. Maximum: 1,000. If the result set exceeds this limit, it is truncated, as indicated by the <c>Truncated</c> field in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("maxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        /// <summary>
        /// <para>An array of bound parameters for a parameterized query. These parameters map sequentially to placeholders (e.g., <c>$1</c>, <c>$2</c>) in the SQL statement. Supported types include <c>String</c>, <c>Long</c>, <c>Double</c>, <c>Boolean</c>, and <c>null</c> (for SQL <c>NULL</c>). Using parameterized queries helps prevent SQL injection and improves the cache reuse rate for prepared statements. These parameters apply to all SQL statements in the sql field.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// <para>The query timeout, in seconds. Default: 30. Maximum: 30. Minimum: 1. If a query exceeds this time limit, the server cancels it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("queryTimeout")]
        [Validation(Required=false)]
        public long? QueryTimeout { get; set; }

        /// <summary>
        /// <para>The SQL statement to execute. The maximum length is 16,384 characters. You can specify multiple SQL statements separated by semicolons. If multiple statements are provided, the API returns the result of the last statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test_table limit 10;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
