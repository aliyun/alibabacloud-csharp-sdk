// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the request. Used for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1234567-1234-1234-1234-123456789012</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The uuid of the notification policy that was operated on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-12345678-1234-1234-1234-123456789012</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
