// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateMemoryStoreRequest : TeaModel {
        /// <summary>
        /// <para>The custom extraction strategies.</para>
        /// </summary>
        [NameInMap("customExtractionStrategies")]
        [Validation(Required=false)]
        public List<CustomExtractionStrategy> CustomExtractionStrategies { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test memory store for demonstration.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extraction strategies. Valid values: Episodic, Summary, and Fact.</para>
        /// </summary>
        [NameInMap("extractionStrategies")]
        [Validation(Required=false)]
        public List<string> ExtractionStrategies { get; set; }

        /// <summary>
        /// <para>The name of the memory store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-memory-store</para>
        /// </summary>
        [NameInMap("memoryStoreName")]
        [Validation(Required=false)]
        public string MemoryStoreName { get; set; }

        /// <summary>
        /// <para>The retention period for short-term memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("shortTermTtl")]
        [Validation(Required=false)]
        public int? ShortTermTtl { get; set; }

        /// <summary>
        /// <para>The source of the memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None/Trace</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The configuration when the sourceType is Trace.</para>
        /// </summary>
        [NameInMap("traceSourceConfig")]
        [Validation(Required=false)]
        public CreateMemoryStoreRequestTraceSourceConfig TraceSourceConfig { get; set; }
        public class CreateMemoryStoreRequestTraceSourceConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the large language model (LLM) output in memory extraction.</para>
            /// </summary>
            [NameInMap("includeOutput")]
            [Validation(Required=false)]
            public bool? IncludeOutput { get; set; }

            /// <summary>
            /// <para>The Simple Log Service (SLS) query statement used to filter traces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(serviceName : &quot;langchain-rag&quot; or serviceName : &quot;agentscope-code-correction&quot;) and hostname = frontend-proxy-999c48c8d-hvk6c</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The workspace where the trace is located.</para>
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
