// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateTeamRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating the team.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateTeamRequestBody Body { get; set; }
        public class UpdateTeamRequestBody : TeaModel {
            /// <summary>
            /// <para>The new agent member list. Replaces the existing agent members using full overwrite semantics. If not specified, the existing agent members remain unchanged.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<UpdateTeamRequestBodyAgents> Agents { get; set; }
            public class UpdateTeamRequestBodyAgents : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-123456</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The role of the agent in the team. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LEADER</description></item>
                /// <item><description>WORKER</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WORKER</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

            }

            /// <summary>
            /// <para>The new team description. If not specified, the existing description remains unchanged.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A team responsible for intelligent customer service</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The new user member list. Replaces the existing user members using full overwrite semantics. When specified, the list must contain exactly one member with the ADMIN role. If not specified, the existing user members remain unchanged.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<UpdateTeamRequestBodyUsers> Users { get; set; }
            public class UpdateTeamRequestBodyUsers : TeaModel {
                /// <summary>
                /// <para>The role of the user in the team. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ADMIN</description></item>
                /// <item><description>MEMBER</description></item>
                /// </list>
                /// <para>Each team must have exactly one ADMIN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADMIN</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usr-123456</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not supported</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
