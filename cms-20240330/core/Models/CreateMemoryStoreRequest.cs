// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateMemoryStoreRequest : TeaModel {
        [NameInMap("customExtractionStrategies")]
        [Validation(Required=false)]
        public List<CustomExtractionStrategy> CustomExtractionStrategies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Test memory store for demonstration.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("extractionStrategies")]
        [Validation(Required=false)]
        public List<string> ExtractionStrategies { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-memory-store</para>
        /// </summary>
        [NameInMap("memoryStoreName")]
        [Validation(Required=false)]
        public string MemoryStoreName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("shortTermTtl")]
        [Validation(Required=false)]
        public int? ShortTermTtl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None/Trace</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("traceSourceConfig")]
        [Validation(Required=false)]
        public CreateMemoryStoreRequestTraceSourceConfig TraceSourceConfig { get; set; }
        public class CreateMemoryStoreRequestTraceSourceConfig : TeaModel {
            [NameInMap("includeOutput")]
            [Validation(Required=false)]
            public bool? IncludeOutput { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(serviceName : &quot;langchain-rag&quot; or serviceName : &quot;agentscope-code-correction&quot;) and hostname = frontend-proxy-999c48c8d-hvk6c</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-workspace</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
