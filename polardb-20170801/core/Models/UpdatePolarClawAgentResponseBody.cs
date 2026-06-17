// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the updated agent.</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public UpdatePolarClawAgentResponseBodyAgent Agent { get; set; }
        public class UpdatePolarClawAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The identity information of the agent.</para>
            /// </summary>
            [NameInMap("Identity")]
            [Validation(Required=false)]
            public UpdatePolarClawAgentResponseBodyAgentIdentity Identity { get; set; }
            public class UpdatePolarClawAgentResponseBodyAgentIdentity : TeaModel {
                /// <summary>
                /// <para>The path or content of the avatar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <para>The avatar URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <para>The identity\&quot;s Emoji identifier. This can be a Unicode code point, such as U+1F99E, or the Emoji character itself.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U+1F99E</para>
                /// </summary>
                [NameInMap("Emoji")]
                [Validation(Required=false)]
                public string Emoji { get; set; }

                /// <summary>
                /// <para>The name of the identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarClaw</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The theme of the identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>soul lobster</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            /// <summary>
            /// <para>The display name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolarClaw</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The workspace path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/workspace-work-v2</para>
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
