// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateMemoryCollectionInput : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("embedderConfig")]
        [Validation(Required=false)]
        public EmbedderConfig EmbedderConfig { get; set; }

        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        [NameInMap("llmConfig")]
        [Validation(Required=false)]
        public LLMConfig LlmConfig { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("vectorStoreConfig")]
        [Validation(Required=false)]
        public VectorStoreConfig VectorStoreConfig { get; set; }

    }

}
