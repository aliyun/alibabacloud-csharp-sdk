// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSend : TeaModel {
        /// <summary>
        /// <para>The integrated alert action configuration.</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public AlertRuleAction Action { get; set; }

        /// <summary>
        /// <para>The alert notification configuration.</para>
        /// </summary>
        [NameInMap("notification")]
        [Validation(Required=false)]
        public AlertRuleNotification Notification { get; set; }

        /// <summary>
        /// <para>The list of notification policies. Each policy defines the notification method or policy name to use for a specific alert state, such as trigger or recovery.</para>
        /// </summary>
        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver alert events to Alert Management of Application Real-Time Monitoring Service (ARMS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendToArms")]
        [Validation(Required=false)]
        public bool? SendToArms { get; set; }

    }

}
