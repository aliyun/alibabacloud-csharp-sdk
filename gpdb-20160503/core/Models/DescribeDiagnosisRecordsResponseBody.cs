// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of SQL queries.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyItems> Items { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbtest</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The total execution duration of the query. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the query, which is the unique identifier of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022042612465401000000012903151998970</para>
            /// </summary>
            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t1,t2 WHERE t1.id=t2.id;</para>
            /// </summary>
            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            /// <summary>
            /// <para>Specifies whether the SQL statement is truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The SQL statement is truncated.</description></item>
            /// <item><description><b>false</b>: The SQL statement is not truncated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// <para>The truncation threshold of the SQL statement. The value is the number of characters in the string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120</para>
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public int? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The ID of the session to which the query belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            /// <summary>
            /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651877940000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: The query is running.</description></item>
            /// <item><description><b>finished</b>: The query is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpguser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
