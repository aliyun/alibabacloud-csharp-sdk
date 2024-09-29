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
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListActivatedAlertsResponseBodyPage Page { get; set; }
        public class ListActivatedAlertsResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The alerts that have been triggered.</para>
            /// </summary>
            [NameInMap("Alerts")]
            [Validation(Required=false)]
            public List<ListActivatedAlertsResponseBodyPageAlerts> Alerts { get; set; }
            public class ListActivatedAlertsResponseBodyPageAlerts : TeaModel {
                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3888704</para>
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public string AlertId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Container CPU usage is greater than 80%</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The type of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROMETHEUS_MONITORING_ALERT_RULE</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The number of times that the alert event was received.</para>
                /// 
                /// <b>Example:</b>
                /// <para>598</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The timestamp when the alert rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616466300000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The notification policies.</para>
                /// </summary>
                [NameInMap("DispatchRules")]
                [Validation(Required=false)]
                public List<ListActivatedAlertsResponseBodyPageAlertsDispatchRules> DispatchRules { get; set; }
                public class ListActivatedAlertsResponseBodyPageAlertsDispatchRules : TeaModel {
                    /// <summary>
                    /// <para>The ID of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7021</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public int? RuleId { get; set; }

                    /// <summary>
                    /// <para>The name of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NotificationPolicy1</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the alert was ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616502540000</para>
                /// </summary>
                [NameInMap("EndsAt")]
                [Validation(Required=false)]
                public long? EndsAt { get; set; }

                /// <summary>
                /// <para>The extended fields that indicate the following tags:</para>
                /// <list type="bullet">
                /// <item><description>The tags that are carried in the metrics of the alert rule expression.</description></item>
                /// <item><description>The tags that are created based on the alert rule.</description></item>
                /// <item><description>The default tags of Application Real-Time Monitoring Service (ARMS).</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExpandFields")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExpandFields { get; set; }

                /// <summary>
                /// <para>The name of the object that is associated with the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testphp2</para>
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// <para>The type of the service integration that generated the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROMETHEUS</para>
                /// </summary>
                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// <para>The type of the object that is associated with the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("InvolvedObjectKind")]
                [Validation(Required=false)]
                public string InvolvedObjectKind { get; set; }

                /// <summary>
                /// <para>The name of the service integration that generated the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test integration-prometheus</para>
                /// </summary>
                [NameInMap("InvolvedObjectName")]
                [Validation(Required=false)]
                public string InvolvedObjectName { get; set; }

                /// <summary>
                /// <para>The description of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alarm name: PodRestart_testphp2,\n Pod night-test-group-1-1-5f5d6f4d84-pszns is restart, Value: 133.33%, 1.33%</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The level of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>critical</c></description></item>
                /// <item><description><c>error</c></description></item>
                /// <item><description><c>warn</c></description></item>
                /// <item><description><c>page</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>critical</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The timestamp when the alert was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1616466300000</para>
                /// </summary>
                [NameInMap("StartsAt")]
                [Validation(Required=false)]
                public long? StartsAt { get; set; }

                /// <summary>
                /// <para>The status of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Active</c></description></item>
                /// <item><description><c>Inhibited</c></description></item>
                /// <item><description><c>Silenced</c></description></item>
                /// <item><description><c>Resolved</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDB74B8F-4123-482A-ABB7-7F440349****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
