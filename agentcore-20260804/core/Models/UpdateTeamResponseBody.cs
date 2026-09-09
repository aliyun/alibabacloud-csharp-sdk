// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateTeamResponseBody : TeaModel {
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
        /// <para>The updated team information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateTeamResponseBodyData Data { get; set; }
        public class UpdateTeamResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of agent members in the team.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<UpdateTeamResponseBodyDataAgents> Agents { get; set; }
            public class UpdateTeamResponseBodyDataAgents : TeaModel {
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
                /// <para>The role of the agent in the team. Valid values: LEADER, WORKER. Each team must have exactly one LEADER.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WORKER</para>
                /// </summary>
                [NameInMap("teamRole")]
                [Validation(Required=false)]
                public string TeamRole { get; set; }

            }

            /// <summary>
            /// <para>The creation time in UTC, in RFC 3339 format.</para>
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
            /// <para>The team name. The name can contain only lowercase letters, digits, and hyphens (-). It must start and end with a lowercase letter or digit. The name must be 1 to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team-01</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The team status. Valid values: Creating, Active, Updating, Deleting, Failed, Deleted.</para>
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
            /// <para>The time of the last modification in UTC, in RFC 3339 format.</para>
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
            public List<UpdateTeamResponseBodyDataUsers> Users { get; set; }
            public class UpdateTeamResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// <para>The role of the user in the team. Valid values: ADMIN, MEMBER. Each team must have exactly one ADMIN.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
