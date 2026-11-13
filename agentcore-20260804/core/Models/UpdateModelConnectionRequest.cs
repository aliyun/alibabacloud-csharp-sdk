// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelConnectionRequestBody Body { get; set; }
        public class UpdateModelConnectionRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of API keys used to access the upstream model service. The list must contain at least one non-empty value. When submitted, the new list completely replaces all existing keys. If this parameter is omitted or set to null, the original key list is retained.</para>
            /// </summary>
            [NameInMap("apiKeys")]
            [Validation(Required=false)]
            public List<string> ApiKeys { get; set; }

            /// <summary>
            /// <para>The description of the model connection, which can be up to 255 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The absolute HTTP or HTTPS URL of the upstream model service, which can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the model connection, which must be 1 to 128 non-whitespace characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The model invoke protocol. Currently, only OpenAI/v1 is supported. If Settings are not specified during model creation, this default value is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI/v1</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The model provider type. Predefined providers can be queried by calling <a href="https://api.aliyun.com/document/AgentCore/2026-08-04/ListPredefinedModelProviders">ListPredefinedModelProviders</a>. Additionally, custom, anthropic, and gemini are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("providerType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

        }

        /// <summary>
        /// <para>The client token used for idempotence. This parameter is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
