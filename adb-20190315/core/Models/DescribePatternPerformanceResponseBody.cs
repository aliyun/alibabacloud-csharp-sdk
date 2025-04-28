// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribePatternPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the SQL client that submits the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.14.*</para>
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-18T18:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of failed SQL patterns within the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The queried performance metrics.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribePatternPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribePatternPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The performance metric that was queried. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AnalyticDB_PatternQueryCount</b>: the total number of queries executed in association with the SQL pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternQueryTime</b>: the total amount of time consumed by the queries executed in association with the SQL pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternExecutionTime</b>: the total execution duration of the queries executed in association with the SQL pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternPeakMemory</b>: the peak memory usage of the queries executed in association with the SQL pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternScanSize</b>: the amount of data scanned in the queries executed in association with the SQL pattern.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_PatternQueryCount</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The queried performance metrics.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribePatternPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribePatternPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance metric value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>When the <c>Key</c> parameter is set to <c>AnalyticDB_PatternQueryCount</c>, <c>pattern_query_count</c> is returned, which indicates the number of executions of the SQL statements in association with the SQL pattern.</para>
                /// </description></item>
                /// <item><description><para>When the <c>Key</c> parameter is set to <c>AnalyticDB_PatternQueryTime</c>, the following values are returned:</para>
                /// <list type="bullet">
                /// <item><description><c>average_query_time</c>, which indicates the average total amount of time consumed by the SQL statements in association with the SQL pattern.</description></item>
                /// <item><description><c>max_query_time</c>, which indicates the maximum total amount of time consumed by the SQL statements in association with the SQL pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>When the <c>Key</c> parameter is set to <c>AnalyticDB_PatternExecutionTime</c>, the following values are returned:</para>
                /// <list type="bullet">
                /// <item><description><c>average_execution_time</c>, which indicates the average execution duration of the SQL statements in association with the SQL pattern.</description></item>
                /// <item><description><c>max_execution_time</c>, which indicates the maximum execution duration of the SQL statements in association with the SQL pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>When the <c>Key</c> parameter is set to <c>AnalyticDB_PatternPeakMemory</c>, the following values are returned:</para>
                /// <list type="bullet">
                /// <item><description><c>average_peak_memory</c>, which indicates the average peak memory usage of the SQL statements in association with the SQL pattern.</description></item>
                /// <item><description><c>max_peak_memory</c>, which indicates the maximum peak memory usage of the SQL statements in association with the SQL pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>When the <c>Key</c> parameter is set <c>AnalyticDB_PatternScanSize</c>, the following values are returned:</para>
                /// <list type="bullet">
                /// <item><description><c>average_scan_size</c>, which indicates the average amount of data scanned by the SQL statements in association with the SQL pattern.</description></item>
                /// <item><description><c>max_scan_size</c>, which indicates the maximum amount of data scanned by the SQL statements in association with the SQL pattern.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>max_query_time</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The queried performance metrics.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The unit of the performance metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When the performance metric is related to the query duration (the <c>Key</c> value is <c>AnalyticDB_PatternQueryTime</c> or <c>AnalyticDB_PatternExecutionTime</c>), <b>ms</b> is returned.</description></item>
            /// <item><description>When the performance metric is related to the memory usage (the <c>Key</c> value is <c>AnalyticDB_PatternPeakMemory</c>), <b>MB</b> is returned.</description></item>
            /// <item><description>When the performance metric is related to the amount of data scanned (the <c>Key</c> value is <c>AnalyticDB_PatternScanSize</c>), <b>MB</b> is returned.</description></item>
            /// <item><description>When the performance metric is related to the number of queries (the <c>Key</c> value is <c>AnalyticDB_PatternQueryCount</c>), this parameter is empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ms</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The number of queries executed in association with the SQL pattern within the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35018</para>
        /// </summary>
        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public long? QueryCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f47011634026610213529******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement that represents the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT *nFROM HIVE.<c>ADB_EXTERNAL_TPCH_10GB</c>.<c>External_customer</c>nLIMIT ?</para>
        /// </summary>
        [NameInMap("SQLPattern")]
        [Validation(Required=false)]
        public string SQLPattern { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-18T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tables that are in association with the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch_1g.part;tpch_1g.supplier;tpch_1g.lineitem;tpch_1g.partsupp;tpch_1g.orders;tpch_1g.nation</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        /// <summary>
        /// <para>The database account that is used to execute the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
