// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetTeamResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The team details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTeamResponseBodyData Data { get; set; }
        public class GetTeamResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of agent members in the team.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyDataAgents> Agents { get; set; }
            public class GetTeamResponseBodyDataAgents : TeaModel {
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
                /// <para>The creation mode of the agent. CUSTOM indicates custom creation. TEMPLATE indicates creation from a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("createMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                /// <summary>
                /// <para>The creation time in UTC, formatted in RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The deployment mode of the agent. MANAGED indicates platform-managed deployment. SELF_HOSTED indicates self-hosted deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANAGED</para>
                /// </summary>
                [NameInMap("deployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The agent description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An agent that handles after-sales inquiries</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The currently effective specification version number of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("effectiveSpecVersion")]
                [Validation(Required=false)]
                public long? EffectiveSpecVersion { get; set; }

                /// <summary>
                /// <para>The latest specification version number of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("latestSpecVersion")]
                [Validation(Required=false)]
                public long? LatestSpecVersion { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-01</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The runtime type of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwenpaw</para>
                /// </summary>
                [NameInMap("runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

                /// <summary>
                /// <para>The agent status. Valid values: Creating, Running, Failed, Updating, Deleting, and Deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The role of the agent in the team. Valid values: LEADER and WORKER.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WORKER</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

                /// <summary>
                /// <para>The last modification time in UTC, formatted in RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ws-123456</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The creation time in UTC, formatted in RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>team-01</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID where the resource resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The team status. Valid values: Creating, Active, Updating, Deleting, Failed, and Deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The team ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tm-123456</para>
            /// </summary>
            [NameInMap("teamId")]
            [Validation(Required=false)]
            public string TeamId { get; set; }

            /// <summary>
            /// <para>The last modification time in UTC, formatted in RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The list of user members in the team.</para>
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyDataUsers> Users { get; set; }
            public class GetTeamResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// <para>The authentication method of the user. password indicates local password authentication within the workspace. dingtalk and feishu indicate that the user is synchronized and authenticated by the corresponding external identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("authMethod")]
                [Validation(Required=false)]
                public string AuthMethod { get; set; }

                /// <summary>
                /// <para>The creation time in UTC, formatted in RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The display name of the user. The name must be 1 to 32 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The email address of the user. The address can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:user-01@example.com">user-01@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The initial password of the user. If a password was specified during creation, that password is returned. If no password was specified, a random password generated by the server is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example@2026</para>
                /// </summary>
                [NameInMap("initialPassword")]
                [Validation(Required=false)]
                public string InitialPassword { get; set; }

                /// <summary>
                /// <para>The username. The name must be unique within the workspace and can contain only lowercase letters, digits, and hyphens (-). It must start and end with a lowercase letter or digit. The name must be 1 to 32 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-01</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The note for the user. The note can be up to 1024 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent operations group member</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The user status. Valid values: Creating, Active, Updating, Deleting, Failed, and DeleteFailed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The role of the user in the team. Valid values: ADMIN and MEMBER. Each team must have exactly one ADMIN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADMIN</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

                /// <summary>
                /// <para>The last modification time in UTC, formatted in RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usr-123456</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ws-123456</para>
                /// </summary>
                [NameInMap("workspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
