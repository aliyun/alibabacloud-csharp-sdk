// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class MCPAPIConfiguration : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("exposedUriPath")]
        [Validation(Required=false)]
        public string ExposedUriPath { get; set; }

        [NameInMap("mcpStatisticsEnable")]
        [Validation(Required=false)]
        public bool? McpStatisticsEnable { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("toolId")]
        [Validation(Required=false)]
        public string ToolId { get; set; }

    }

}
