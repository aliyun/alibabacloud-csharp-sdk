// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListAlertEventsResponseBodyPageBean PageBean { get; set; }
        public class ListAlertEventsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The queried historical alert events.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<ListAlertEventsResponseBodyPageBeanEvents> Events { get; set; }
            public class ListAlertEventsResponseBodyPageBeanEvents : TeaModel {
                /// <summary>
                /// <para>The associated alerts.</para>
                /// </summary>
                [NameInMap("Alarms")]
                [Validation(Required=false)]
                public List<ListAlertEventsResponseBodyPageBeanEventsAlarms> Alarms { get; set; }
                public class ListAlertEventsResponseBodyPageBeanEventsAlarms : TeaModel {
                    /// <summary>
                    /// <para>The ID of the alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77444</para>
                    /// </summary>
                    [NameInMap("AlarmId")]
                    [Validation(Required=false)]
                    public long? AlarmId { get; set; }

                    /// <summary>
                    /// <para>The name of the alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test-triggered alert</para>
                    /// </summary>
                    [NameInMap("AlarmName")]
                    [Validation(Required=false)]
                    public string AlarmName { get; set; }

                    /// <summary>
                    /// <para>The time when the alert was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-12-20 07:10:18</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The status of the alert. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: The alert is pending.</description></item>
                    /// <item><description>1: The alert is being handled.</description></item>
                    /// <item><description>2: The alert is cleared.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public int? State { get; set; }

                }

                /// <summary>
                /// <para>The name of the alert.</para>
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
                /// <para>[{\&quot;Name\&quot;:\&quot;annotation-a\&quot;,\&quot;Value\&quot;:\&quot;annotation a value\&quot;}]</para>
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// <para>The description of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20 17:42:16</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The URL of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx.xx/">https://xxx.xx/</a></para>
                /// </summary>
                [NameInMap("GeneratorURL")]
                [Validation(Required=false)]
                public string GeneratorURL { get; set; }

                /// <summary>
                /// <para>The user who handled the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// <para>The name of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom integration</para>
                /// </summary>
                [NameInMap("IntegrationName")]
                [Validation(Required=false)]
                public string IntegrationName { get; set; }

                /// <summary>
                /// <para>The type of the alert integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;name\&quot;:\&quot;severity\&quot;,\&quot;value\&quot;:\&quot;error\&quot;}]</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The associated notification policies.</para>
                /// </summary>
                [NameInMap("NotificationPolicies")]
                [Validation(Required=false)]
                public List<ListAlertEventsResponseBodyPageBeanEventsNotificationPolicies> NotificationPolicies { get; set; }
                public class ListAlertEventsResponseBodyPageBeanEventsNotificationPolicies : TeaModel {
                    /// <summary>
                    /// <para>The ID of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>646093</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>P1 alert notification policy</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The time when the alert event was received.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20 17:42:16</para>
                /// </summary>
                [NameInMap("ReceiveTime")]
                [Validation(Required=false)]
                public string ReceiveTime { get; set; }

                /// <summary>
                /// <para>The severity level of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>critical: P1</description></item>
                /// <item><description>error: P2</description></item>
                /// <item><description>warning: P3</description></item>
                /// <item><description>page: P4</description></item>
                /// <item><description>default: P6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>critical</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-20 17:42:16</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the alert event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Active</description></item>
                /// <item><description>Silenced</description></item>
                /// <item><description>Resolved</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of times the event is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TriggerCount")]
                [Validation(Required=false)]
                public long? TriggerCount { get; set; }

            }

            /// <summary>
            /// <para>The number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FC13182-B9AF-4E6B-BE51-72669B7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
