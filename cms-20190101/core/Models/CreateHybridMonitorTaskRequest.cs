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
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_sls</c>.</para>
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

        /// <summary>
        /// <para>The IDs of the accounts of other cloud providers that are connected to CloudMonitor.</para>
        /// </summary>
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
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        /// <summary>
        /// <para>The type of the collection target for monitoring data.</para>
        /// <list type="bullet">
        /// <item><description>If TaskType is set to <c>aliyun_fc</c>, set this parameter to <c>aliyun_fc</c>.</description></item>
        /// <item><description>If TaskType is set to <c>aliyun_sls</c>, set this parameter to the name of the Logstore group for SLS logs.</description></item>
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
        /// <para>The description of the monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud product data ingestion task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the application group ID, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <remarks>
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the metric repository.</para>
        /// <para>For information about how to obtain the name of a metric repository, see <a href="https://help.aliyun.com/document_detail/428880.html">DescribeHybridMonitorNamespaceList</a>.</para>
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
        /// <para>The configurations of SLS logs.</para>
        /// <remarks>
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_sls</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public CreateHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class CreateHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// <para>The result of arithmetic operations on the extended fields of SLS log statistics results.</para>
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
                /// <summary>
                /// <para>The alias of the arithmetic operation result on the extended fields of SLS log statistics results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SuccRate</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The result of arithmetic operations on the extended fields of SLS log statistics results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success_count</para>
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public string Express { get; set; }

            }

            /// <summary>
            /// <para>The filter conditions for parameters in SLS logs.</para>
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public CreateHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                /// <summary>
                /// <para>The list of filter conditions for parameters in SLS logs.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
                    /// <summary>
                    /// <para>The method used to filter parameter values in SLS logs. Valid values:</para>
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
                    /// <para>The name of the parameter to filter in SLS logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code</para>
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                    /// <summary>
                    /// <para>The filter value of the parameter in SLS logs.</para>
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
            /// <para>Aggregates data by spatial dimension, which is equivalent to the GROUP BY clause in SQL.</para>
            /// </summary>
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
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
            /// <para>The method used to aggregate SLS log data.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
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
                /// <para>Aggregates log data within the statistical period by using the specified statistical method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>count: counts the number of occurrences.</description></item>
                /// <item><description>sum: calculates the sum.</description></item>
                /// <item><description>avg: calculates the average.</description></item>
                /// <item><description>max: returns the maximum value.</description></item>
                /// <item><description>min: returns the minimum value.</description></item>
                /// <item><description>value: samples within the statistical period.</description></item>
                /// <item><description>countps: calculates the average count per second for the specified field within the statistical period.</description></item>
                /// <item><description>sumps: calculates the average sum per second for the specified field within the statistical period.</description></item>
                /// <item><description>distinct: counts the number of occurrences of the specified field after deduplication within the statistical period.</description></item>
                /// <item><description>distribution: counts the number of occurrences of field values within a specified range.</description></item>
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
                /// <para>The statistical value of SLS logs.</para>
                /// <list type="bullet">
                /// <item><description><para>If Function is set to <c>distribution</c>, this parameter specifies the lower limit of the statistical range. For example, to count the number of 2XX HTTP status codes, set this parameter to 200.</para>
                /// </description></item>
                /// <item><description><para>If Function is set to <c>percentile</c>, this parameter specifies the percentile of the statistical distribution. For example, 0.5 indicates P50.</para>
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
                /// <para>The statistical value of SLS logs.</para>
                /// <remarks>
                /// <para>This parameter is required only when Function is set to <c>distribution</c>. This parameter specifies the upper limit of the statistical range. For example, to count the number of 2XX HTTP status codes, set this parameter to 299.</para>
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
        /// <para>The ID of the member account.</para>
        /// <para>When you call this operation by using a management account, you can connect any Alibaba Cloud service of any member account in the resource directory to Hybrid Cloud Monitoring. This allows you to use the resource directory to monitor the Alibaba Cloud services of member accounts across the enterprise in a unified manner.</para>
        /// <remarks>
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_fc</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the member accounts. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>This parameter is required only when you call this operation by using a management account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120886317861****</para>
        /// </summary>
        [NameInMap("TargetUserIdList")]
        [Validation(Required=false)]
        public string TargetUserIdList { get; set; }

        /// <summary>
        /// <para>The name of the monitoring task.</para>
        /// <list type="bullet">
        /// <item><description>If TaskType is set to <c>aliyun_fc</c>, specify the name of the data import task for the Alibaba Cloud service.</description></item>
        /// <item><description>If TaskType is set to <c>aliyun_sls</c>, specify the metric name for SLS logs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliyun_fc: data import task for an Alibaba Cloud service.</description></item>
        /// <item><description>aliyun_sls: metric for SLS logs.</description></item>
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
        /// <para>The configuration file of the Alibaba Cloud service that is connected to Hybrid Cloud Monitoring.</para>
        /// <list type="bullet">
        /// <item><description>namespace: the namespace of the Alibaba Cloud service. For information about how to query the namespace of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a>.</description></item>
        /// <item><description>metric_list: the metrics of the Alibaba Cloud service. For information about how to query the metrics of an Alibaba Cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a>.</description></item>
        /// </list>
        /// <para>The following example shows a sample configuration file:</para>
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
        /// <para>This parameter is required only when TaskType is set to <c>aliyun_fc</c>.</para>
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
