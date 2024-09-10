// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorTaskRequest : TeaModel {
        /// <summary>
        /// The tags of the metric.
        /// </summary>
        [NameInMap("AttachLabels")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorTaskRequestAttachLabels> AttachLabels { get; set; }
        public class ModifyHybridMonitorTaskRequestAttachLabels : TeaModel {
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

        /// <summary>
        /// The collection period of the metric. Valid values:
        /// 
        /// *   15
        /// *   60
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        /// <summary>
        /// The description of the metric import task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configurations of the logs that are imported from Log Service.
        /// </summary>
        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public ModifyHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class ModifyHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            /// <summary>
            /// The extended fields that specify the results of basic operations performed on aggregation results.
            /// </summary>
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
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
            /// The conditions that are used to filter logs imported from Log Service.
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public ModifyHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                /// <summary>
                /// None
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
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
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
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
            /// None
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
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
                /// *   countps: calculates the counted number of the specified field divided by the total number of seconds within the statistical period.
                /// *   sumps: calculates the total value of the specified field divided by the total number of seconds within the statistical period.
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
                /// *   If the `Function` parameter is set to `distribution`, this parameter specifies the lower limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 200.
                /// *   If you set the `Function` parameter to `percentile`, this parameter specifies the percentile at which the expected value is. For example, 0.5 specifies P50.
                /// </summary>
                [NameInMap("Parameter1")]
                [Validation(Required=false)]
                public string Parameter1 { get; set; }

                /// <summary>
                /// The value of the function that is used to aggregate logs imported from Log Service.
                /// 
                /// > This parameter must be specified when `Function` is set to `distribution`. This parameter specifies the upper limit of the statistical interval. For example, if you want to calculate the number of HTTP requests whose status code is 2XX, set this parameter to 299.
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
        /// The ID of the metric import task.
        /// 
        /// For information about how to obtain the ID of a metric import task, see [DescribeHybridMonitorTaskList](https://help.aliyun.com/document_detail/428624.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The name of the metric import task.
        /// 
        /// For information about how to obtain the ID of a metric import task, see [DescribeHybridMonitorTaskList](https://help.aliyun.com/document_detail/428624.html).
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
