// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListTeamsResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of teams.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListTeamsResponseBodyItems> Items { get; set; }
        public class ListTeamsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of agent members in the team.</para>
            /// </summary>
            [NameInMap("agents")]
            [Validation(Required=false)]
            public List<ListTeamsResponseBodyItemsAgents> Agents { get; set; }
            public class ListTeamsResponseBodyItemsAgents : TeaModel {
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
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-01</para>
                /// </summary>
                [NameInMap("agentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

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
            /// <para>The time when the team was created, in UTC and RFC 3339 format.</para>
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
            /// <para>Team responsible for the intelligent customer service business</para>
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
            /// <para>The team status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating</description></item>
            /// <item><description>Active</description></item>
            /// <item><description>Updating</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Deleted</description></item>
            /// </list>
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
            /// <para>The time when the team was last modified, in UTC and RFC 3339 format.</para>
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
            public List<ListTeamsResponseBodyItemsUsers> Users { get; set; }
            public class ListTeamsResponseBodyItemsUsers : TeaModel {
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

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-01</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

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
        /// <para>The maximum number of records per page that took effect for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para>The pagination token for the next page. This parameter is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVhbS1vZmZzZXQ6MTA</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of teams that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
