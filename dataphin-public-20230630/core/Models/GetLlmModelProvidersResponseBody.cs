// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetLlmModelProvidersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetLlmModelProvidersResponseBodyData> Data { get; set; }
        public class GetLlmModelProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com">https://dashscope.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LlmModels")]
            [Validation(Required=false)]
            public List<GetLlmModelProvidersResponseBodyDataLlmModels> LlmModels { get; set; }
            public class GetLlmModelProvidersResponseBodyDataLlmModels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>通义千问-Max</para>
                /// </summary>
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>通用文本生成模型</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EmbeddingDimensions")]
                [Validation(Required=false)]
                public List<int?> EmbeddingDimensions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DASH_SCOPE</para>
                /// </summary>
                [NameInMap("InvokeType")]
                [Validation(Required=false)]
                public string InvokeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                [NameInMap("ModelTypes")]
                [Validation(Required=false)]
                public List<string> ModelTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<string> Tasks { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BUILTIN_MODEL</para>
            /// </summary>
            [NameInMap("ProviderSource")]
            [Validation(Required=false)]
            public string ProviderSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BAILIAN</para>
            /// </summary>
            [NameInMap("ProviderType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("ServiceProvider")]
            [Validation(Required=false)]
            public string ServiceProvider { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
