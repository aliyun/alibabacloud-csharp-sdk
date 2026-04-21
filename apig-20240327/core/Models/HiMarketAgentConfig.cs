// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAgentConfig : TeaModel {
        [NameInMap("agentAPIConfig")]
        [Validation(Required=false)]
        public HiMarketAgentConfigAgentAPIConfig AgentAPIConfig { get; set; }
        public class HiMarketAgentConfigAgentAPIConfig : TeaModel {
            [NameInMap("agentProtocols")]
            [Validation(Required=false)]
            public List<string> AgentProtocols { get; set; }

            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<HiMarketHttpRoute> Routes { get; set; }

        }

    }

}
