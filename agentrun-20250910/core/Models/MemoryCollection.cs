// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class MemoryCollection : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("embedderConfig")]
        [Validation(Required=false)]
        public EmbedderConfig EmbedderConfig { get; set; }

        [NameInMap("enableConversationHistory")]
        [Validation(Required=false)]
        public bool? EnableConversationHistory { get; set; }

        [NameInMap("enableConversationState")]
        [Validation(Required=false)]
        public bool? EnableConversationState { get; set; }

        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        [NameInMap("llmConfig")]
        [Validation(Required=false)]
        public LLMConfig LlmConfig { get; set; }

        [NameInMap("memoryCollectionId")]
        [Validation(Required=false)]
        public string MemoryCollectionId { get; set; }

        [NameInMap("memoryCollectionName")]
        [Validation(Required=false)]
        public string MemoryCollectionName { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("vectorStoreConfig")]
        [Validation(Required=false)]
        public VectorStoreConfig VectorStoreConfig { get; set; }

    }

}
