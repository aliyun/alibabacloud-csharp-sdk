// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSqlStatementContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the SQL execution result.</para>
        /// </summary>
        [NameInMap("sqlStatementContents")]
        [Validation(Required=false)]
        public ListSqlStatementContentsResponseBodySqlStatementContents SqlStatementContents { get; set; }
        public class ListSqlStatementContentsResponseBodySqlStatementContents : TeaModel {
            /// <summary>
            /// <para>A list of the SQL execution results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;values\&quot;:[\&quot;wj*****\&quot;,\&quot;test\&quot;,\&quot;2025-04-15\&quot;]}]</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public string Contents { get; set; }

            /// <summary>
            /// <para>The maximum number of records returned for a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that specifies the position from which to start reading the results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of rows in the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
