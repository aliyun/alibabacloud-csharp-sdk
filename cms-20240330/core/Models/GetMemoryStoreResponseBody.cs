// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMemoryStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764556182850</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>test</para>
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
        /// <para>The memory store name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-memory-store</para>
        /// </summary>
        [NameInMap("memoryStoreName")]
        [Validation(Required=false)]
        public string MemoryStoreName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The short-term memory storage.</para>
        /// </summary>
        [NameInMap("shortTermStorage")]
        [Validation(Required=false)]
        public GetMemoryStoreResponseBodyShortTermStorage ShortTermStorage { get; set; }
        public class GetMemoryStoreResponseBodyShortTermStorage : TeaModel {
            /// <summary>
            /// <para>The Simple Log Service Logstore name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>memory-store</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wk_cms_data_warehouse</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

        /// <summary>
        /// <para>The retention period of short-term memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("shortTermTtl")]
        [Validation(Required=false)]
        public int? ShortTermTtl { get; set; }

        /// <summary>
        /// <para>The memory source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trace</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The configuration used when sourceType is set to Trace.</para>
        /// </summary>
        [NameInMap("traceSourceConfig")]
        [Validation(Required=false)]
        public GetMemoryStoreResponseBodyTraceSourceConfig TraceSourceConfig { get; set; }
        public class GetMemoryStoreResponseBodyTraceSourceConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include LLM output in memory extraction.</para>
            /// </summary>
            [NameInMap("includeOutput")]
            [Validation(Required=false)]
            public bool? IncludeOutput { get; set; }

            /// <summary>
            /// <para>The Simple Log Service query statement used to filter traces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(serviceName : &quot;langchain-rag&quot; or serviceName : &quot;agentscope-code-correction&quot;) and hostname = frontend-proxy-999c48c8d-hvk6c</para>
            /// </summary>
            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The workspace where the trace resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-workspace</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The update time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764556182850</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxxxx-cn-beijing</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
