// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The threshold that determines whether the SQL statement must be truncated. The value is the number of characters.</para>
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
            /// <para>The execution duration of the query. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the query. It is a unique identifier of the query.</para>
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
            /// <para>Indicates whether the SQL statement needs to be truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The SQL statement needs to be truncated.</description></item>
            /// <item><description><b>false</b>: The SQL statement does not need to be truncated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// <para>The threshold used to determine whether an SQL statement must be truncated. The value is the number of characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120</para>
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public int? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The ID of the session that contains the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            /// <summary>
            /// <para>The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651877940000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The execution state of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: The query is being executed.</description></item>
            /// <item><description><b>finished</b>: The query is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpguser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
