// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// The tags of the metric.
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_sls`.
        /// </summary>
        [NameInMap("AttachLabels")]
        [Validation(Required=false)]
        public List<CreateHybridMonitorTaskRequestAttachLabels> AttachLabels { get; set; }
        public class CreateHybridMonitorTaskRequestAttachLabels : TeaModel {
            /// <summary>
            /// The tag key of the metric.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The tag value of the metric.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("CloudAccessId")]
        [Validation(Required=false)]
        public List<string> CloudAccessId { get; set; }

        /// <summary>
        /// The collection period of the metric. Valid values:
        /// 
        /// *   15
        /// *   60 (default)
        /// 
        /// Unit: seconds.
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_sls`.
        /// </summary>
        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        /// <summary>
        /// The type of the collection target.
        /// 
        /// *   If the `TaskType` parameter is set to `aliyun_fc`, enter `aliyun_fc`.
        /// *   If the `TaskType` parameter is set to `aliyun_sls`, enter the name of the Logstore group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CollectTargetType")]
        [Validation(Required=false)]
        public string CollectTargetType { get; set; }

        /// <summary>
        /// The description of the metric import task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_sls`.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](https://help.aliyun.com/document_detail/428880.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configurations of the logs that are imported from Simple Log Service.
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_sls`.
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public CreateHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class CreateHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// The extended fields that specify the results of basic operations performed on aggregation results.
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
                /// <summary>
                /// The alias of the extended field that specifies the result of basic operations performed on aggregation results.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The extended field that specifies the result of basic operations performed on aggregation results.
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public string Express { get; set; }

            }

            /// <summary>
            /// The conditions that are used to filter logs imported from Simple Log Service.
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public CreateHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                /// <summary>
                /// The conditions that are used to filter logs imported from Simple Log Service.
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class CreateHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
                    /// <summary>
                    /// The method that is used to filter logs imported from Simple Log Service. Valid values:
                    /// 
                    /// *   `contain`: contains
                    /// *   `notContain`: does not contain
                    /// *   `>`: greater than
                    /// *   `<`: less than
                    /// *   `=`: equal to
                    /// *   `! =`: not equal to
                    /// *   `>=`: greater than or equal to
                    /// *   `<=`: less than or equal to
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// The name of the key that is used to filter logs imported from Simple Log Service.
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                    /// <summary>
                    /// The value of the key that is used to filter logs imported from Simple Log Service.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The relationship between multiple filter conditions. Valid values:
                /// 
                /// *   and (default): Logs are processed only if all filter conditions are met.
                /// *   or: Logs are processed if one of the filter conditions is met.
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

            }

            /// <summary>
            /// The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL.
            /// </summary>
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
                /// <summary>
                /// The alias of the aggregation result.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The name of the key that is used to aggregate logs imported from Simple Log Service.
                /// </summary>
                [NameInMap("SLSKeyName")]
                [Validation(Required=false)]
                public string SLSKeyName { get; set; }

            }

            /// <summary>
            /// The method that is used to aggregate logs imported from Simple Log Service.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<CreateHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class CreateHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
                /// <summary>
                /// The alias of the aggregation result.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The function that is used to aggregate the log data of a statistical period. Valid values:
                /// 
                /// *   count: counts the number.
                /// *   sum: calculates the total value.
                /// *   avg: calculates the average value.
                /// *   max: calculates the maximum value.
                /// *   min: calculates the minimum value.
                /// *   value: collects samples within the statistical period.
                /// *   countps: calculates the number of values of the specified field divided by the total number of seconds within a statistical period.
                /// *   sumps: calculates the sum of the values of the specified field divided by the total number of seconds within a statistical period.
                /// *   distinct: calculates the number of unique values of the specified field within a statistical period.
                /// *   distribution: calculates the number of logs that meet a specified condition within the statistical period.
                /// *   percentile: sorts the values of the specified field in ascending order, and then returns the value that is at the specified percentile within the statistical period. Example: P50.
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The value of the function that is used to aggregate logs imported from Simple Log Service.
                /// 
                /// *   If the `Function` parameter is set to `distribution`, this parameter specifies the lower limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 200.
                /// *   If the `Function` parameter is set to `percentile`, this parameter specifies the percentile at which the expected value is. For example, 0.5 specifies P50.
                /// </summary>
                [NameInMap("Parameter1")]
                [Validation(Required=false)]
                public string Parameter1 { get; set; }

                /// <summary>
                /// The value of the function that is used to aggregate logs imported from Simple Log Service.
                /// 
                /// >  This parameter is required only if the `Function` parameter is set to `distribution`. This parameter specifies the upper limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 299.
                /// </summary>
                [NameInMap("Parameter2")]
                [Validation(Required=false)]
                public string Parameter2 { get; set; }

                /// <summary>
                /// The name of the key that is used to aggregate logs imported from Simple Log Service.
                /// </summary>
                [NameInMap("SLSKeyName")]
                [Validation(Required=false)]
                public string SLSKeyName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the member account.
        /// 
        /// If you call this operation by using the management account of a resource directory, you can connect the Alibaba Cloud services that are activated for all members in the resource directory to Hybrid Cloud Monitoring. You can use the resource directory to monitor Alibaba Cloud services across enterprise accounts.
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_fc`.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

        /// <summary>
        /// The IDs of the member accounts. Separate multiple member account IDs with commas (,).
        /// 
        /// >  This parameter is required only if you call this operation by using the management account.
        /// </summary>
        [NameInMap("TargetUserIdList")]
        [Validation(Required=false)]
        public string TargetUserIdList { get; set; }

        /// <summary>
        /// The name of the metric import task.
        /// 
        /// *   If the `TaskType` parameter is set to `aliyun_fc`, enter the name of the metric import task.
        /// *   If the `TaskType` parameter is set to `aliyun_sls`, enter the name of the metric for logs imported from Simple Log Service.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the metric import task. Valid values:
        /// 
        /// *   aliyun_fc: metric import tasks for Alibaba Cloud services.
        /// *   aliyun_sls: metrics for logs imported from Simple Log Service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.
        /// 
        /// *   namespace: the namespace of the Alibaba Cloud service. For information about how to query the namespace of an Alibaba Cloud service, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html).
        /// *   metric_list: the metrics of the Alibaba Cloud service. For information about how to query the metrics of an Alibaba Cloud service, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html).
        /// 
        /// The following code shows a sample configuration file:
        /// 
        ///     products:
        ///     - namespace: acs_ecs_dashboard
        ///       metric_info:
        ///       - metric_list:
        ///         - cpu_total
        ///         - cpu_idle
        ///         - diskusage_utilization
        ///         - CPUUtilization
        ///         - DiskReadBPS
        ///         - InternetOut
        ///         - IntranetOut
        ///         - cpu_system
        ///     - namespace: acs_rds_dashboard
        ///       metric_info:
        ///       - metric_list:
        ///         - MySQL_QPS
        ///         - MySQL_TPS
        /// 
        /// >  This parameter is required only if the `TaskType` parameter is set to `aliyun_fc`.
        /// </summary>
        [NameInMap("YARMConfig")]
        [Validation(Required=false)]
        public string YARMConfig { get; set; }

    }

}
