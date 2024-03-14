// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class DescribePrometheusAlertRuleResponseBody : TeaModel {
        [NameInMap("PrometheusAlertRule")]
        [Validation(Required=false)]
        public DescribePrometheusAlertRuleResponseBodyPrometheusAlertRule PrometheusAlertRule { get; set; }
        public class DescribePrometheusAlertRuleResponseBodyPrometheusAlertRule : TeaModel {
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<DescribePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations> Annotations { get; set; }
            public class DescribePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("DispatchRuleId")]
            [Validation(Required=false)]
            public long? DispatchRuleId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels> Labels { get; set; }
            public class DescribePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
