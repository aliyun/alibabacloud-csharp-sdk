// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSend : TeaModel {
        /// <summary>
        /// <para>The alert action integration configuration.</para>
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
        /// <para>The list of notification policies that define the notification methods or Policy Name values to use for different alert states, such as triggered and recover.</para>
        /// </summary>
        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        /// <summary>
        /// <para>The root cause analysis (RCA) configuration. After this feature is enabled, root cause analysis is automatically performed when an alert is triggered.</para>
        /// </summary>
        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether event delivery of alert events to ARMS alert management is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendToArms")]
        [Validation(Required=false)]
        public bool? SendToArms { get; set; }

    }

}
