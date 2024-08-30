// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusAlertRuleRequest : TeaModel {
        /// <summary>
        /// The name of the alert rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// The annotations that are described in a JSON string. You must specify the name and value of each annotation.
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the notification policy. This parameter is required if the NotifyType parameter is set to `DISPATCH_RULE`.
        /// </summary>
        [NameInMap("DispatchRuleId")]
        [Validation(Required=false)]
        public long? DispatchRuleId { get; set; }

        /// <summary>
        /// The duration. The value ranges from 1 to 1440 minutes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The expression of the alert rule. The expression must follow the PromQL syntax.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The tags that are described in a JSON string. You must specify the name and value of each tag.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The content of the alert notification. Tags can be referenced in the {{$labels.xxx}} format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The method that is used to send alert notifications. Valid values:
        /// 
        /// - `ALERT_MANAGER`: Alert notifications are sent by Operation Center. This is the default value.
        /// - `DISPATCH_RULE`: Alert notifications are sent based on the specified notification policy.
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusAlertRuleRequestTags> Tags { get; set; }
        public class CreatePrometheusAlertRuleRequestTags : TeaModel {
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
        /// The type of the alert rule. Valid values:
        /// 
        /// - 99: custom alert
        /// - 101: Prometheus Service alert
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
