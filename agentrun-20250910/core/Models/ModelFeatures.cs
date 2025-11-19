// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelFeatures : TeaModel {
        [NameInMap("agentThought")]
        [Validation(Required=false)]
        public bool? AgentThought { get; set; }

        [NameInMap("multiToolCall")]
        [Validation(Required=false)]
        public bool? MultiToolCall { get; set; }

        [NameInMap("streamToolCall")]
        [Validation(Required=false)]
        public bool? StreamToolCall { get; set; }

        [NameInMap("toolCall")]
        [Validation(Required=false)]
        public bool? ToolCall { get; set; }

        [NameInMap("vision")]
        [Validation(Required=false)]
        public bool? Vision { get; set; }

    }

}
