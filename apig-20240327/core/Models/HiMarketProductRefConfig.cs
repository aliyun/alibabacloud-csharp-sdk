// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductRefConfig : TeaModel {
        [NameInMap("apigRefConfig")]
        [Validation(Required=false)]
        public HiMarketProductRefConfigApigRefConfig ApigRefConfig { get; set; }
        public class HiMarketProductRefConfigApigRefConfig : TeaModel {
            [NameInMap("agentApiId")]
            [Validation(Required=false)]
            public string AgentApiId { get; set; }

            [NameInMap("agentApiName")]
            [Validation(Required=false)]
            public string AgentApiName { get; set; }

            [NameInMap("mcpRouteId")]
            [Validation(Required=false)]
            public string McpRouteId { get; set; }

            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            [NameInMap("mcpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

            [NameInMap("modelApiName")]
            [Validation(Required=false)]
            public string ModelApiName { get; set; }

        }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

    }

}
