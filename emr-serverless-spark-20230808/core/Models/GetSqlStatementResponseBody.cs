// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetSqlStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSqlStatementResponseBodyData Data { get; set; }
        public class GetSqlStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of time that is consumed by SQL queries.</para>
            /// </summary>
            [NameInMap("executionTime")]
            [Validation(Required=false)]
            public List<long?> ExecutionTime { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ERROR-102</para>
            /// </summary>
            [NameInMap("sqlErrorCode")]
            [Validation(Required=false)]
            public string SqlErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error message</para>
            /// </summary>
            [NameInMap("sqlErrorMessage")]
            [Validation(Required=false)]
            public string SqlErrorMessage { get; set; }

            /// <summary>
            /// <para>The query results.</para>
            /// </summary>
            [NameInMap("sqlOutputs")]
            [Validation(Required=false)]
            public List<GetSqlStatementResponseBodyDataSqlOutputs> SqlOutputs { get; set; }
            public class GetSqlStatementResponseBodyDataSqlOutputs : TeaModel {
                /// <summary>
                /// <para>The queried data, which is a string in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;values\&quot;:[\&quot;test_db\&quot;,\&quot;test_table\&quot;,false]}</para>
                /// </summary>
                [NameInMap("rows")]
                [Validation(Required=false)]
                public string Rows { get; set; }

                /// <summary>
                /// <para>The information about the schema, which is a string in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;struct\&quot;,\&quot;fields\&quot;:[{\&quot;name\&quot;:\&quot;namespace\&quot;,\&quot;type\&quot;:\&quot;string\&quot;,\&quot;nullable\&quot;:false,\&quot;metadata\&quot;:{}},{\&quot;name\&quot;:\&quot;tableName\&quot;,\&quot;type\&quot;:\&quot;string\&quot;,\&quot;nullable\&quot;:false,\&quot;metadata\&quot;:{}},{\&quot;name\&quot;:\&quot;isTemporary\&quot;,\&quot;type\&quot;:\&quot;boolean\&quot;,\&quot;nullable\&quot;:false,\&quot;metadata\&quot;:{}}]}</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>The query status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running</description></item>
            /// <item><description>available</description></item>
            /// <item><description>cancelled</description></item>
            /// <item><description>error</description></item>
            /// <item><description>cancelling</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>st-1231311abadfaa</para>
            /// </summary>
            [NameInMap("statementId")]
            [Validation(Required=false)]
            public string StatementId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
