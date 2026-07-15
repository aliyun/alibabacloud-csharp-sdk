// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAgentConfig : TeaModel {
        /// <summary>
        /// <para>The agent API configuration list.</para>
        /// </summary>
        [NameInMap("agentAPIConfig")]
        [Validation(Required=false)]
        public HiMarketAgentConfigAgentAPIConfig AgentAPIConfig { get; set; }
        public class HiMarketAgentConfigAgentAPIConfig : TeaModel {
            /// <summary>
            /// <para>The list of agent protocols.</para>
            /// </summary>
            [NameInMap("agentProtocols")]
            [Validation(Required=false)]
            public List<string> AgentProtocols { get; set; }

            /// <summary>
            /// <para>The list of agent API routing configurations.</para>
            /// </summary>
            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<HiMarketHttpRoute> Routes { get; set; }

        }

    }

}
