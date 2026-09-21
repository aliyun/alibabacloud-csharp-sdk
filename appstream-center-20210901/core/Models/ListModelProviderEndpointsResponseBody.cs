// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListModelProviderEndpointsResponseBodyData> Data { get; set; }
        public class ListModelProviderEndpointsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The provider description, such as Alibaba Cloud Bailian.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen Plus series models</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of all endpoints under the provider.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListModelProviderEndpointsResponseBodyDataEndpoints> Endpoints { get; set; }
            public class ListModelProviderEndpointsResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// <para>The API compatibility type, such as openai-compatible or anthropic-compatible.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openai-compatible</para>
                /// </summary>
                [NameInMap("ApiType")]
                [Validation(Required=false)]
                public string ApiType { get; set; }

                /// <summary>
                /// <para>The API base URL, such as <a href="https://coding.dashscope.aliyuncs.com/v1">https://coding.dashscope.aliyuncs.com/v1</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://coding.dashscope.aliyuncs.com/v1">https://coding.dashscope.aliyuncs.com/v1</a></para>
                /// </summary>
                [NameInMap("BaseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

                /// <summary>
                /// <para>The endpoint description, such as Coding Plan - OpenAI compatible protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Coding Plan - OpenAI</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The endpoint identifier name, such as coding-openai or cn-beijing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>coding-openai</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The provider URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test">https://test</a></para>
                /// </summary>
                [NameInMap("ProviderUrl")]
                [Validation(Required=false)]
                public string ProviderUrl { get; set; }

                /// <summary>
                /// <para>The list of tags used for categorization and filtering, such as coding-plan, on-demand, or cn-beijing.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            /// <summary>
            /// <para>The provider name, such as bailian or moonshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <para>The provider website URL, which is used to direct users to obtain an API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test">https://test</a></para>
            /// </summary>
            [NameInMap("ProviderUrl")]
            [Validation(Required=false)]
            public string ProviderUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
