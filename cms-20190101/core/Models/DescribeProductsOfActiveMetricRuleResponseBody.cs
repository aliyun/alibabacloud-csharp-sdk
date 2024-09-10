// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProductsOfActiveMetricRuleResponseBody : TeaModel {
        /// <summary>
        /// The information about the services for which one-click alert is enabled.
        /// </summary>
        [NameInMap("AllProductInitMetricRuleList")]
        [Validation(Required=false)]
        public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList AllProductInitMetricRuleList { get; set; }
        public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList : TeaModel {
            [NameInMap("AllProductInitMetricRule")]
            [Validation(Required=false)]
            public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule> AllProductInitMetricRule { get; set; }
            public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule : TeaModel {
                /// <summary>
                /// The initial alert rules that are generated after one-click alert is enabled for a service.
                /// </summary>
                [NameInMap("AlertInitConfigList")]
                [Validation(Required=false)]
                public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList AlertInitConfigList { get; set; }
                public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList : TeaModel {
                    [NameInMap("AlertInitConfig")]
                    [Validation(Required=false)]
                    public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig> AlertInitConfig { get; set; }
                    public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig : TeaModel {
                        /// <summary>
                        /// The operator that is used to compare the metric value with the threshold for Warn-level alerts.
                        /// 
                        /// Valid values:
                        /// 
                        /// *   LessThanThreshold: less than the threshold
                        /// 
                        /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                        /// 
                        /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                        /// 
                        /// *   NotEqualToThreshold: does not equal to the threshold
                        /// 
                        /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                        /// 
                        /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                        /// 
                        /// *   LessThanYesterday: less than the metric value at the same time yesterday
                        /// 
                        /// *   LessThanLastWeek: less than the metric value at the same time last week
                        /// 
                        /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                        /// 
                        /// *   GreaterThanThreshold: greater than the threshold
                        /// 
                        /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                        /// </summary>
                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public string EvaluationCount { get; set; }

                        /// <summary>
                        /// The alert level.
                        /// 
                        /// Valid values:
                        /// 
                        /// *   INFO
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// 
                        /// *   WARN
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// 
                        /// *   CRITICAL
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// 
                        ///     <!-- -->
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// The metric name. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                        /// </summary>
                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        /// <summary>
                        /// The namespace of the service. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                        /// </summary>
                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        /// <summary>
                        /// The aggregation period of monitoring data. Unit: minutes. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                        /// </summary>
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        /// <summary>
                        /// The method used to calculate metric values that trigger alerts. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The alert threshold.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                    }

                }

                /// <summary>
                /// The abbreviation of the service name.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the services for which one-click alert is enabled. Services are separated with commas (,). Valid values:
        /// 
        /// *   ecs: Elastic Compute Service (ECS)
        /// *   rds: ApsaraDB RDS
        /// *   slb: Server Load Balancer (SLB)
        /// *   redis_standard: ApsaraDB for Redis of the standard architecture
        /// *   redis_sharding: ApsaraDB for Redis of the cluster architecture
        /// *   redis_splitrw: ApsaraDB for Redis of the read/write splitting architecture
        /// *   mongodb: ApsaraDB for MongoDB of the replica set architecture
        /// *   mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture
        /// *   hbase: ApsaraDB for HBase
        /// *   elasticsearch: Elasticsearch
        /// *   opensearch: OpenSearch
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
