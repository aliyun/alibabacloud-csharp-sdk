// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Target : TeaModel {
        [NameInMap("llmConfig")]
        [Validation(Required=false)]
        public LLMAPIConfiguration LlmConfig { get; set; }

        [NameInMap("mcpAPI")]
        [Validation(Required=false)]
        public MCPAPI McpAPI { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
