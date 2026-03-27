// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSend : TeaModel {
        /// <summary>
        /// <para>Alert Action Integration Configuration.</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public AlertRuleAction Action { get; set; }

        /// <summary>
        /// <para>Alert Notification Configuration.</para>
        /// </summary>
        [NameInMap("notification")]
        [Validation(Required=false)]
        public AlertRuleNotification Notification { get; set; }

        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        [NameInMap("rcaConfig")]
        [Validation(Required=false)]
        public AlertRuleRcaConfig RcaConfig { get; set; }

        /// <summary>
        /// <para>Whether to deliver alert events to ARMS Alert Management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendToArms")]
        [Validation(Required=false)]
        public bool? SendToArms { get; set; }

    }

}
