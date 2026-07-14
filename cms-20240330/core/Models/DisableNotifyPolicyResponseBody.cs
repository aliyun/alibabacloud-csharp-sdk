// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisableNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the request. Used for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70D52620-2609-1802-9788-6BC592C83F03</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The uuid of the notification policy that was operated on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04779a183add4f2ca06ab440f16cc580</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
