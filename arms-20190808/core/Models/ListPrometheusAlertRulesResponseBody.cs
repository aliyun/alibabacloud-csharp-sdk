// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertRulesResponseBody : TeaModel {
        [NameInMap("PrometheusAlertRules")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRules> PrometheusAlertRules { get; set; }
        public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRules : TeaModel {
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations : TeaModel {
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
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels> Labels { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels : TeaModel {
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

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags> Tags { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
