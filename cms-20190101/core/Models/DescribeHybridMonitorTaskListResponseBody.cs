// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the request was successful, the value `successful` is returned.
        /// *   If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The metric import tasks.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorTaskListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeHybridMonitorTaskListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// The tags of the metric import task.
            /// </summary>
            [NameInMap("AttachLabels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels> AttachLabels { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The interval at which the CloudMonitor agent collects host monitoring data. Valid values:
            /// 
            /// *   15
            /// *   30
            /// *   60
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("CollectInterval")]
            [Validation(Required=false)]
            public int? CollectInterval { get; set; }

            /// <summary>
            /// The URL of the destination from which the CloudMonitor agent collects host monitoring data.
            /// </summary>
            [NameInMap("CollectTargetEndpoint")]
            [Validation(Required=false)]
            public string CollectTargetEndpoint { get; set; }

            /// <summary>
            /// The relative path from which the CloudMonitor agent collects monitoring data.
            /// </summary>
            [NameInMap("CollectTargetPath")]
            [Validation(Required=false)]
            public string CollectTargetPath { get; set; }

            /// <summary>
            /// The type of the monitoring data. Valid values: Spring, Tomcat, Nginx, Tengine, JVM, Redis, and MySQL.
            /// </summary>
            [NameInMap("CollectTargetType")]
            [Validation(Required=false)]
            public string CollectTargetType { get; set; }

            /// <summary>
            /// The timeout period during which the CloudMonitor agent collects host monitoring data. Valid values:
            /// 
            /// *   0
            /// *   15
            /// *   30
            /// *   60
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("CollectTimout")]
            [Validation(Required=false)]
            public int? CollectTimout { get; set; }

            /// <summary>
            /// The timestamp when the metric import task was created.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the metric import task.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The additional information of the instance.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The instances where monitoring data is collected in batches.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            [NameInMap("LogFilePath")]
            [Validation(Required=false)]
            public string LogFilePath { get; set; }

            /// <summary>
            /// The method that is used to aggregate on-premises log data.
            /// </summary>
            [NameInMap("LogProcess")]
            [Validation(Required=false)]
            public string LogProcess { get; set; }

            /// <summary>
            /// The sample on-premises log.
            /// </summary>
            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }

            /// <summary>
            /// The result that is returned after on-premises log data is split based on the specified matching mode.
            /// 
            /// > The matching modes of on-premises log data include full regex mode, delimiter mode, and JSON mode.
            /// </summary>
            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public string LogSplit { get; set; }

            /// <summary>
            /// The conditions that are used to match the instances in the application group.
            /// </summary>
            [NameInMap("MatchExpress")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress> MatchExpress { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress : TeaModel {
                /// <summary>
                /// The method that is used to match the instance name. Valid values:
                /// 
                /// *   startWith: starts with a prefix
                /// *   endWith: ends with a suffix
                /// *   all: matches all
                /// *   equals: equals
                /// *   contains: contains
                /// *   notContains: does not contain
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The keyword that corresponds to the instance name.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The relationship between the conditions that are used to filter metric import tasks. Valid values:
            /// 
            /// *   or
            /// *   and
            /// </summary>
            [NameInMap("MatchExpressRelation")]
            [Validation(Required=false)]
            public string MatchExpressRelation { get; set; }

            /// <summary>
            /// The namespace to which the host belongs.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The network type of the host. Valid values:
            /// 
            /// *   `vpc`
            /// *   `Internet`
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The configurations of the logs that are imported from Log Service.
            /// </summary>
            [NameInMap("SLSProcess")]
            [Validation(Required=false)]
            public string SLSProcess { get; set; }

            /// <summary>
            /// The configurations of the logs that are imported from Log Service.
            /// 
            /// > This parameter is returned only if the `TaskType` parameter is set to `aliyun_sls`.
            /// </summary>
            [NameInMap("SLSProcessConfig")]
            [Validation(Required=false)]
            public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig SLSProcessConfig { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig : TeaModel {
                /// <summary>
                /// The extended fields that indicate the results of basic operations that are performed on aggregation results.
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress> Express { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress : TeaModel {
                    /// <summary>
                    /// The alias of the extended field that indicates the result of basic operations that are performed on aggregation results.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The extended field that indicates the result of basic operations that are performed on aggregation results.
                    /// </summary>
                    [NameInMap("Express")]
                    [Validation(Required=false)]
                    public string Express { get; set; }

                }

                /// <summary>
                /// The conditions that are used to filter logs imported from Log Service.
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter Filter { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter : TeaModel {
                    /// <summary>
                    /// The conditions that are used to filter logs imported from Log Service.
                    /// </summary>
                    [NameInMap("Filters")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters> Filters { get; set; }
                    public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters : TeaModel {
                        /// <summary>
                        /// The method that is used to filter logs imported from Log Service. Valid values:
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
                        /// The name of the key that is used to filter logs imported from Log Service.
                        /// </summary>
                        [NameInMap("SLSKeyName")]
                        [Validation(Required=false)]
                        public string SLSKeyName { get; set; }

                        /// <summary>
                        /// The value of the key that is used to filter logs imported from Log Service.
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
                /// The dimensions based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL.
                /// </summary>
                [NameInMap("GroupBy")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy> GroupBy { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy : TeaModel {
                    /// <summary>
                    /// The alias of the aggregation result.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The name of the key that is used to aggregate logs imported from Log Service.
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

                /// <summary>
                /// The methods that are used to aggregate logs imported from Log Service.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics> Statistics { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics : TeaModel {
                    /// <summary>
                    /// The alias of the aggregation result.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The function that is used to aggregate log data within a statistical period. Valid values:
                    /// 
                    /// *   count: counts the number.
                    /// *   sum: calculates the total value.
                    /// *   avg: calculates the average value.
                    /// *   max: calculates the maximum value.
                    /// *   min: calculates the minimum value.
                    /// *   value: collects samples within the statistical period.
                    /// *   countps: calculates the average number of the specified field per second by using the following formula: Counted number of the specified field/Total number of seconds within the statistical period.
                    /// *   sumps: calculates the average number of the specified field per second by using the following formula: Total value of the specified field/Total number of seconds within the statistical period.
                    /// *   distinct: counts the number of logs where the specified field appears within the statistical period.
                    /// *   distribution: counts the number of logs that meet a specified condition within the statistical period.
                    /// *   percentile: sorts the values of the specified field in ascending order, and then returns the value that is at the specified percentile within the statistical period. Example: P50.
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// The value of the function that is used to aggregate logs imported from Log Service.
                    /// 
                    /// *   If the `Function` parameter is set to `distribution`, this parameter indicates the lower limit of the statistical interval. For example, 200 indicates that the number of HTTP requests whose status code is 2XX is calculated.
                    /// *   If the `Function` parameter is set to `percentile`, this parameter specifies the percentile at which the expected value is. For example, 0.5 specifies P50.
                    /// </summary>
                    [NameInMap("Parameter1")]
                    [Validation(Required=false)]
                    public string Parameter1 { get; set; }

                    /// <summary>
                    /// The value of the function that is used to aggregate logs imported from Log Service.
                    /// 
                    /// > This parameter is returned only if the `Function` parameter is set to `distribution`. This parameter indicates the upper limit of the statistical interval. For example, 299 indicates that the number of HTTP requests whose status code is 2XX is calculated.
                    /// </summary>
                    [NameInMap("Parameter2")]
                    [Validation(Required=false)]
                    public string Parameter2 { get; set; }

                    /// <summary>
                    /// The name of the key that is used to aggregate logs imported from Log Service.
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

            }

            /// <summary>
            /// The ID of the member account.
            /// 
            /// > This parameter is displayed only when you call this operation by using a management account.
            /// </summary>
            [NameInMap("TargetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

            /// <summary>
            /// The ID of the metric import task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The name of the metric import task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the metric import task. Valid values:
            /// 
            /// *   aliyun_fc: metric import tasks for Alibaba Cloud services
            /// *   aliyun_sls: metrics for logs imported from Log Service
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The region where the host resides.
            /// </summary>
            [NameInMap("UploadRegion")]
            [Validation(Required=false)]
            public string UploadRegion { get; set; }

            /// <summary>
            /// The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.
            /// 
            /// *   namespace: the namespace of the Alibaba Cloud service.
            /// *   metric_list: the metrics of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("YARMConfig")]
            [Validation(Required=false)]
            public string YARMConfig { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
