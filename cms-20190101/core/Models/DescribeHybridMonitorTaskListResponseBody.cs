// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The configurations of the logs that are imported from Log Service.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The method that is used to aggregate on-premises log data.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The conditions that are used to match the instances in the application group.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The alias of the extended field that indicates the result of basic operations that are performed on aggregation results.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The ID of the metric import task.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorTaskListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeHybridMonitorTaskListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// The method that is used to match the instance name. Valid values:
            /// 
            /// *   startWith: starts with a prefix
            /// *   endWith: ends with a suffix
            /// *   all: includes all
            /// *   equals: equals
            /// *   contains: contains
            /// *   notContains: excludes
            /// </summary>
            [NameInMap("AttachLabels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels> AttachLabels { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels : TeaModel {
                /// <summary>
                /// The name of the key that is used to aggregate logs imported from Log Service.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of entries to return on each page.
                /// 
                /// Minimum value: 1. Default value: 10.
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
            [NameInMap("CollectInterval")]
            [Validation(Required=false)]
            public int? CollectInterval { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("CollectTargetEndpoint")]
            [Validation(Required=false)]
            public string CollectTargetEndpoint { get; set; }

            /// <summary>
            /// The conditions that are used to filter logs imported from Log Service.
            /// </summary>
            [NameInMap("CollectTargetPath")]
            [Validation(Required=false)]
            public string CollectTargetPath { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("CollectTargetType")]
            [Validation(Required=false)]
            public string CollectTargetType { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// 
            /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](~~428880~~).
            /// </summary>
            [NameInMap("CollectTimout")]
            [Validation(Required=false)]
            public int? CollectTimout { get; set; }

            /// <summary>
            /// The metric import tasks.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The result that is returned after on-premises log data is split based on the specified matching mode.
            /// 
            /// >  The matching modes of on-premises log data include full regex mode, delimiter mode, and JSON mode.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The network type of the host. Valid values:
            /// 
            /// *   `vpc`: a virtual private cloud (VPC)
            /// *   `Internet`: Internet
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// The name of the metric import task.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the key that is used to filter logs imported from Log Service.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// The relationship between multiple filter conditions. Valid values:
            /// 
            /// *   and (default value): Logs are processed only if all filter conditions are met.
            /// *   or: Logs are processed if one of the filter conditions is met.
            /// </summary>
            [NameInMap("LogFilePath")]
            [Validation(Required=false)]
            public string LogFilePath { get; set; }

            /// <summary>
            /// The description of the metric import task.
            /// </summary>
            [NameInMap("LogProcess")]
            [Validation(Required=false)]
            public string LogProcess { get; set; }

            /// <summary>
            /// The type of the metric import task. Valid values:
            /// 
            /// *   aliyun_fc: metric import tasks for Alibaba Cloud services
            /// *   aliyun_sls: metrics for logs imported from Log Service
            /// </summary>
            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public string LogSplit { get; set; }

            /// <summary>
            /// The returned message.
            /// 
            /// *   If the call is successful, the value `successful` is returned.
            /// *   If the call fails, an error message is returned.
            /// </summary>
            [NameInMap("MatchExpress")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress> MatchExpress { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress : TeaModel {
                /// <summary>
                /// The extended fields that indicate the results of basic operations that are performed on aggregation results.
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The number of the page to return.
                /// 
                /// Pages start from page 1. Default value: 1.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The URL of the destination from which the CloudMonitor agent collects host monitoring data.
            /// </summary>
            [NameInMap("MatchExpressRelation")]
            [Validation(Required=false)]
            public string MatchExpressRelation { get; set; }

            /// <summary>
            /// The relative path from which the CloudMonitor agent collects monitoring data.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The keyword that corresponds to the instance name.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// Specifies whether the returned result includes metric import tasks for Alibaba Cloud services. Valid values:
            /// 
            /// *   true (default value): includes metric import tasks for Alibaba Cloud services.
            /// *   false: excludes metric import tasks for Alibaba Cloud services.
            /// </summary>
            [NameInMap("SLSProcess")]
            [Validation(Required=false)]
            public string SLSProcess { get; set; }

            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("SLSProcessConfig")]
            [Validation(Required=false)]
            public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig SLSProcessConfig { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig : TeaModel {
                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress> Express { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("Express")]
                    [Validation(Required=false)]
                    public string Express { get; set; }

                }

                /// <summary>
                /// The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL.
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter Filter { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter : TeaModel {
                    /// <summary>
                    /// The extended field that indicates the result of basic operations that are performed on aggregation results.
                    /// </summary>
                    [NameInMap("Filters")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters> Filters { get; set; }
                    public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters : TeaModel {
                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// The type of the monitoring data. Valid values: Spring, Tomcat, Nginx, Tengine, JVM, Redis, and MySQL.
                        /// </summary>
                        [NameInMap("SLSKeyName")]
                        [Validation(Required=false)]
                        public string SLSKeyName { get; set; }

                        /// <summary>
                        /// The page number of the returned page.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The ID of the member account.
                    /// 
                    /// >  This parameter is required only if you call this operation to delete metric import tasks that belong to a member in a resource directory. In this case, the `TaskType` parameter is set to `aliyun_fc`.
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                }

                /// <summary>
                /// The sample on-premises log.
                /// </summary>
                [NameInMap("GroupBy")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy> GroupBy { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy : TeaModel {
                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// The alias of the aggregation result.
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics> Statistics { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    [NameInMap("Parameter1")]
                    [Validation(Required=false)]
                    public string Parameter1 { get; set; }

                    [NameInMap("Parameter2")]
                    [Validation(Required=false)]
                    public string Parameter2 { get; set; }

                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

            }

            /// <summary>
            /// The ID of the metric import task.
            /// </summary>
            [NameInMap("TargetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

            /// <summary>
            /// The configurations of the logs that are imported from Log Service.
            /// 
            /// >  This parameter is returned only if the `TaskType` parameter is set to `aliyun_sls`.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The region where the host resides.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The ID of the member account.
            /// 
            /// >  This parameter is returned only if you call this operation by using a management account.
            /// </summary>
            [NameInMap("UploadRegion")]
            [Validation(Required=false)]
            public string UploadRegion { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// 
            /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](~~115032~~).
            /// </summary>
            [NameInMap("YARMConfig")]
            [Validation(Required=false)]
            public string YARMConfig { get; set; }

        }

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
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
