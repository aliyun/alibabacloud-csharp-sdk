// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. The value is an integer that is greater than 0. Default value: <b>1</b>.</para>
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
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of SQL statement details.</para>
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
            /// <para>The total execution duration of the query. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>This duration is the sum of <c>QueuedTime</c>, <c>TotalPlanningTime</c>, and <c>ExecutionTime</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            /// <summary>
            /// <para>The name of the database where the SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The number of rows written to a table in an ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EtlWriteRows")]
            [Validation(Required=false)]
            public long? EtlWriteRows { get; set; }

            /// <summary>
            /// <para>The execution duration of the query. Unit: milliseconds (ms).</para>
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
            /// <para>The number of returned rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <para>The ID of the SQL pattern.</para>
            /// <remarks>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/612503.html">DescribePatternPerformance</a> operation to view the detailed execution metrics of the SQL pattern within a specified time range.</para>
            /// </remarks>
            /// 
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
            /// <para>The list of properties that are in effect for the current query.</para>
            /// <remarks>
            /// <para>For a list of common properties, see <a href="https://help.aliyun.com/document_detail/408955.html">Config and Hint configuration parameters</a>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("QueryProperties")]
            [Validation(Required=false)]
            public List<DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties> QueryProperties { get; set; }
            public class DescribeDiagnosisRecordsResponseBodyQuerysQueryProperties : TeaModel {
                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>max_select_items_count</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The amount of time that the query waited in a queue before execution. Unit: milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public long? QueueTime { get; set; }

            /// <summary>
            /// <para>The IP address and port number of the AnalyticDB for MySQL frontend node that is used to execute the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX:3004</para>
            /// </summary>
            [NameInMap("RcHost")]
            [Validation(Required=false)]
            public string RcHost { get; set; }

            /// <summary>
            /// <para>The ranking of the execution duration of an operator in the SQL statement.</para>
            /// <remarks>
            /// <para>This parameter is returned only for SQL statements that are in the <c>running</c> state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceCostRank")]
            [Validation(Required=false)]
            public int? ResourceCostRank { get; set; }

            /// <summary>
            /// <para>The resource pool to which the SQL statement belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_default</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The details of the SQL statement.</para>
            /// <remarks>
            /// <para>For performance, an SQL statement can be up to 5,120 characters long. Longer statements are truncated. Call the <a href="https://help.aliyun.com/document_detail/308212.html">DownloadDiagnosisRecords</a> operation to download the summary information of SQL statements that meet the specified conditions, including the complete SQL statements.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT count(*)\nFROM nation</para>
            /// </summary>
            [NameInMap("SQL")]
            [Validation(Required=false)]
            public string SQL { get; set; }

            /// <summary>
            /// <para>Indicates whether the length of the query result exceeds the threshold. If the length exceeds the threshold, the query result is truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The length of the query result exceeds the threshold.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The length of the query result does not exceed the threshold.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// <para>The truncation threshold for the SQL statement. The value is fixed at 5,120 characters. SQL statements that exceed this limit are truncated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120</para>
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public long? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The number of scanned rows.</para>
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
            /// <para>The start time of the SQL execution. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <item><description><para><b>running</b>: The statement is running.</para>
            /// </description></item>
            /// <item><description><para><b>finished</b>: The statement is complete.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The statement failed to be executed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The amount of time that was required to generate the execution plan. Unit: milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPlanningTime")]
            [Validation(Required=false)]
            public long? TotalPlanningTime { get; set; }

            /// <summary>
            /// <para>The total number of stages generated for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalStages")]
            [Validation(Required=false)]
            public int? TotalStages { get; set; }

            /// <summary>
            /// <para>The username used to execute the SQL statement.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
