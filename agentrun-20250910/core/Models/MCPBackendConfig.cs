// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class MCPBackendConfig : TeaModel {
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("services")]
        [Validation(Required=false)]
        public List<MCPServiceConfig> Services { get; set; }

    }

}
