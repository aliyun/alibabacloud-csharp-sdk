// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the notification policy object, including the policy UUID, name, description, and enabling status, as well as sub-entities such as the notification policy (group merging, notification routing, and channels), subscriptions (event filtering, cross-workspace routing, and legacy product event subscriptions), and response plans (escalation, repeated notifications, automatic recovery, and action integration).</para>
        /// </summary>
        [NameInMap("notifyPolicy")]
        [Validation(Required=false)]
        public NotifyPolicy NotifyPolicy { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, which is used for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70D52620-2609-1802-9788-6BC592C83F03</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
