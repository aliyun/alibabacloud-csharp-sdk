// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateMemoryStoreRequest : TeaModel {
        /// <summary>
        /// <para>A list of custom extraction strategies.</para>
        /// </summary>
        [NameInMap("customExtractionStrategies")]
        [Validation(Required=false)]
        public List<CustomExtractionStrategy> CustomExtractionStrategies { get; set; }

        /// <summary>
        /// <para>The description of the MemoryStore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test memory store for demonstration.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extraction strategies to use. Valid values include <c>Episodic</c>, <c>Summary</c>, and <c>Fact</c>.</para>
        /// </summary>
        [NameInMap("extractionStrategies")]
        [Validation(Required=false)]
        public List<string> ExtractionStrategies { get; set; }

        /// <summary>
        /// <para>The name of the MemoryStore. The name must be unique within the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-memory-store</para>
        /// </summary>
        [NameInMap("memoryStoreName")]
        [Validation(Required=false)]
        public string MemoryStoreName { get; set; }

        /// <summary>
        /// <para>The short-term TTL, which is the number of conversation rounds to retain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("shortTermTtl")]
        [Validation(Required=false)]
        public int? ShortTermTtl { get; set; }

        /// <summary>
        /// <para>The source type of the memory. Valid values are <c>None</c> and <c>Trace</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None/Trace</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Configuration for the trace source. Required if <c>sourceType</c> is <c>Trace</c>.</para>
        /// </summary>
        [NameInMap("traceSourceConfig")]
        [Validation(Required=false)]
        public CreateMemoryStoreRequestTraceSourceConfig TraceSourceConfig { get; set; }
        public class CreateMemoryStoreRequestTraceSourceConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the output in the trace.</para>
            /// </summary>
            [NameInMap("includeOutput")]
            [Validation(Required=false)]
            public bool? IncludeOutput { get; set; }

            /// <summary>
            /// <para>The query to filter traces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(serviceName : &quot;langchain-rag&quot; or serviceName : &quot;agentscope-code-correction&quot;) and hostname = frontend-proxy-999c48c8d-hvk6c</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The name of the workspace that contains the trace source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-workspace</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
