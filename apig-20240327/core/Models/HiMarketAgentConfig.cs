// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAgentConfig : TeaModel {
        /// <summary>
        /// <para>Contains the API configuration for the agent.</para>
        /// </summary>
        [NameInMap("agentAPIConfig")]
        [Validation(Required=false)]
        public HiMarketAgentConfigAgentAPIConfig AgentAPIConfig { get; set; }
        public class HiMarketAgentConfigAgentAPIConfig : TeaModel {
            /// <summary>
            /// <para>The communication protocols supported by the agent.</para>
            /// </summary>
            [NameInMap("agentProtocols")]
            [Validation(Required=false)]
            public List<string> AgentProtocols { get; set; }

            /// <summary>
            /// <para>The routing rules for incoming requests.</para>
            /// </summary>
            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<HiMarketHttpRoute> Routes { get; set; }

        }

    }

}
