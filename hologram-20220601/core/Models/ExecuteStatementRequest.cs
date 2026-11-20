// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementRequest : TeaModel {
        /// <summary>
        /// <para>The database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The maximum amount of data to return in a single request, in bytes. Default value: 10485760 (10 MB). Excess data is truncated and indicated by setting truncated to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("maxBytes")]
        [Validation(Required=false)]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// <para>The maximum number of rows to return. Default value: 200. Maximum value: 1000. Excess rows are truncated and indicated by the Truncated field in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("maxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        /// <summary>
        /// <para>The list of parameters to attach to the SQL parameterized query, which correspond in sequence to placeholders such as $1 and $2 in the SQL statement. Supported value types include String, Long, Double, Boolean, and null, which represents NULL. Using a parameterized query effectively prevents SQL injection and improves the cache reuse rate of precompiled statements. The parameter list applies to each SQL statement in Statements.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// <para>The timeout period for SQL execution, in seconds. Default value: 30. Maximum value: 30. Minimum value: 1. If a timeout occurs, the server actively cancels the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("queryTimeout")]
        [Validation(Required=false)]
        public long? QueryTimeout { get; set; }

        /// <summary>
        /// <para>The SQL statement to be executed. The maximum length is 16,384 characters. Multiple SQL statements separated by semicolons are supported. If multiple statements are specified, the result of the last statement is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test_table limit 10;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
