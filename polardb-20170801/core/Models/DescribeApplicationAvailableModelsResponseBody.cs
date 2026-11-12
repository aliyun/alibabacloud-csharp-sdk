// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationAvailableModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of speech recognition models.</para>
        /// </summary>
        [NameInMap("AsrModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyAsrModels> AsrModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyAsrModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paraformer-realtime-v2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protocol used by the speech recognition model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>websocket</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The default text embedding model.</para>
        /// </summary>
        [NameInMap("DefaultEmbeddingModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultEmbeddingModel DefaultEmbeddingModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultEmbeddingModel : TeaModel {
            /// <summary>
            /// <para>The default vector dimensions of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The list of vector dimensions supported by the model.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<int?> Dimensions { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v3</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default graph large language model.</para>
        /// </summary>
        [NameInMap("DefaultGraphLLMModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultGraphLLMModel DefaultGraphLLMModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultGraphLLMModel : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default large language model.</para>
        /// </summary>
        [NameInMap("DefaultLLMModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultLLMModel DefaultLLMModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultLLMModel : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default memory type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("DefaultMemoryType")]
        [Validation(Required=false)]
        public string DefaultMemoryType { get; set; }

        /// <summary>
        /// <para>The default reranking model.</para>
        /// </summary>
        [NameInMap("DefaultRerankModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultRerankModel DefaultRerankModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultRerankModel : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gte-rerank-v2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default visual language model.</para>
        /// </summary>
        [NameInMap("DefaultVLModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultVLModel DefaultVLModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultVLModel : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-vl-max</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default VisualEmbedder model.</para>
        /// </summary>
        [NameInMap("DefaultVisualEmbedderModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultVisualEmbedderModel DefaultVisualEmbedderModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultVisualEmbedderModel : TeaModel {
            /// <summary>
            /// <para>The default dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2560</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The available dimensions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<int?> Dimensions { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-text-embedding</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The default VisualLLM model.</para>
        /// </summary>
        [NameInMap("DefaultVisualLlmModel")]
        [Validation(Required=false)]
        public DescribeApplicationAvailableModelsResponseBodyDefaultVisualLlmModel DefaultVisualLlmModel { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyDefaultVisualLlmModel : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.6-flash</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The supported modalities.</para>
            /// </summary>
            [NameInMap("SupportedModalities")]
            [Validation(Required=false)]
            public List<string> SupportedModalities { get; set; }

        }

        /// <summary>
        /// <para>The list of available text embedding models.</para>
        /// </summary>
        [NameInMap("EmbeddingModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyEmbeddingModels> EmbeddingModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyEmbeddingModels : TeaModel {
            /// <summary>
            /// <para>The default vector dimensions of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The list of vector dimensions supported by the model.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<int?> Dimensions { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v3</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The list of available graph large language models.</para>
        /// </summary>
        [NameInMap("GraphLlmModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyGraphLlmModels> GraphLlmModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyGraphLlmModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The list of available large language models.</para>
        /// </summary>
        [NameInMap("LlmModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyLlmModels> LlmModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyLlmModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The available memory types.</para>
        /// </summary>
        [NameInMap("MemoryTypes")]
        [Validation(Required=false)]
        public List<string> MemoryTypes { get; set; }

        /// <summary>
        /// <para>Indicates whether the current account supports Mem0 multimodal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MultimodalSupported")]
        [Validation(Required=false)]
        public bool? MultimodalSupported { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of available reranking models.</para>
        /// </summary>
        [NameInMap("RerankModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyRerankModels> RerankModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyRerankModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gte-rerank-v2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The list of available visual language models.</para>
        /// </summary>
        [NameInMap("VLModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyVLModels> VLModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyVLModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-vl-max</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The list of available VisualEmbedder models.</para>
        /// </summary>
        [NameInMap("VisualEmbedderModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyVisualEmbedderModels> VisualEmbedderModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyVisualEmbedderModels : TeaModel {
            /// <summary>
            /// <para>The default dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2560</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public int? Dimension { get; set; }

            /// <summary>
            /// <para>The available dimensions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<int?> Dimensions { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-text-embedding</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The list of available VisualLLM models.</para>
        /// </summary>
        [NameInMap("VisualLlmModels")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableModelsResponseBodyVisualLlmModels> VisualLlmModels { get; set; }
        public class DescribeApplicationAvailableModelsResponseBodyVisualLlmModels : TeaModel {
            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.6-flash</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The supported modalities.</para>
            /// </summary>
            [NameInMap("SupportedModalities")]
            [Validation(Required=false)]
            public List<string> SupportedModalities { get; set; }

        }

    }

}
