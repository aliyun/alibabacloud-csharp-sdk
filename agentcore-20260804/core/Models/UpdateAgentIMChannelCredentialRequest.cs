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
            /// <para>The channel credential. All fields must be provided and field values must be non-empty strings. DingTalk uses clientID and clientSecret. Lark uses appId and appSecret. WeCom uses botId and secret.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public Dictionary<string, string> Credential { get; set; }

        }

        /// <summary>
        /// <para>A reserved idempotency token. The backend does not provide persistent idempotence guarantee in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
