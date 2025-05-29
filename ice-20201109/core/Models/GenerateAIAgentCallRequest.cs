// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateAIAgentCallRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        [NameInMap("AgentConfig")]
        [Validation(Required=false)]
        public AIAgentConfig AgentConfig { get; set; }

        [NameInMap("ChatSyncConfig")]
        [Validation(Required=false)]
        public GenerateAIAgentCallRequestChatSyncConfig ChatSyncConfig { get; set; }
        public class GenerateAIAgentCallRequestChatSyncConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>**<b><b>005e4f309379701645f4</b></b></para>
            /// </summary>
            [NameInMap("IMAIAgentId")]
            [Validation(Required=false)]
            public string IMAIAgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4167626d312034b2b1c3b7f2f3e41884</para>
            /// </summary>
            [NameInMap("ReceiverId")]
            [Validation(Required=false)]
            public string ReceiverId { get; set; }

        }

        /// <summary>
        /// <para>The time when the token expires. Unit: seconds. Default value: 3600. Valid values: 0 to 604800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fw1gr0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The template configurations of the AI agent. The specified configurations are merged with the template configurations that are specified in the console. If you do not specify this parameter, the system uses the default configurations for an AI agent created in the console.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentTemplateConfig TemplateConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The username of the AI agent in the channel. If you do not specify this parameter, the system automatically generates a username. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
