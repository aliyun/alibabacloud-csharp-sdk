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
        /// <para>The collection period of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>15</description></item>
        /// <item><description>60</description></item>
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
        /// <para>The description of the metric import task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configurations of the logs that are imported from Simple Log Service.</para>
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public ModifyHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class ModifyHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// <para>The extended fields that specify the results of basic operations performed on aggregation results.</para>
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
                /// <summary>
                /// <para>The alias of the extended field that specifies the result of basic operations performed on aggregation results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SuccRate</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The extended field that specifies the result of basic operations performed on aggregation results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success_count</para>
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public string Express { get; set; }

            }

            /// <summary>
            /// <para>The conditions that are used to filter logs imported from Simple Log Service.</para>
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
                    /// <para>The method that is used to filter logs imported from Simple Log Service. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>contain</c>: contains</description></item>
                    /// <item><description><c>notContain</c>: does not contain</description></item>
                    /// <item><description><c>&gt;</c>: greater than</description></item>
                    /// <item><description><c>&lt;</c>: less than</description></item>
                    /// <item><description><c>=</c>: equal to</description></item>
                    /// <item><description><c>! =</c>: not equal to</description></item>
                    /// <item><description><c>&gt;=</c>: greater than or equal to</description></item>
                    /// <item><description><c>&lt;=</c>: less than or equal to</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The name of the key that is used to filter logs imported from Simple Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code</para>
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                    /// <summary>
                    /// <para>The value of the key that is used to filter logs imported from Simple Log Service.</para>
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
                /// <item><description>and (default): Logs are processed only if all filter conditions are met.</description></item>
                /// <item><description>or: Logs are processed if one of the filter conditions is met.</description></item>
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
            /// <para>The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL.</para>
            /// </summary>
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
                /// <summary>
                /// <para>The alias of the aggregation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApiResult</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of the key that is used to aggregate logs imported from Simple Log Service.</para>
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
                /// <para>The alias of the aggregation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>level_count</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The function that is used to aggregate the log data of a statistical period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>count: counts the number.</description></item>
                /// <item><description>sum: calculates the total value.</description></item>
                /// <item><description>avg: calculates the average value.</description></item>
                /// <item><description>max: calculates the maximum value.</description></item>
                /// <item><description>min: calculates the minimum value.</description></item>
                /// <item><description>value: collects samples within the statistical period.</description></item>
                /// <item><description>countps: calculates the number of values of the specified field divided by the total number of seconds within the statistical period.</description></item>
                /// <item><description>sumps: calculates the sum of the values of the specified field divided by the total number of seconds within the statistical period.</description></item>
                /// <item><description>distinct: calculates the number of unique values of the specified field within the statistical period.</description></item>
                /// <item><description>distribution: calculates the number of logs that meet a specified condition within the statistical period.</description></item>
                /// <item><description>percentile: sorts the values of the specified field in ascending order, and then returns the value that is at the specified percentile within the statistical period. Example: P50.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>count</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The value of the function that is used to aggregate logs imported from Simple Log Service.</para>
                /// <list type="bullet">
                /// <item><description>If the <c>Function</c> parameter is set to <c>distribution</c>, this parameter specifies the lower limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 200.</description></item>
                /// <item><description>If the <c>Function</c> parameter is set to <c>percentile</c>, this parameter specifies the percentile at which the expected value is. For example, 0.5 specifies P50.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Parameter1")]
                [Validation(Required=false)]
                public string Parameter1 { get; set; }

                /// <summary>
                /// <para>The value of the function that is used to aggregate logs imported from Simple Log Service.</para>
                /// <remarks>
                /// <para> This parameter is required only if the <c>Function</c> parameter is set to <c>distribution</c>. This parameter specifies the upper limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 299.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>299</para>
                /// </summary>
                [NameInMap("Parameter2")]
                [Validation(Required=false)]
                public string Parameter2 { get; set; }

                /// <summary>
                /// <para>The name of the key that is used to aggregate logs imported from Simple Log Service.</para>
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
        /// <para>The ID of the metric import task.</para>
        /// <para>For information about how to obtain the ID of a metric import task, see <a href="https://help.aliyun.com/document_detail/428624.html">DescribeHybridMonitorTaskList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The name of the metric import task.</para>
        /// <para>For information about how to obtain the ID of a metric import task, see <a href="https://help.aliyun.com/document_detail/428624.html">DescribeHybridMonitorTaskList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
