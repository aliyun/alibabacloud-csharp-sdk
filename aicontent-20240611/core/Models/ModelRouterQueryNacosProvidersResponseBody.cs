// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryNacosProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ModelRouterQueryNacosProvidersResponseBodyData> Data { get; set; }
        public class ModelRouterQueryNacosProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The base URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com">https://dashscope.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("baseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The list of models.</para>
            /// </summary>
            [NameInMap("models")]
            [Validation(Required=false)]
            public List<ModelRouterQueryNacosProvidersResponseBodyDataModels> Models { get; set; }
            public class ModelRouterQueryNacosProvidersResponseBodyDataModels : TeaModel {
                [NameInMap("extensions")]
                [Validation(Required=false)]
                public ModelRouterQueryNacosProvidersResponseBodyDataModelsExtensions Extensions { get; set; }
                public class ModelRouterQueryNacosProvidersResponseBodyDataModelsExtensions : TeaModel {
                    [NameInMap("async")]
                    [Validation(Required=false)]
                    public bool? Async { get; set; }

                }

                /// <summary>
                /// <para>The model identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca90f359956e94367470c38676</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("inOut")]
                [Validation(Required=false)]
                public string InOut { get; set; }

                /// <summary>
                /// <para>The input token limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32K</para>
                /// </summary>
                [NameInMap("inputToken")]
                [Validation(Required=false)]
                public string InputToken { get; set; }

                /// <summary>
                /// <para>The output token limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8K</para>
                /// </summary>
                [NameInMap("outputToken")]
                [Validation(Required=false)]
                public string OutputToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Chat</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>通义千问</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The provider identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

        }

        /// <summary>
        /// <para>The error message code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
