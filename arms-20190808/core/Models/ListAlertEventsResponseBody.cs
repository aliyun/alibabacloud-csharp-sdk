// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertEventsResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListAlertEventsResponseBodyPageBean PageBean { get; set; }
        public class ListAlertEventsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The queried historical alert events.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<ListAlertEventsResponseBodyPageBeanEvents> Events { get; set; }
            public class ListAlertEventsResponseBodyPageBeanEvents : TeaModel {
                /// <summary>
                /// The associated alerts.
                /// </summary>
                [NameInMap("Alarms")]
                [Validation(Required=false)]
                public List<ListAlertEventsResponseBodyPageBeanEventsAlarms> Alarms { get; set; }
                public class ListAlertEventsResponseBodyPageBeanEventsAlarms : TeaModel {
                    /// <summary>
                    /// The ID of the alert.
                    /// </summary>
                    [NameInMap("AlarmId")]
                    [Validation(Required=false)]
                    public long? AlarmId { get; set; }

                    /// <summary>
                    /// The name of the alert.
                    /// </summary>
                    [NameInMap("AlarmName")]
                    [Validation(Required=false)]
                    public string AlarmName { get; set; }

                    /// <summary>
                    /// The time when the alert was created.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// The status of the alert. Valid values:
                    /// 
                    /// *   0: The alert is pending.
                    /// *   1: The alert is being handled.
                    /// *   2: The alert is cleared.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public int? State { get; set; }

                }

                /// <summary>
                /// The name of the alert.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The annotations.
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// The description of the alert event.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The end time.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The URL of the alert event.
                /// </summary>
                [NameInMap("GeneratorURL")]
                [Validation(Required=false)]
                public string GeneratorURL { get; set; }

                /// <summary>
                /// The user who handled the alert.
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// The name of the alert integration.
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// The type of the alert integration.
                /// </summary>
                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The associated notification policies.
                /// </summary>
                [NameInMap("NotificationPolicies")]
                [Validation(Required=false)]
                public List<ListAlertEventsResponseBodyPageBeanEventsNotificationPolicies> NotificationPolicies { get; set; }
                public class ListAlertEventsResponseBodyPageBeanEventsNotificationPolicies : TeaModel {
                    /// <summary>
                    /// The ID of the notification policy.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the notification policy.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The time when the alert event was received.
                /// </summary>
                [NameInMap("ReceiveTime")]
                [Validation(Required=false)]
                public string ReceiveTime { get; set; }

                /// <summary>
                /// The severity level of the alert. Valid values:
                /// 
                /// *   critical: P1
                /// *   error: P2
                /// *   warning: P3
                /// *   page: P4
                /// *   default: P6
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// The start time.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the alert event. Valid values:
                /// 
                /// *   Active
                /// *   Silenced
                /// *   Resolved
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The number of times the event is triggered.
                /// </summary>
                [NameInMap("TriggerCount")]
                [Validation(Required=false)]
                public long? TriggerCount { get; set; }

            }

            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
