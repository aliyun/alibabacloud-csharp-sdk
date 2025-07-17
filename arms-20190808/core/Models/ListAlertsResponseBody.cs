// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert.manager.error.code.signature.invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListAlertsResponseBodyPageBean PageBean { get; set; }
        public class ListAlertsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The queried alert notification history records.</para>
            /// </summary>
            [NameInMap("ListAlerts")]
            [Validation(Required=false)]
            public List<ListAlertsResponseBodyPageBeanListAlerts> ListAlerts { get; set; }
            public class ListAlertsResponseBodyPageBeanListAlerts : TeaModel {
                /// <summary>
                /// <para>Time to claim the alarm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("AcknowledgeTime")]
                [Validation(Required=false)]
                public long? AcknowledgeTime { get; set; }

                /// <summary>
                /// <para>The list of activities.</para>
                /// </summary>
                [NameInMap("Activities")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsActivities> Activities { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsActivities : TeaModel {
                    /// <summary>
                    /// <para>The content of the alert notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[Notification policy: Send notifications to DingTalk groups] Host monitoring. Host IP address: 10.76.XX.XX. Average memory usage of the host in the last 1 minute ≥ 1.0%. Current value: 84.7454%.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The description of the activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[Alert Claimed] The alert is claimed</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the handler.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>O\&amp;M Engineer A</para>
                    /// </summary>
                    [NameInMap("HandlerName")]
                    [Validation(Required=false)]
                    public string HandlerName { get; set; }

                    /// <summary>
                    /// <para>The operation time of the activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-12-20 19:08:57</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// <para>The type of the activity. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: The alert is claimed.</description></item>
                    /// <item><description>2: The alert is disclaimed.</description></item>
                    /// <item><description>3: A comment is added for the alert.</description></item>
                    /// <item><description>4: The alert is disabled.</description></item>
                    /// <item><description>5: An alert notification is sent.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                /// <summary>
                /// <para>The list of events.</para>
                /// </summary>
                [NameInMap("AlertEvents")]
                [Validation(Required=false)]
                public List<ListAlertsResponseBodyPageBeanListAlertsAlertEvents> AlertEvents { get; set; }
                public class ListAlertsResponseBodyPageBeanListAlertsAlertEvents : TeaModel {
                    /// <summary>
                    /// <para>The name of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test-triggered alert</para>
                    /// </summary>
                    [NameInMap("AlertName")]
                    [Validation(Required=false)]
                    public string AlertName { get; set; }

                    /// <summary>
                    /// <para>The annotations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;_aliyun_arms_alert_value&quot;:&quot;4.0&quot; &quot;_aliyun_arms_alert_traceId&quot;:&quot;ac10c43116421327442277073d5461-105075299&quot;}</para>
                    /// </summary>
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public string Annotations { get; set; }

                    /// <summary>
                    /// <para>The description of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Host monitoring. Host IP address: 10.76.XX.XX. Average memory usage of the host in the last 1 minute ≥ 1.0%. Current value: 84.7454%.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The time when the event ended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-19 17:10:31</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The URL of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://arms.console.aliyun.com">http://arms.console.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("GeneratorURL")]
                    [Validation(Required=false)]
                    public string GeneratorURL { get; set; }

                    /// <summary>
                    /// <para>The name of the integration that corresponds to the alert event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ARMS</para>
                    /// </summary>
                    [NameInMap("IntegrationName")]
                    [Validation(Required=false)]
                    public string IntegrationName { get; set; }

                    /// <summary>
                    /// <para>The type of the integration that corresponds to the alert event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ARMS</description></item>
                    /// <item><description>CLOUD_MONITOR</description></item>
                    /// <item><description>MSE</description></item>
                    /// <item><description>ARMS_CLOUD_DIALTEST</description></item>
                    /// <item><description>PROMETHEUS</description></item>
                    /// <item><description>LOG_SERVICE</description></item>
                    /// <item><description>CUSTOM</description></item>
                    /// <item><description>ARMS_PROMETHEUS</description></item>
                    /// <item><description>ARMS_APP_MON</description></item>
                    /// <item><description>ARMS_FRONT_MON</description></item>
                    /// <item><description>ARMS_CUSTOM</description></item>
                    /// <item><description>XTRACE</description></item>
                    /// <item><description>GRAFANA</description></item>
                    /// <item><description>ZABBIX</description></item>
                    /// <item><description>SKYWALKING</description></item>
                    /// <item><description>EVENT_BRIDGE</description></item>
                    /// <item><description>NAGIOS</description></item>
                    /// <item><description>OPENFALCON</description></item>
                    /// <item><description>ARMS_INSIGHTS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ARMS_APP_MON</para>
                    /// </summary>
                    [NameInMap("IntegrationType")]
                    [Validation(Required=false)]
                    public string IntegrationType { get; set; }

                    /// <summary>
                    /// <para>The tags.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;severity&quot;:&quot;warning&quot; &quot;_aliyun_arms_alert_level&quot;:&quot;ERROR&quot; &quot;_aliyun_arms_entropy&quot;:&quot;0.30170457417889235&quot;}</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    /// <summary>
                    /// <para>The time when the event was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-19 17:05:42</para>
                    /// </summary>
                    [NameInMap("ReceiveTime")]
                    [Validation(Required=false)]
                    public string ReceiveTime { get; set; }

                    /// <summary>
                    /// <para>The severity level of the event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>critical</description></item>
                    /// <item><description>error</description></item>
                    /// <item><description>warning</description></item>
                    /// <item><description>info</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warning</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The time when the event started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-01-18 00:14:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The status of the event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Active: The event is not cleared.</description></item>
                    /// <item><description>Silenced: The event is silenced.</description></item>
                    /// <item><description>Resolved: The event is cleared.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Active</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The alert ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2279</para>
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test alert</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The time when the alert was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-18 00:21:35</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of a event execution status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[Notification Strategy: ARMS Front-end Alarm]\nPage Indicator Page Name: Home JS Error Number Average in the last 5 minutes &gt;= 1.0 times, current value 1.0000 times\n</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>The ID of the notification policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("DispatchRuleId")]
                [Validation(Required=false)]
                public float? DispatchRuleId { get; set; }

                /// <summary>
                /// <para>The name of the notification policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingTalk Notification</para>
                /// </summary>
                [NameInMap("DispatchRuleName")]
                [Validation(Required=false)]
                public string DispatchRuleName { get; set; }

                /// <summary>
                /// <para>Alarm handler.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("Handler")]
                [Validation(Required=false)]
                public string Handler { get; set; }

                /// <summary>
                /// <para>The contact card of an instant messaging app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test Robot</para>
                /// </summary>
                [NameInMap("NotifyRobots")]
                [Validation(Required=false)]
                public string NotifyRobots { get; set; }

                /// <summary>
                /// <para>The notification object configured in the notification policy, responsible for handling alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Alarm recovery time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("RecoverTime")]
                [Validation(Required=false)]
                public long? RecoverTime { get; set; }

                /// <summary>
                /// <para>The severity level of the alert. Valid values: P6, P5, P4, P3, P2, and P1. The preceding values are listed in ascending order of severity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>P6</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The Alert solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--</para>
                /// </summary>
                [NameInMap("Solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

                /// <summary>
                /// <para>The status of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The alert is pending.</description></item>
                /// <item><description>1: The alert is being handled.</description></item>
                /// <item><description>2: The alert is handled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public long? State { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of alerts returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of queried alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FC13182-B9AF-4E6B-BE51-72669B7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
