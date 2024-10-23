// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSqlPatternResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried SQL pattern.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSqlPatternResponseBodyItems> Items { get; set; }
        public class DescribeSqlPatternResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The IP address of the client.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <c>Type</c> is set to <c>accessip</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.<em><b>.</b></em></para>
            /// </summary>
            [NameInMap("AccessIP")]
            [Validation(Required=false)]
            public string AccessIP { get; set; }

            /// <summary>
            /// <para>The average execution duration of the SQL pattern within the time range to query. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0625</para>
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public string AvgCpuTime { get; set; }

            /// <summary>
            /// <para>The average peak memory usage of the SQL pattern within the query time range. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>240048</para>
            /// </summary>
            [NameInMap("AvgPeakMemory")]
            [Validation(Required=false)]
            public string AvgPeakMemory { get; set; }

            /// <summary>
            /// <para>The average amount of data scanned based on the SQL pattern within the query time range. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AvgScanSize")]
            [Validation(Required=false)]
            public string AvgScanSize { get; set; }

            /// <summary>
            /// <para>The average number of stages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvgStageCount")]
            [Validation(Required=false)]
            public string AvgStageCount { get; set; }

            /// <summary>
            /// <para>The average number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvgTaskCount")]
            [Validation(Required=false)]
            public string AvgTaskCount { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-bp1r053byu48p****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The maximum execution duration of the SQL pattern within the time range to query. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public string MaxCpuTime { get; set; }

            /// <summary>
            /// <para>The maximum peak memory usage of the SQL pattern within the query time range. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480096</para>
            /// </summary>
            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public string MaxPeakMemory { get; set; }

            /// <summary>
            /// <para>The maximum amount of data scanned based on the SQL pattern within the query time range. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public string MaxScanSize { get; set; }

            /// <summary>
            /// <para>The maximum number of stages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxStageCount")]
            [Validation(Required=false)]
            public string MaxStageCount { get; set; }

            /// <summary>
            /// <para>The maximum number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxTaskCount")]
            [Validation(Required=false)]
            public string MaxTaskCount { get; set; }

            /// <summary>
            /// <para>The SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT table_name, table_schema AS schema_name, create_time, create_time AS last_ddl_time, table_comment AS description , ceil((data_length + index_length) / ? / ?) AS store_capacity , data_length AS data_bytes, index_length AS index_bytes, table_collation AS collation, auto_increment, table_rows AS num_rows , engine FROM information_schema.tables WHERE table_type != ? AND table_schema = ? AND table_name IN (?) ORDER BY 1</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The number of queries performed in association with the SQL pattern within the query time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public string QueryCount { get; set; }

            /// <summary>
            /// <para>The start date of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-30</para>
            /// </summary>
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <c>Type</c> is left empty or set to <c>user</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test_acc</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6F2D1B4-2C9F-5622-B424-5E7965******</para>
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
