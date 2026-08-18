// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MCPSSESessionAffinityConfig : TeaModel {
        /// <summary>
        /// <para>The maximum number of sessions that a single instance can handle through simultaneous processing. Valid values: 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("sessionConcurrencyPerInstance")]
        [Validation(Required=false)]
        public long? SessionConcurrencyPerInstance { get; set; }

        /// <summary>
        /// <para>The SSE path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sse</para>
        /// </summary>
        [NameInMap("sseEndpointPath")]
        [Validation(Required=false)]
        public string SseEndpointPath { get; set; }

    }

}
