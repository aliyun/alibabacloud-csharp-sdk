// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about the array object.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListAlertsResponseBodyPageBean PageBean { get; set; }
        public class ListAlertsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The alerts for which the alert sending history is queried.
            /// </summary>
            [NameInMap("ListAlerts")]
            [Validation(Required=false)]
            public List<ListAlertsResponseBodyPageBeanListAlerts> ListAlerts { get; set; }
            public class ListAlertsResponseBodyPageBeanListAlerts : TeaModel {
                [NameInMap("AcknowledgeTime")]
                [Validation(Required=false)]
                public long? AcknowledgeTime { get; set; }

                /// <summary>
                /// The list of activities.
                /// </summary>
                [NameInMap("Activities")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsActivities> Activities { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsActivities : TeaModel {
                    /// <summary>
                    /// The content of the alert notification.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The description of the activity.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the handler.
                    /// </summary>
                    [NameInMap("HandlerName")]
                    [Validation(Required=false)]
                    public string HandlerName { get; set; }

                    /// <summary>
                    /// The operation time of the activity.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// The type of the activity. Valid values:
                    /// 
                    /// *   1: The alert is claimed.
                    /// *   2: The alert is disclaimed.
                    /// *   3: A comment is added for the alert.
                    /// *   4: The alert is disabled.
                    /// *   5: An alert notification is sent.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                /// <summary>
                /// The list of events.
                /// </summary>
                [NameInMap("AlertEvents")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsAlertEvents> AlertEvents { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsAlertEvents : TeaModel {
                    /// <summary>
                    /// The name of the event.
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
                    /// The description of the event.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The time when the event ended.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// The URL of the event.
                    /// </summary>
                    [NameInMap("GeneratorURL")]
                    [Validation(Required=false)]
                    public string GeneratorURL { get; set; }

                    /// <summary>
                    /// The name of the integration that corresponds to the alert event.
                    /// </summary>
                    [NameInMap("IntegrationName")]
                    [Validation(Required=false)]
                    public string IntegrationName { get; set; }

                    /// <summary>
                    /// The type of the integration that corresponds to the alert event. Valid values:
                    /// 
                    /// *   ARMS
                    /// *   CLOUD_MONITOR
                    /// *   MSE
                    /// *   ARMS_CLOUD_DIALTEST
                    /// *   PROMETHEUS
                    /// *   LOG_SERVICE
                    /// *   CUSTOM
                    /// *   ARMS_PROMETHEUS
                    /// *   ARMS_APP_MON
                    /// *   ARMS_FRONT_MON
                    /// *   ARMS_CUSTOM
                    /// *   XTRACE
                    /// *   GRAFANA
                    /// *   ZABBIX
                    /// *   SKYWALKING
                    /// *   EVENT_BRIDGE
                    /// *   NAGIOS
                    /// *   OPENFALCON
                    /// *   ARMS_INSIGHTS
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
                    /// The time when the event was created.
                    /// </summary>
                    [NameInMap("ReceiveTime")]
                    [Validation(Required=false)]
                    public string ReceiveTime { get; set; }

                    /// <summary>
                    /// The severity level of the event. Valid values:
                    /// 
                    /// *   critical
                    /// *   error
                    /// *   warning
                    /// *   info
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// The time when the event started.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// The status of the event. Valid values:
                    /// 
                    /// *   Active: The event is not cleared.
                    /// *   Silenced: The event is silenced.
                    /// *   Resolved: The event is cleared.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// The alert ID.
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
                /// The time when the alert was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// The ID of the notification policy.
                /// </summary>
                [NameInMap("DispatchRuleId")]
                [Validation(Required=false)]
                public float? DispatchRuleId { get; set; }

                /// <summary>
                /// The name of the notification policy.
                /// </summary>
                [NameInMap("DispatchRuleName")]
                [Validation(Required=false)]
                public string DispatchRuleName { get; set; }

                [NameInMap("Handler")]
                [Validation(Required=false)]
                public string Handler { get; set; }

                [NameInMap("NotifyRobots")]
                [Validation(Required=false)]
                public string NotifyRobots { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("RecoverTime")]
                [Validation(Required=false)]
                public long? RecoverTime { get; set; }

                /// <summary>
                /// The severity level of the alert. Valid values: P6, P5, P4, P3, P2, and P1. The preceding values are listed in ascending order of severity.
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// The Alert solution.
                /// </summary>
                [NameInMap("Solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

                /// <summary>
                /// The status of the alert. Valid values:
                /// 
                /// *   0: The alert is pending.
                /// *   1: The alert is being handled.
                /// *   2: The alert is handled.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public long? State { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alerts returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of queried alerts.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
