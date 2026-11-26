// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSlowSQLRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of slow query records.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSlowSQLRecordsResponseBodyItems> Items { get; set; }
        public class ListSlowSQLRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The total CPU time consumed by the query execution. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CpuTimeMs")]
            [Validation(Required=false)]
            public long? CpuTimeMs { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpgadmin</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The total execution duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("DurationTime")]
            [Validation(Required=false)]
            public int? DurationTime { get; set; }

            /// <summary>
            /// <para>The total lock wait time of the query. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("LockWaitTime")]
            [Validation(Required=false)]
            public int? LockWaitTime { get; set; }

            /// <summary>
            /// <para>The total memory occupied by the query execution. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MemBytes")]
            [Validation(Required=false)]
            public long? MemBytes { get; set; }

            /// <summary>
            /// <para>The execution optimizer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planner</para>
            /// </summary>
            [NameInMap("Optimizer")]
            [Validation(Required=false)]
            public string Optimizer { get; set; }

            /// <summary>
            /// <para>The end time of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-04T18:00:00Z</para>
            /// </summary>
            [NameInMap("QueryEndTime")]
            [Validation(Required=false)]
            public string QueryEndTime { get; set; }

            /// <summary>
            /// <para>The query ID, which is the unique identifier of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7775338456746339025</para>
            /// </summary>
            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            /// <summary>
            /// <para>The start time of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-04T17:00:00Z</para>
            /// </summary>
            [NameInMap("QueryStartTime")]
            [Validation(Required=false)]
            public string QueryStartTime { get; set; }

            /// <summary>
            /// <para>The time the query spent waiting in resource queues and resource groups. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("QueueWaitTime")]
            [Validation(Required=false)]
            public int? QueueWaitTime { get; set; }

            /// <summary>
            /// <para>The total size of files spilled to disk during the query. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SpillBytes")]
            [Validation(Required=false)]
            public long? SpillBytes { get; set; }

            /// <summary>
            /// <para>The SQL statement in the audit log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHOW COLUMNS FROM <c>t_project</c></para>
            /// </summary>
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            /// <summary>
            /// <para>Specifies whether the SQL statement is truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The SQL statement is truncated.</description></item>
            /// <item><description>false: The SQL statement is not truncated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SqlTruncated")]
            [Validation(Required=false)]
            public string SqlTruncated { get; set; }

            /// <summary>
            /// <para>The truncation threshold for SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SqlTruncatedThreshold")]
            [Validation(Required=false)]
            public int? SqlTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The database username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
