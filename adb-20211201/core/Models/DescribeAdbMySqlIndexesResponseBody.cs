// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdbMySqlIndexesResponseBody : TeaModel {
        /// <summary>
        /// <para>The filter condition for the number of indexes (the number of indexes currently owned by the table with missing indexes). The input format is <c>operator + separator &quot;&quot; + number of indexes</c>, such as <c>&gt;=100</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IndexCount")]
        [Validation(Required=false)]
        public int? IndexCount { get; set; }

        /// <summary>
        /// <para>The list of indexes.</para>
        /// </summary>
        [NameInMap("Indexes")]
        [Validation(Required=false)]
        public List<DescribeAdbMySqlIndexesResponseBodyIndexes> Indexes { get; set; }
        public class DescribeAdbMySqlIndexesResponseBodyIndexes : TeaModel {
            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preclcu</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// <para>The name of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ttl</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: The request is successful. </description></item>
        /// <item><description>Specific error message: returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0983B43-B2EC-536A-8791-142B5CF1E9B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the database.  </para>
        /// <remarks>
        /// <para><br>If this parameter is specified, subsequent migration or synchronization operations are performed only on this database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
