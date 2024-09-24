// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// <para>The tags of the metric.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AttachLabels")]
        [Validation(Required=false)]
        public List<CreateHybridMonitorTaskRequestAttachLabels> AttachLabels { get; set; }
        public class CreateHybridMonitorTaskRequestAttachLabels : TeaModel {
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

        [NameInMap("CloudAccessId")]
        [Validation(Required=false)]
        public List<string> CloudAccessId { get; set; }

        /// <summary>
        /// <para>The collection period of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>15</description></item>
        /// <item><description>60 (default)</description></item>
        /// </list>
        /// <para>Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        /// <summary>
        /// <para>The type of the collection target.</para>
        /// <list type="bullet">
        /// <item><description>If the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>, enter <c>aliyun_fc</c>.</description></item>
        /// <item><description>If the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>, enter the name of the Logstore group.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_fc</para>
        /// </summary>
        [NameInMap("CollectTargetType")]
        [Validation(Required=false)]
        public string CollectTargetType { get; set; }

        /// <summary>
        /// <para>The description of the metric import task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>For information about how to obtain the name of a namespace, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configurations of the logs that are imported from Simple Log Service.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public CreateHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class CreateHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// <para>The extended fields that specify the results of basic operations performed on aggregation results.</para>
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
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
            public CreateHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                /// <summary>
                /// <para>The conditions that are used to filter logs imported from Simple Log Service.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
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
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
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
            /// <para>The method that is used to aggregate logs imported from Simple Log Service.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
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
                /// <item><description>countps: calculates the number of values of the specified field divided by the total number of seconds within a statistical period.</description></item>
                /// <item><description>sumps: calculates the sum of the values of the specified field divided by the total number of seconds within a statistical period.</description></item>
                /// <item><description>distinct: calculates the number of unique values of the specified field within a statistical period.</description></item>
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
        /// <para>The ID of the member account.</para>
        /// <para>If you call this operation by using the management account of a resource directory, you can connect the Alibaba Cloud services that are activated for all members in the resource directory to Hybrid Cloud Monitoring. You can use the resource directory to monitor Alibaba Cloud services across enterprise accounts.</para>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the member accounts. Separate multiple member account IDs with commas (,).</para>
        /// <remarks>
        /// <para> This parameter is required only if you call this operation by using the management account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserIdList")]
        [Validation(Required=false)]
        public string TargetUserIdList { get; set; }

        /// <summary>
        /// <para>The name of the metric import task.</para>
        /// <list type="bullet">
        /// <item><description>If the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>, enter the name of the metric import task.</description></item>
        /// <item><description>If the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>, enter the name of the metric for logs imported from Simple Log Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the metric import task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliyun_fc: metric import tasks for Alibaba Cloud services.</description></item>
        /// <item><description>aliyun_sls: metrics for logs imported from Simple Log Service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_fc</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.</para>
        /// <list type="bullet">
        /// <item><description>namespace: the namespace of the Alibaba Cloud service. For information about how to query the namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a>.</description></item>
        /// <item><description>metric_list: the metrics of the Alibaba Cloud service. For information about how to query the metrics of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a>.</description></item>
        /// </list>
        /// <para>The following code shows a sample configuration file:</para>
        /// <pre><c>products:
        /// - namespace: acs_ecs_dashboard
        ///   metric_info:
        ///   - metric_list:
        ///     - cpu_total
        ///     - cpu_idle
        ///     - diskusage_utilization
        ///     - CPUUtilization
        ///     - DiskReadBPS
        ///     - InternetOut
        ///     - IntranetOut
        ///     - cpu_system
        /// - namespace: acs_rds_dashboard
        ///   metric_info:
        ///   - metric_list:
        ///     - MySQL_QPS
        ///     - MySQL_TPS
        /// </c></pre>
        /// <remarks>
        /// <para> This parameter is required only if the <c>TaskType</c> parameter is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>products:- namespace: acs_ecs_dashboard  metric_info:  - metric_list:    - cpu_total</para>
        /// </summary>
        [NameInMap("YARMConfig")]
        [Validation(Required=false)]
        public string YARMConfig { get; set; }

    }

}
