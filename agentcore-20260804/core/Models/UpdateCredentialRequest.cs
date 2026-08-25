// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCredentialRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCredentialRequestBody Body { get; set; }
        public class UpdateCredentialRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>线上环境调用模型服务使用的 API Key</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>暂不支持</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
