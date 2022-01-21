// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProductsOfActiveMetricRuleResponseBody : TeaModel {
        [NameInMap("AllProductInitMetricRuleList")]
        [Validation(Required=false)]
        public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList AllProductInitMetricRuleList { get; set; }
        public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList : TeaModel {
            [NameInMap("AllProductInitMetricRule")]
            [Validation(Required=false)]
            public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule> AllProductInitMetricRule { get; set; }
            public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule : TeaModel {
                public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList AlertInitConfigList { get; set; }
                public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList : TeaModel {
                    [NameInMap("AlertInitConfig")]
                    [Validation(Required=false)]
                    public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig> AlertInitConfig { get; set; }
                    public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig : TeaModel {
                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public string EvaluationCount { get; set; }

                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                    }

                }
                public string Product { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
