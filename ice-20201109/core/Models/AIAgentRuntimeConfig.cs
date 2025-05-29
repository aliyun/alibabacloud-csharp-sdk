// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentRuntimeConfig : TeaModel {
        [NameInMap("AgentUserId")]
        [Validation(Required=false)]
        public string AgentUserId { get; set; }

        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("AvatarChat3D")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigAvatarChat3D AvatarChat3D { get; set; }
        public class AIAgentRuntimeConfigAvatarChat3D : TeaModel {
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigVisionChat VisionChat { get; set; }
        public class AIAgentRuntimeConfigVisionChat : TeaModel {
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentRuntimeConfigVoiceChat : TeaModel {
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

    }

}
