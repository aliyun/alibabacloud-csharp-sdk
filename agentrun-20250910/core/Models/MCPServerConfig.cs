// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class MCPServerConfig : TeaModel {
        [NameInMap("serverUrl")]
        [Validation(Required=false)]
        public string ServerUrl { get; set; }

        [NameInMap("ssePath")]
        [Validation(Required=false)]
        public string SsePath { get; set; }

        [NameInMap("transportType")]
        [Validation(Required=false)]
        public string TransportType { get; set; }

    }

}
