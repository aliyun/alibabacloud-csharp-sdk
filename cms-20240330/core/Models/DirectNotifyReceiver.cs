// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DirectNotifyReceiver : TeaModel {
        /// <summary>
        /// <para>The list of notification channels. This parameter is valid only for person-based types (CONTACT/GROUP/DUTY). Valid values: SMS, CALL, EMAIL.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        /// <summary>
        /// <para>The list of Notification Recipient identifiers. For person-based types, the identifiers are contacts, contact groups, or on-call schedule identifiers. For IM-based types, the identifiers are webhook identifiers.</para>
        /// </summary>
        [NameInMap("identifiers")]
        [Validation(Required=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// <para>The Notification Recipient type. Person-object types (CONTACT/GROUP/DUTY) require channels to specify notification methods. IM-object types (DINGTALK/FEISHU/SLACK/WEIXIN/WEBHOOK) do not require channels.</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
