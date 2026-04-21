// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketMcpConfig : TeaModel {
        [NameInMap("mcpServerConfig")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMcpServerConfig McpServerConfig { get; set; }
        public class HiMarketMcpConfigMcpServerConfig : TeaModel {
            [NameInMap("domains")]
            [Validation(Required=false)]
            public List<HiMarketDomain> Domains { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("mcpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public HiMarketMcpConfigMeta Meta { get; set; }
        public class HiMarketMcpConfigMeta : TeaModel {
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public string Tools { get; set; }

    }

}
