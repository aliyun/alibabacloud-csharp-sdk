// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePatternPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the client that submits the SQL statements related to the pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.14.*</para>
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the <i>yyyy-MM-ddTHH:mmZ</i> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-22T01:06:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of failures of the pattern within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// <para>The performance details.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribePatternPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribePatternPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// <para>The queried performance metrics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AnalyticDB_PatternQueryCount</b>: the total number of queries related to the pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternQueryTime</b>: the total time consumed by queries related to the pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternExecutionTime</b>: the execution duration of queries related to the pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternPeakMemory</b>: the peak memory consumed by queries related to the pattern.</description></item>
            /// <item><description><b>AnalyticDB_PatternScanSize</b>: the data volume read by queries related to the pattern.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AnalyticDB_PatternExecutionTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The details of each performance value under the performance metrics.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribePatternPerformanceResponseBodyPerformancesSeries> Series { get; set; }
            public class DescribePatternPerformanceResponseBodyPerformancesSeries : TeaModel {
                /// <summary>
                /// <para>The name of the performance value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>When the <c>Key</c> value is <c>AnalyticDB_PatternQueryCount</c>, this parameter returns <c>pattern_query_count</c>, which indicates the executions of SQL statements related to the current pattern.</description></item>
                /// <item><description>When the <c>Key</c> value is <c>AnalyticDB_PatternQueryTime</c>, this parameter returns:<list type="bullet">
                /// <item><description><c>average_query_time</c>: the average total time consumed by SQL statements related to the current pattern.</description></item>
                /// <item><description><c>max_query_time</c>: the maximum total time consumed by SQL statements related to the current pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When the <c>Key</c> value is <c>AnalyticDB_PatternExecutionTime</c>, this parameter returns:<list type="bullet">
                /// <item><description><c>average_execution_time</c>: the average execution duration of SQL statements related to the current pattern.</description></item>
                /// <item><description><c>max_execution_time</c>: the maximum execution duration of SQL statements related to the current pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When the <c>Key</c> value is <c>AnalyticDB_PatternPeakMemory</c>, this parameter returns:<list type="bullet">
                /// <item><description><c>average_peak_memory</c>: the average peak memory consumed by SQL statements related to the current pattern.</description></item>
                /// <item><description><c>max_peak_memory</c>: the maximum peak memory consumed by SQL statements related to the current pattern.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When the <c>Key</c> value is <c>AnalyticDB_PatternScanSize</c>, this parameter returns:<list type="bullet">
                /// <item><description><c>average_scan_size</c>: the average data volume read by SQL statements related to the current pattern.</description></item>
                /// <item><description><c>max_scan_size</c>: the maximum data volume read by SQL statements related to the current pattern.</description></item>
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
            /// <para>The units corresponding to the performance metrics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ms</b>: returned when the performance metric is related to query time, which means the <c>Key</c> value is <c>AnalyticDB_PatternQueryTime</c> or <c>AnalyticDB_PatternExecutionTime</c>.</description></item>
            /// <item><description><b>MB</b>: returned when the performance metric is related to peak memory, which means the <c>Key</c> value is <c>AnalyticDB_PatternPeakMemory</c>.</description></item>
            /// <item><description><b>MB</b>: returned when the performance metric is the data volume read, which means the <c>Key</c> value is <c>AnalyticDB_PatternScanSize</c>.</description></item>
            /// <item><description>Empty: returned when the performance metric is the number of queries, which means the <c>Key</c> value is <c>AnalyticDB_PatternQueryCount</c>.</description></item>
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
        /// <para>The number of executions of the pattern within the query time range.</para>
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
        /// <para>The specific statement of the SQL pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT *nFROM HIVE.<c>ADB_EXTERNAL_TPCH_10GB</c>.<c>External_customer</c>nLIMIT ?</para>
        /// </summary>
        [NameInMap("SQLPattern")]
        [Validation(Required=false)]
        public string SQLPattern { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in UTC and follows the <i>yyyy-MM-ddTHH:mmZ</i> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-21T02:15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The information about the tables involved in the SQL pattern query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpch_1g.part;tpch_1g.supplier;tpch_1g.lineitem;tpch_1g.partsupp;tpch_1g.orders;tpch_1g.nation</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        /// <summary>
        /// <para>The database account that executes the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
