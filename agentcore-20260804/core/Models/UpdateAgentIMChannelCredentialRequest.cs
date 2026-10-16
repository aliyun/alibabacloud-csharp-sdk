// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAgentIMChannelCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAgentIMChannelCredentialRequestBody Body { get; set; }
        public class UpdateAgentIMChannelCredentialRequestBody : TeaModel {
            /// <summary>
            /// <para>The channel credentials. All fields must be provided and the field values must be non-empty strings. For DingTalk, use clientID and clientSecret. For Lark, use appId and appSecret. For WeCom, use botId and secret.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public Dictionary<string, string> Credential { get; set; }

        }

        /// <summary>
        /// <para>The reserved idempotence token. The backend does not provide persistent idempotence guarantees in the current phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
