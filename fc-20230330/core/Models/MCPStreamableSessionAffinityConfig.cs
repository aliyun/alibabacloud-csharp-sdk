// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MCPStreamableSessionAffinityConfig : TeaModel {
        /// <summary>
        /// <para>The maximum number of sessions for simultaneous processing by a single instance. Valid values: 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("sessionConcurrencyPerInstance")]
        [Validation(Required=false)]
        public long? SessionConcurrencyPerInstance { get; set; }

        /// <summary>
        /// <para>The maximum idle time in seconds before a session enters an idle state due to user inactivity. The maximum duration is the upper limit of a single session lifecycle. Valid values: 0 to 21600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public long? SessionIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The time-to-live of a session in seconds, covering the entire process from creation and usage to final destruction. If the time-to-live is exceeded, Function Compute automatically destroys the session and no longer guarantees affinity. Valid values: 1 to 21600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

    }

}
