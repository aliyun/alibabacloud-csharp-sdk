// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PrometheusAlertRule")]
        [Validation(Required=false)]
        public UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRule PrometheusAlertRule { get; set; }
        public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRule : TeaModel {
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations> Annotations { get; set; }
            public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations : TeaModel {
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
            public List<UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels> Labels { get; set; }
            public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels : TeaModel {
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

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
