// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>List of slow log details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord> SQLSlowRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord : TeaModel {
                /// <summary>
                /// <para>Database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-*****************</para>
                /// </summary>
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                /// <summary>
                /// <para>Time when the SQL starts execution. The format is <c>YYYY-MM-DDThh:mmZ</c> (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-07T03:47Z</para>
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// <para>Client address connecting to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb[testdb] @  [100.<b>.</b>.242]</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>SQL lock duration in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockTimes")]
                [Validation(Required=false)]
                public long? LockTimes { get; set; }

                /// <summary>
                /// <para>Number of rows parsed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                /// <summary>
                /// <para>Query time. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QueryTimeMS")]
                [Validation(Required=false)]
                public long? QueryTimeMS { get; set; }

                /// <summary>
                /// <para>SQL execution duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("QueryTimes")]
                [Validation(Required=false)]
                public long? QueryTimes { get; set; }

                /// <summary>
                /// <para>Number of rows returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// <para>Unique identifier for the SQL statement in slow log statistics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U2FsdGVk****</para>
                /// </summary>
                [NameInMap("SQLHash")]
                [Validation(Required=false)]
                public string SQLHash { get; set; }

                /// <summary>
                /// <para>Query statement.</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

            }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records on this page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
