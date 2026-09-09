// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateTeamRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a team.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateTeamRequestBody Body { get; set; }
        public class CreateTeamRequestBody : TeaModel {
            /// <summary>
            /// <para>The list of agent members for the team.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<CreateTeamRequestBodyAgents> Agents { get; set; }
            public class CreateTeamRequestBodyAgents : TeaModel {
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
            /// <para>The team description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A team responsible for intelligent customer service</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The team name. The name can contain only lowercase letters, digits, and hyphens (-). It must start and end with a lowercase letter or digit. The name must be 1 to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-01</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of user members for the team. The list must include exactly one member with the ADMIN role.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<CreateTeamRequestBodyUsers> Users { get; set; }
            public class CreateTeamRequestBodyUsers : TeaModel {
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
