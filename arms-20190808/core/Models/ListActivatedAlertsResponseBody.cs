// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListActivatedAlertsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListActivatedAlertsResponseBodyPage Page { get; set; }
        public class ListActivatedAlertsResponseBodyPage : TeaModel {
            /// <summary>
            /// The alerts that have been triggered.
            /// </summary>
            [NameInMap("Alerts")]
            [Validation(Required=false)]
            public List<ListActivatedAlertsResponseBodyPageAlerts> Alerts { get; set; }
            public class ListActivatedAlertsResponseBodyPageAlerts : TeaModel {
                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public string AlertId { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The type of the alert.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// The number of times that the alert event was received.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The timestamp when the alert rule was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The notification policies.
                /// </summary>
                [NameInMap("DispatchRules")]
                [Validation(Required=false)]
                public List<ListActivatedAlertsResponseBodyPageAlertsDispatchRules> DispatchRules { get; set; }
                public class ListActivatedAlertsResponseBodyPageAlertsDispatchRules : TeaModel {
                    /// <summary>
                    /// The ID of the notification policy.
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public int? RuleId { get; set; }

                    /// <summary>
                    /// The name of the notification policy.
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                /// <summary>
                /// The timestamp when the alert was ended.
                /// </summary>
                [NameInMap("EndsAt")]
                [Validation(Required=false)]
                public long? EndsAt { get; set; }

                /// <summary>
                /// The extended fields that indicate the following tags:
                /// 
                /// *   The tags that are carried in the metrics of the alert rule expression.
                /// *   The tags that are created based on the alert rule.
                /// *   The default tags of Application Real-Time Monitoring Service (ARMS).
                /// </summary>
                [NameInMap("ExpandFields")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExpandFields { get; set; }

                /// <summary>
                /// The name of the object that is associated with the alert.
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// The type of the service integration that generated the alert.
                /// </summary>
                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// The type of the object that is associated with the alert.
                /// </summary>
                [NameInMap("InvolvedObjectKind")]
                [Validation(Required=false)]
                public string InvolvedObjectKind { get; set; }

                /// <summary>
                /// The name of the service integration that generated the alert.
                /// </summary>
                [NameInMap("InvolvedObjectName")]
                [Validation(Required=false)]
                public string InvolvedObjectName { get; set; }

                /// <summary>
                /// The description of the alert.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The level of the alert. Valid values:
                /// 
                /// *   `critical`
                /// *   `error`
                /// *   `warn`
                /// *   `page`
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// The timestamp when the alert was generated.
                /// </summary>
                [NameInMap("StartsAt")]
                [Validation(Required=false)]
                public long? StartsAt { get; set; }

                /// <summary>
                /// The status of the alert. Valid values:
                /// 
                /// *   `Active`
                /// *   `Inhibited`
                /// *   `Silenced`
                /// *   `Resolved`
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
