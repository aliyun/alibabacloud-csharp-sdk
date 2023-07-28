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
                        /// The consecutive number of times for which the metric value is measured before an alert is triggered.
                        /// </summary>
                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public string EvaluationCount { get; set; }

                        /// <summary>
                        /// The name of the metric. For more information, see [Appendix 1: Metrics](~~163515~~).
                        /// </summary>
                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        /// <summary>
                        /// The namespace of the service. For more information, see [Appendix 1: Metrics](~~163515~~).
                        /// </summary>
                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        /// <summary>
                        /// The aggregation period of the monitoring data. Unit: minutes. For more information, see [Appendix 1: Metrics](~~163515~~).
                        /// </summary>
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        /// <summary>
                        /// The statistical aggregation method that is used to calculate metric values that trigger alerts. For more information, see [Appendix 1: Metrics](~~163515~~).
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// The threshold of the metric value.
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                    }

                }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
