// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePatternPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The client IP address that submitted the queries that match the sql pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.14.*</para>
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// <para>The end of the query time range. The time is in UTC and is formatted as <em>yyyy-MM-ddTHH:mmZ</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-22T01:06:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of failed executions for the sql pattern within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The performance metrics.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribePatternPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribePatternPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The performance metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>AnalyticDB_PatternQueryCount</b>: The total number of queries that match the sql pattern.</para>
            /// </description></item>
            /// <item><description><para><b>AnalyticDB_PatternQueryTime</b>: The total time for queries that match the sql pattern.</para>
            /// </description></item>
            /// <item><description><para><b>AnalyticDB_PatternExecutionTime</b>: The total execution time of queries that match the sql pattern.</para>
            /// </description></item>
            /// <item><description><para><b>AnalyticDB_PatternPeakMemory</b>: The peak memory usage of queries that match the sql pattern.</para>
            /// </description></item>
            /// <item><description><para><b>AnalyticDB_PatternScanSize</b>: The total data scan size of queries that match the sql pattern.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_PatternExecutionTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The time series data for the performance metric.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribePatternPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribePatternPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance value. The value of this parameter varies based on the value of <c>Key</c>:</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternQueryCount</c>, this parameter returns <c>pattern_query_count</c>, which indicates the query count for the sql pattern.</para>
                /// </description></item>
                /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternQueryTime</c>, this parameter can be one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>average_query_time</c>: the average total time of queries that match the sql pattern.</para>
                /// </description></item>
                /// <item><description><para><c>max_query_time</c>: the maximum total time of queries that match the sql pattern.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternExecutionTime</c>, this parameter can be one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>average_execution_time</c>: the average execution time of queries that match the sql pattern.</para>
                /// </description></item>
                /// <item><description><para><c>max_execution_time</c>: the maximum execution time of queries that match the sql pattern.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternPeakMemory</c>, this parameter can be one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>average_peak_memory</c>: the average peak memory usage of queries that match the sql pattern.</para>
                /// </description></item>
                /// <item><description><para><c>max_peak_memory</c>: the maximum peak memory usage of queries that match the sql pattern.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternScanSize</c>, this parameter can be one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>average_scan_size</c>: the average data scan size of queries that match the sql pattern.</para>
                /// </description></item>
                /// <item><description><para><c>max_scan_size</c>: the maximum data scan size of queries that match the sql pattern.</para>
                /// </description></item>
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
                /// <para>The list of performance values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The unit of the performance metric. The returned unit varies based on the value of <c>Key</c>:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternQueryTime</c> or <c>AnalyticDB_PatternExecutionTime</c>, the unit is <b>ms</b>.</para>
            /// </description></item>
            /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternPeakMemory</c>, the unit is <b>MB</b>.</para>
            /// </description></item>
            /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternScanSize</c>, the unit is <b>MB</b>.</para>
            /// </description></item>
            /// <item><description><para>If <c>Key</c> is <c>AnalyticDB_PatternQueryCount</c>, this parameter is empty.</para>
            /// </description></item>
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
        /// <para>The number of executions for the sql pattern within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1202</para>
        /// </summary>
        [NameInMap("QueryCount")]
        [Validation(Required=false)]
        public long? QueryCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F21AF487-B8C9-57E0-8E3A-A92BC3611FB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SQL statement for the sql pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT *nFROM HIVE.<c>ADB_EXTERNAL_TPCH_10GB</c>.<c>External_customer</c>nLIMIT ?</para>
        /// </summary>
        [NameInMap("SQLPattern")]
        [Validation(Required=false)]
        public string SQLPattern { get; set; }

        /// <summary>
        /// <para>The start of the query time range. The time is in UTC and is formatted as <em>yyyy-MM-ddTHH:mmZ</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-21T02:15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tables queried by the sql pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch_1g.part;tpch_1g.supplier;tpch_1g.lineitem;tpch_1g.partsupp;tpch_1g.orders;tpch_1g.nation</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        /// <summary>
        /// <para>The database account that executes the SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
