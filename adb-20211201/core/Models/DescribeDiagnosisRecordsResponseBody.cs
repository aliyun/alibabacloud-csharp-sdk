// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The queried SQL statements.</para>
        /// </summary>
        [NameInMap("Querys")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyQuerys> Querys { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyQuerys : TeaModel {
            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59.82.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The total execution duration. Unit: milliseconds.</para>
            /// <remarks>
            /// <para> This value is the cumulative value of the <c>QueuedTime</c>, <c>TotalPlanningTime</c>, and <c>ExecutionTime</c> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// <para>The name of the database on which the SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The number of rows written to the table by an extract-transform-load (ETL) job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EtlWriteRows")]
            [Validation(Required=false)]
            public long? EtlWriteRows { get; set; }

            /// <summary>
            /// <para>The execution duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public long? ExecutionTime { get; set; }

            /// <summary>
            /// <para>The amount of returned data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// <para>The number of rows returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-5575924945138******</para>
            /// </summary>
            [NameInMap("PatternId")]
            [Validation(Required=false)]
            public string PatternId { get; set; }

            /// <summary>
            /// <para>The peak memory. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16648</para>
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021093000414401000000023503151******</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The query properties.</para>
            /// <remarks>
            /// <para> For information about common properties, see <a href="https://help.aliyun.com/document_detail/408955.html">Config and hint configuration parameters</a>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("QueryProperties")]
            [Validation(Required=false)]
            public List<DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties> QueryProperties { get; set; }
            public class DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>max_select_items_count</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The amount of time that is consumed for queuing. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public long? QueueTime { get; set; }

            /// <summary>
            /// <para>The IP address and port number of the AnalyticDB for MySQL frontend node on which the SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX:3004</para>
            /// </summary>
            [NameInMap("RcHost")]
            [Validation(Required=false)]
            public string RcHost { get; set; }

            /// <summary>
            /// <para>The execution duration rank of operators that are used in the SQL statement.</para>
            /// <remarks>
            /// <para> This parameter is returned only for SQL statements whose <c>Status</c> parameter is <c>running</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceCostRank")]
            [Validation(Required=false)]
            public int? ResourceCostRank { get; set; }

            /// <summary>
            /// <para>The resource group to which the SQL statement belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_default</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The queried SQL statement.</para>
            /// <remarks>
            /// <para> For performance considerations, an SQL statement cannot exceed 5,120 characters in length. Otherwise, the SQL statement is truncated. You can call the <a href="https://help.aliyun.com/document_detail/308212.html">DownloadDiagnosisRecords</a> operation to download the information about SQL statements that meet a query condition for an AnalyticDB for MySQL cluster, including the complete SQL statements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT count(*)\nFROM nation</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement is truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// <para>The maximum length of the SQL statement. 5120 is returned. Unit: characters. SQL statements that exceed this limit are truncated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120</para>
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public long? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The number of rows scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// <para>The amount of scanned data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("ScanSize")]
            [Validation(Required=false)]
            public long? ScanSize { get; set; }

            /// <summary>
            /// <para>The execution start time of the SQL statement. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1632933704000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The state of the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>finished</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The amount of time that is consumed to generate an execution plan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPlanningTime")]
            [Validation(Required=false)]
            public long? TotalPlanningTime { get; set; }

            /// <summary>
            /// <para>The total number of stages generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalStages")]
            [Validation(Required=false)]
            public int? TotalStages { get; set; }

            /// <summary>
            /// <para>The username that is used to execute the SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F88BEFA-CF0B-5C95-8BB1-92EC9F09E40D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
