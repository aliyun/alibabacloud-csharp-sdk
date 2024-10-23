// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1rqvm70uh2****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Details of the slow query logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SlowLogRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord> SlowLogRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_demo</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The time when the execution started. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-27T08:04:43Z</para>
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// <para>The IP address of the client that is used to connect to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.16.**.**</c></para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The amount of output data in the task. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.009</para>
                /// </summary>
                [NameInMap("OutputSize")]
                [Validation(Required=false)]
                public string OutputSize { get; set; }

                /// <summary>
                /// <para>The number of rows parsed by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                /// <summary>
                /// <para>The maximum memory usage when the SQL statement is executed. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>431.447</para>
                /// </summary>
                [NameInMap("PeakMemoryUsage")]
                [Validation(Required=false)]
                public string PeakMemoryUsage { get; set; }

                /// <summary>
                /// <para>The amount of time consumed to generate execution plans. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PlanningTime")]
                [Validation(Required=false)]
                public long? PlanningTime { get; set; }

                /// <summary>
                /// <para>The ID of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021052716044317201616624903453******</para>
                /// </summary>
                [NameInMap("ProcessID")]
                [Validation(Required=false)]
                public string ProcessID { get; set; }

                /// <summary>
                /// <para>The time consumed to execute the SQL statement. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2344</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public long? QueryTime { get; set; }

                /// <summary>
                /// <para>The queuing duration before the query is executed. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <para>The number of rows returned by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// <para>Details of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSERT OVERWRITE INTO hdfs_import_external\nSELECT *\nFROM adb_hdfs_import_source</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The number of rows scanned from a data source in the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                /// <summary>
                /// <para>The amount of scanned data. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.035</para>
                /// </summary>
                [NameInMap("ScanSize")]
                [Validation(Required=false)]
                public string ScanSize { get; set; }

                /// <summary>
                /// <para>The total amount of time consumed to scan data. It is an accumulated value collected from multiple TableScanNode nodes. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ScanTime")]
                [Validation(Required=false)]
                public long? ScanTime { get; set; }

                /// <summary>
                /// <para>The execution state of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESSED</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The accumulated CPU Time value of all operators collected from all nodes. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6100</para>
                /// </summary>
                [NameInMap("WallTime")]
                [Validation(Required=false)]
                public long? WallTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7559209-7EC3-41E1-8F78-156990******</para>
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
        public string TotalCount { get; set; }

    }

}
