// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetLlmModelProviderByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The large language model service provider and available models.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLlmModelProviderByNameResponseBodyData Data { get; set; }
        public class GetLlmModelProviderByNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The base URL of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com">https://dashscope.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The enabling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the model service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of models provided by the model service provider.</para>
            /// </summary>
            [NameInMap("LlmModels")]
            [Validation(Required=false)]
            public List<GetLlmModelProviderByNameResponseBodyDataLlmModels> LlmModels { get; set; }
            public class GetLlmModelProviderByNameResponseBodyDataLlmModels : TeaModel {
                /// <summary>
                /// <para>The Chinese name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通义千问-Max</para>
                /// </summary>
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }

                /// <summary>
                /// <para>The model description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>General text generation model</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of available dimension values for the embedding model. Only embedding models have this value.</para>
                /// </summary>
                [NameInMap("EmbeddingDimensions")]
                [Validation(Required=false)]
                public List<int?> EmbeddingDimensions { get; set; }

                /// <summary>
                /// <para>The enabling status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The model invocation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OPEN_AI</description></item>
                /// <item><description>DASH_SCOPE</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DASH_SCOPE</para>
                /// </summary>
                [NameInMap("InvokeType")]
                [Validation(Required=false)]
                public string InvokeType { get; set; }

                /// <summary>
                /// <para>The model ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                /// <summary>
                /// <para>The list of model modality types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TEXT: text</description></item>
                /// <item><description>IMAGE: image</description></item>
                /// <item><description>AUDIO: audio</description></item>
                /// <item><description>VIDEO: video</description></item>
                /// <item><description>EMBEDDING: embedding</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ModelTypes")]
                [Validation(Required=false)]
                public List<string> ModelTypes { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

                /// <summary>
                /// <para>The list of model task capabilities. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ASR: speech recognition</description></item>
                /// <item><description>TTS: speech synthesis</description></item>
                /// <item><description>TRANSLATION: speech translation</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<string> Tasks { get; set; }

            }

            /// <summary>
            /// <para>The source of the model service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUILTIN_MODEL: built-in</description></item>
            /// <item><description>BYOM: user-provided</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUILTIN_MODEL</para>
            /// </summary>
            [NameInMap("ProviderSource")]
            [Validation(Required=false)]
            public string ProviderSource { get; set; }

            /// <summary>
            /// <para>The service provider type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BAILIAN</description></item>
            /// <item><description>DEEPSEEK</description></item>
            /// <item><description>AI_STACK</description></item>
            /// <item><description>VLLM</description></item>
            /// <item><description>AGENT_ONE</description></item>
            /// <item><description>DATAPHIN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("ProviderType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

            /// <summary>
            /// <para>The name of the model service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("ServiceProvider")]
            [Validation(Required=false)]
            public string ServiceProvider { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
