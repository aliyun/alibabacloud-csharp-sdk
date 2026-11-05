// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateAgentIMChannelRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateAgentIMChannelRequestBody Body { get; set; }
        public class CreateAgentIMChannelRequestBody : TeaModel {
            /// <summary>
            /// <para>The channel behavior configuration.</para>
            /// </summary>
            [NameInMap("channelConfig")]
            [Validation(Required=false)]
            public CreateAgentIMChannelRequestBodyChannelConfig ChannelConfig { get; set; }
            public class CreateAgentIMChannelRequestBodyChannelConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to display the thinking process in IM messages. Default value: false.</para>
                /// </summary>
                [NameInMap("showThinking")]
                [Validation(Required=false)]
                public bool? ShowThinking { get; set; }

                /// <summary>
                /// <para>Specifies whether to display the tool calling process in IM messages. Default value: false.</para>
                /// </summary>
                [NameInMap("showToolCalls")]
                [Validation(Required=false)]
                public bool? ShowToolCalls { get; set; }

            }

            /// <summary>
            /// <para>The IM channel type. Valid values: DINGTALK (DingTalk), FEISHU (Lark), and WECOM (WeCom).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DINGTALK</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The channel credentials. You must pass all credential fields and ensure that the field values are non-empty strings. For DingTalk, use clientID and clientSecret. For Lark, use appId and appSecret. For WeCom, use botId and secret.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("credential")]
            [Validation(Required=false)]
            public Dictionary<string, string> Credential { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the IM channel. Default value: true.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the bound service endpoint. The endpoint must belong to the specified agent and its current version, be in the ready state, and have a publicly accessible address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-1</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

        }

        /// <summary>
        /// <para>The reserved idempotency token. The backend does not provide persistent idempotency guarantees in the current phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
