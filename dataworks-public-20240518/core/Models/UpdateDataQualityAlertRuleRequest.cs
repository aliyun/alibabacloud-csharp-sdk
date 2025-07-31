// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityAlertRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>105412</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public UpdateDataQualityAlertRuleRequestNotification Notification { get; set; }
        public class UpdateDataQualityAlertRuleRequestNotification : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<string> Channels { get; set; }

            [NameInMap("Receivers")]
            [Validation(Required=false)]
            public List<UpdateDataQualityAlertRuleRequestNotificationReceivers> Receivers { get; set; }
            public class UpdateDataQualityAlertRuleRequestNotificationReceivers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:true}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TaskOwner</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public UpdateDataQualityAlertRuleRequestTarget Target { get; set; }
        public class UpdateDataQualityAlertRuleRequestTarget : TeaModel {
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<long?> Ids { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DataQualityScan</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
