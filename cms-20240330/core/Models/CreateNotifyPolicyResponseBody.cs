// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The notification policy object details, including the policy UUID, name, description, enabled status, and sub-entities such as notification strategy (grouping, noise reduction, notification routing, and channels), subscription (event filtering, cross-workspace routing, and legacy product event subscription), and response plan (upgrade, repeated notification, automatic recovery, and action integration).</para>
        /// </summary>
        [NameInMap("notifyPolicy")]
        [Validation(Required=false)]
        public NotifyPolicy NotifyPolicy { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
