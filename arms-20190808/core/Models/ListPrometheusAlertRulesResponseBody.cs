// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertRulesResponseBody : TeaModel {
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

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PrometheusAlertRules")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRules> PrometheusAlertRules { get; set; }
        public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRules : TeaModel {
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
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations : TeaModel {
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
            /// The ID of the notification policy. This parameter is returned if the NotifyType parameter is set to `DISPATCH_RULE`.
            /// </summary>
            [NameInMap("DispatchRuleId")]
            [Validation(Required=false)]
            public long? DispatchRuleId { get; set; }

            /// <summary>
            /// The duration of the alert. Valid values: 1 to 1440. Unit: minutes.
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
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels> Labels { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels : TeaModel {
                /// <summary>
                /// The name of the tag.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the tag associated with the instance.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The alert message. Tags can be referenced in the {{$labels.xxx}} format.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The method that is used to send alert notifications. Valid values:
            /// 
            /// - ALERT_MANAGER: Alert notifications are sent by Operation Center.
            /// - DISPATCH_RULE: Alert notifications are
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// Indicates whether the alert rule is enabled. Valid values:
            /// 
            /// - 1: The alert rule is enabled.
            /// - 0: The alert rule is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags> Tags { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
