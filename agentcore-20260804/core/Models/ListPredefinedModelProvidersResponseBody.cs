// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListPredefinedModelProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of predefined model providers.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPredefinedModelProvidersResponseBodyData> Data { get; set; }
        public class ListPredefinedModelProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default model service endpoint of the provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("defaultEndpoint")]
            [Validation(Required=false)]
            public string DefaultEndpoint { get; set; }

            /// <summary>
            /// <para>The default model invocation protocol of the provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI/v1</para>
            /// </summary>
            [NameInMap("defaultProtocol")]
            [Validation(Required=false)]
            public string DefaultProtocol { get; set; }

            /// <summary>
            /// <para>The display name of the model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Model Studio</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The model provider type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("providerType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value is 200 if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message about the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
