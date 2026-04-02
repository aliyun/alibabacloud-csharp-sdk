// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryNacosProvidersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ModelRouterQueryNacosProvidersResponseBodyData> Data { get; set; }
        public class ModelRouterQueryNacosProvidersResponseBodyData : TeaModel {
            [NameInMap("baseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

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

                [NameInMap("inputToken")]
                [Validation(Required=false)]
                public string InputToken { get; set; }

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

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
