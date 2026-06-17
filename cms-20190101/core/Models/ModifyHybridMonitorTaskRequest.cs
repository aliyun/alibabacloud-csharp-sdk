// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// <para>The tags of the metric.</para>
        /// </summary>
        [NameInMap("AttachLabels")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorTaskRequestAttachLabels> AttachLabels { get; set; }
        public class ModifyHybridMonitorTaskRequestAttachLabels : TeaModel {
            /// <summary>
            /// <para>The tag key of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_service</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The tag value of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The collection interval of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>15</para>
        /// </description></item>
        /// <item><description><para>60</para>
        /// </description></item>
        /// </list>
        /// <para>Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        /// <summary>
        /// <para>The description of the monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS log monitoring data.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SLS log configuration.</para>
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public ModifyHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class ModifyHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// <para>The arithmetic operation result of the extended field in the SLS log statistics result.</para>
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
                /// <summary>
                /// <para>The alias of the arithmetic operation result of the extended field in the SLS log statistics result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SuccRate</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The arithmetic operation result of the extended field in the SLS log statistics result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success_count</para>
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public string Express { get; set; }

            }

            /// <summary>
            /// <para>The filter conditions for parameters in the SLS log.</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public ModifyHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                /// <summary>
                /// <para>None.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
                    /// <summary>
                    /// <para>The method used to filter parameter values in the SLS log. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>contain</c>: contains.</description></item>
                    /// <item><description><c>notContain</c>: does not contain.</description></item>
                    /// <item><description><c>&gt;</c>: greater than.</description></item>
                    /// <item><description><c>&lt;</c>: less than.</description></item>
                    /// <item><description><c>=</c>: equal to.</description></item>
                    /// <item><description><c>!=</c>: not equal to.</description></item>
                    /// <item><description><c>&gt;=</c>: greater than or equal to.</description></item>
                    /// <item><description><c>&lt;=</c>: less than or equal to.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter to filter in the SLS log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code</para>
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                    /// <summary>
                    /// <para>The filter value of the parameter in the SLS log.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The relationship between multiple filter conditions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>and (default): Logs are processed only when all filter conditions are met.</description></item>
                /// <item><description>or: Logs are processed when any filter condition is met.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>and</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

            }

            /// <summary>
            /// <para>Aggregates data by spatial dimension, which is equivalent to GROUP BY in SQL.</para>
            /// </summary>
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
                /// <summary>
                /// <para>The alias of the SLS log statistics result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApiResult</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of the parameter for SLS log statistics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("SLSKeyName")]
                [Validation(Required=false)]
                public string SLSKeyName { get; set; }

            }

            /// <summary>
            /// <para>None.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
                /// <summary>
                /// <para>The alias of the SLS log statistics result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>level_count</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The statistical method used to aggregate log data within a statistical period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>count: counts the number of occurrences.</description></item>
                /// <item><description>sum: calculates the sum.</description></item>
                /// <item><description>avg: calculates the average.</description></item>
                /// <item><description>max: returns the maximum value.</description></item>
                /// <item><description>min: returns the minimum value.</description></item>
                /// <item><description>value: samples within the period.</description></item>
                /// <item><description>countps: calculates the per-second average of the count for the specified field within the statistical period.</description></item>
                /// <item><description>sumps: calculates the per-second average of the sum for the specified field within the statistical period.</description></item>
                /// <item><description>distinct: calculates the number of occurrences of the specified field after deduplication within the statistical period.</description></item>
                /// <item><description>distribution: calculates the number of occurrences of field values within a specified range.</description></item>
                /// <item><description>percentile: calculates the distribution value of field values, such as P50.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>count</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The statistical value of the SLS log.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>Function</c> is set to <c>distribution</c>, this parameter specifies the lower limit of the statistical range. For example, to count the number of 2XX HTTP status codes, set this parameter to 200.</para>
                /// </description></item>
                /// <item><description><para>If <c>Function</c> is set to <c>percentile</c>, this parameter specifies the percentile of the statistical distribution. For example, 0.5 indicates P50.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Parameter1")]
                [Validation(Required=false)]
                public string Parameter1 { get; set; }

                /// <summary>
                /// <para>The statistical value of the SLS log.</para>
                /// <remarks>
                /// <para>This parameter is required only when <c>Function</c> is set to <c>distribution</c>. It specifies the upper limit of the statistical range. For example, to count the number of 2XX HTTP status codes, set this parameter to 299.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>299</para>
                /// </summary>
                [NameInMap("Parameter2")]
                [Validation(Required=false)]
                public string Parameter2 { get; set; }

                /// <summary>
                /// <para>The name of the parameter for SLS log statistics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("SLSKeyName")]
                [Validation(Required=false)]
                public string SLSKeyName { get; set; }

            }

        }

        /// <summary>
        /// <para>The monitoring task ID.</para>
        /// <para>For information about how to obtain the monitoring task ID, see <a href="https://help.aliyun.com/document_detail/428624.html">DescribeHybridMonitorTaskList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The monitoring task name.</para>
        /// <para>For information about how to obtain the monitoring task ID, see <a href="https://help.aliyun.com/document_detail/428624.html">DescribeHybridMonitorTaskList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
