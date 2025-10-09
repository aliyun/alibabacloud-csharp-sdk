// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert condition of the data quality monitoring rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The list of alert channels.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public CreateDataQualityAlertRuleRequestNotification Notification { get; set; }
        public class CreateDataQualityAlertRuleRequestNotification : TeaModel {
            /// <summary>
            /// <para>The list of alert channels. You can set both <c>Email</c> and <c>Sms</c> at the same time. In other cases, only one channel can be set.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<string> Channels { get; set; }

            /// <summary>
            /// <para>The alert recipients.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<CreateDataQualityAlertRuleRequestNotificationReceivers> Receivers { get; set; }
            public class CreateDataQualityAlertRuleRequestNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>Additional configurations required for the alert recipients. When ReceiverType is DingdingUrl, you can set <c>{&quot;atAll&quot;:true}</c> to mention all members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:true}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The type of alert recipients.</para>
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
                /// <para>The value of alert recipients.</para>
                /// </summary>
                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The monitored target of the data quality monitoring rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public CreateDataQualityAlertRuleRequestTarget Target { get; set; }
        public class CreateDataQualityAlertRuleRequestTarget : TeaModel {
            /// <summary>
            /// <para>The list of monitored target IDs. Currently, only one ID can be set.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<long?> Ids { get; set; }

            /// <summary>
            /// <para>The type of the monitored target. Only DataQualityScan is supported.</para>
            /// <para>This parameter is required.</para>
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
