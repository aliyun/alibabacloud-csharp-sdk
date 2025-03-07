// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class StartAIAgentInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent created in the <a href="https://ims.console.aliyun.com/ai/robot/list">IMS</a> console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>同步聊天记录配置。</para>
        /// </summary>
        [NameInMap("ChatSyncConfig")]
        [Validation(Required=false)]
        public StartAIAgentInstanceRequestChatSyncConfig ChatSyncConfig { get; set; }
        public class StartAIAgentInstanceRequestChatSyncConfig : TeaModel {
            /// <summary>
            /// <para>IM的智能体Id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>**<b><b>005e4f309379701645f4</b></b></para>
            /// </summary>
            [NameInMap("IMAIAgentId")]
            [Validation(Required=false)]
            public string IMAIAgentId { get; set; }

            /// <summary>
            /// <para>接收用户Id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>4167626d312034b2b1c3b7f2f3e41884</para>
            /// </summary>
            [NameInMap("ReceiverId")]
            [Validation(Required=false)]
            public string ReceiverId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeConfig")]
        [Validation(Required=false)]
        public AIAgentRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f213fbc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public AIAgentTemplateConfig TemplateConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Email&quot;:&quot;<a href="mailto:johndoe@example.com">johndoe@example.com</a>&quot;,&quot;Preferences&quot;:{&quot;Language&quot;:&quot;en&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
