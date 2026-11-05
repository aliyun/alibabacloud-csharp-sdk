// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAgentIMChannelRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAgentIMChannelRequestBody Body { get; set; }
        public class UpdateAgentIMChannelRequestBody : TeaModel {
            /// <summary>
            /// <para>The channel behavior configuration. A full replacement is applied when this parameter is passed. An empty object restores the default values.</para>
            /// </summary>
            [NameInMap("channelConfig")]
            [Validation(Required=false)]
            public UpdateAgentIMChannelRequestBodyChannelConfig ChannelConfig { get; set; }
            public class UpdateAgentIMChannelRequestBodyChannelConfig : TeaModel {
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
            /// <para>Specifies whether to enable the IM channel. Default value: true.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the bound ServiceEndpoint. The endpoint must belong to the specified agent and its current version, and must be ready and have a public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>se-1</para>
            /// </summary>
            [NameInMap("serviceEndpointId")]
            [Validation(Required=false)]
            public string ServiceEndpointId { get; set; }

        }

        /// <summary>
        /// <para>The reserved idempotence token. Persistent idempotence guarantees are not provided by the backend in the current phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
