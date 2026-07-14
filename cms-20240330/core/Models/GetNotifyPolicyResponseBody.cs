// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The notification policy object details, including the policy UUID, name, description, enabled status, and sub-entities such as notification policies (noise reduction, notification routing, and channels), subscriptions (event filtering, cross-workspace routing, and legacy product event subscriptions), and response plans (escalation, repeated notifications, automatic recovery, and action integration).</para>
        /// </summary>
        [NameInMap("notifyPolicy")]
        [Validation(Required=false)]
        public NotifyPolicy NotifyPolicy { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
