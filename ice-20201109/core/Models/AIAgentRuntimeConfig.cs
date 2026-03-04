// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AIAgentRuntimeConfig : TeaModel {
        /// <summary>
        /// <para>The name of the agent in the ARTC channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
        /// </summary>
        [NameInMap("AgentUserId")]
        [Validation(Required=false)]
        public string AgentUserId { get; set; }

        /// <summary>
        /// <para>The authentication token for the agent to join the channel. This must be generated using your AppKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The runtime parameters of the avatar call.</para>
        /// </summary>
        [NameInMap("AvatarChat3D")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigAvatarChat3D AvatarChat3D { get; set; }
        public class AIAgentRuntimeConfigAvatarChat3D : TeaModel {
            /// <summary>
            /// <para>Required. The name of the agent in the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
            /// </summary>
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            /// <summary>
            /// <para>Required. The authentication token for the agent to join the channel. This must be generated using your AppKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>Required. The ID of the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70f22d5784194938a7e387052f2b3208</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the ARTC channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70f22d5784194938a7e387052f2b3208</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The runtime parameters of the vision call.</para>
        /// </summary>
        [NameInMap("VisionChat")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigVisionChat VisionChat { get; set; }
        public class AIAgentRuntimeConfigVisionChat : TeaModel {
            /// <summary>
            /// <para>Required. The name of the agent in the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
            /// </summary>
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            /// <summary>
            /// <para>Required. The authentication token for the agent to join the channel. This must be generated using your AppKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>Required. The ID of the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70f22d5784194938a7e387052f2b3208</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The runtime parameters of the voice call.</para>
        /// </summary>
        [NameInMap("VoiceChat")]
        [Validation(Required=false)]
        [Obsolete]
        public AIAgentRuntimeConfigVoiceChat VoiceChat { get; set; }
        public class AIAgentRuntimeConfigVoiceChat : TeaModel {
            /// <summary>
            /// <para>Required. The name of the agent in the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
            /// </summary>
            [NameInMap("AgentUserId")]
            [Validation(Required=false)]
            public string AgentUserId { get; set; }

            /// <summary>
            /// <para>Required. The authentication token for the agent to join the channel. This must be generated using your AppKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>Required. The ID of the ARTC channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70f22d5784194938a7e387052f2b3208</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

        }

    }

}
