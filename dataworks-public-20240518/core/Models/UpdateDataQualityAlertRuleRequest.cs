// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert condition of the data quality monitoring alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The alert rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105412</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The alert notification configuration.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public UpdateDataQualityAlertRuleRequestNotification Notification { get; set; }
        public class UpdateDataQualityAlertRuleRequestNotification : TeaModel {
            /// <summary>
            /// <para>The list of notification channels. You can set both Email and Sms at the same time. In other cases, only one channel can be specified.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<string> Channels { get; set; }

            /// <summary>
            /// <para>The alert recipients.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<UpdateDataQualityAlertRuleRequestNotificationReceivers> Receivers { get; set; }
            public class UpdateDataQualityAlertRuleRequestNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The additional configuration required for the alert recipient. When ReceiverType is set to DingdingUrl, you can set <c>{&quot;atAll&quot;:true}</c> to @ all members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:true}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The alerting accept object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AliUid</description></item>
                /// <item><description>WebhookUrl</description></item>
                /// <item><description>DingdingUrl</description></item>
                /// <item><description>WeixinUrl</description></item>
                /// <item><description>FeishuUrl</description></item>
                /// <item><description>TaskOwner</description></item>
                /// <item><description>DataQualityScanOwner</description></item>
                /// <item><description>ShiftSchedule</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TaskOwner</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The values of the alert recipients.</para>
                /// </summary>
                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The monitoring target of the data quality monitoring alert rule.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public UpdateDataQualityAlertRuleRequestTarget Target { get; set; }
        public class UpdateDataQualityAlertRuleRequestTarget : TeaModel {
            /// <summary>
            /// <para>The list of monitoring target IDs. Currently, only one ID can be specified.</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<long?> Ids { get; set; }

            /// <summary>
            /// <para>The type of the monitored object. Only DataQualityScan is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQualityScan</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
