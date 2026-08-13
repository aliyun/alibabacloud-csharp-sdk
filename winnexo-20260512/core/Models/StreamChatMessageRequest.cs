// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class StreamChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>上次接收到的 SSE event id，用于断线续推；不传则从头全量回放</para>
        /// 
        /// <b>Example:</b>
        /// <para>5-1683456789012</para>
        /// </summary>
        [NameInMap("lastEventId")]
        [Validation(Required=false)]
        public string LastEventId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
