// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
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

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PrometheusAlertRule")]
        [Validation(Required=false)]
        public CreatePrometheusAlertRuleResponseBodyPrometheusAlertRule PrometheusAlertRule { get; set; }
        public class CreatePrometheusAlertRuleResponseBodyPrometheusAlertRule : TeaModel {
            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// The annotations of the alert rule.
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations> Annotations { get; set; }
            public class CreatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations : TeaModel {
                /// <summary>
                /// The name of the annotation.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the annotation.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The ID of the notification policy.
            /// </summary>
            [NameInMap("DispatchRuleId")]
            [Validation(Required=false)]
            public long? DispatchRuleId { get; set; }

            /// <summary>
            /// The duration. The value ranges from 1 to 1440 minutes.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The expression of the alert rule.
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// The tags of the alert rule.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels> Labels { get; set; }
            public class CreatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels : TeaModel {
                /// <summary>
                /// The name of the tag.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The content of the alert notification. Tags can be referenced in the {{$labels.xxx}} format.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The method that is used to send alert notifications. Valid values:
            /// 
            /// - ALERT_MANAGER: Alert notifications are sent by Operation Center.
            /// - DISPATCH_RULE: Alert notifications are sent based on the specified notification policy.
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// Indicates whether the alert rule is enabled. Valid values:
            /// 
            /// - `1`: The alert rule is enabled.
            /// - `0`: The alert rule is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of the alert rule.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
