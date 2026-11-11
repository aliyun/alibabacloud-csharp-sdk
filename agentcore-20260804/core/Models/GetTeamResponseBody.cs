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
                /// <para>The creation method of the agent. A value of CUSTOM indicates that the agent is custom-created. A value of TEMPLATE indicates that the agent is created from a template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("createMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                /// <summary>
                /// <para>The creation time in UTC format based on RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The deployment method of the agent. A value of MANAGED indicates platform-managed deployment. A value of SELF_HOSTED indicates user-managed deployment.</para>
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
                /// <para>Agent that handles after-sales consultations</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The latest configuration version number of the agent.</para>
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
                /// <para>The last modification time in UTC format based on RFC 3339.</para>
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
            /// <para>The creation time in UTC format based on RFC 3339.</para>
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
            /// <para>Team responsible for intelligent customer service</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The team name. It can contain only lowercase letters, digits, and hyphens, must start and end with a lowercase letter or a digit, and must be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-01</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID of the resource.</para>
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
            /// <para>The last modification time in UTC format based on RFC 3339.</para>
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
                /// <para>The authentication method of the user. A value of password indicates that the local password authentication of the workspace is used. A value of dingtalk or feishu indicates that the user is synchronized and authenticated by the corresponding external identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("authMethod")]
                [Validation(Required=false)]
                public string AuthMethod { get; set; }

                /// <summary>
                /// <para>The creation time in UTC format based on RFC 3339.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-12T03:04:05Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The display name of the user. It must be 1 to 32 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The email address of the user. It can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:user-01@example.com">user-01@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The initial password of the user. If a password is specified during creation, the specified password is returned. If no password is specified, a random password generated by the server is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example@2026</para>
                /// </summary>
                [NameInMap("initialPassword")]
                [Validation(Required=false)]
                public string InitialPassword { get; set; }

                /// <summary>
                /// <para>The username. It must be unique within the workspace, contain only lowercase letters, digits, and hyphens, start and end with a lowercase letter or a digit, and be 1 to 32 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-01</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user note. It can be up to 1,024 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Member of the agent operations team</para>
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
                /// <para>The last modification time in UTC format based on RFC 3339.</para>
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
        /// <para>The response message. An error description is returned if the request fails.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
