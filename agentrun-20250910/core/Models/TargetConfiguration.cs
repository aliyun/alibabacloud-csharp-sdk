// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class TargetConfiguration : TeaModel {
        [NameInMap("llmAPIConfig")]
        [Validation(Required=false)]
        public LLMAPIConfiguration LlmAPIConfig { get; set; }

        [NameInMap("mcpAPIConfig")]
        [Validation(Required=false)]
        public MCPAPIConfiguration McpAPIConfig { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
