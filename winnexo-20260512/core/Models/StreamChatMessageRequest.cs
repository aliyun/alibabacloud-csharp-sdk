// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class StreamChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>The last received SSE event ID, used for resuming delivery after a disconnection. If this parameter is not specified, full replay starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5-1683456789012</para>
        /// </summary>
        [NameInMap("lastEventId")]
        [Validation(Required=false)]
        public string LastEventId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant for which the subscription takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
