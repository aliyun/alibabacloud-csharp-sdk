// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListTeamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of team summaries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListTeamsResponseBodyItems> Items { get; set; }
        public class ListTeamsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the team administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin-user</para>
            /// </summary>
            [NameInMap("AdminName")]
            [Validation(Required=false)]
            public string AdminName { get; set; }

            /// <summary>
            /// <para>The time when the team was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01T12:00:00</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The team description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a team.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentteams-test-001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the team leader.</para>
            /// 
            /// <b>Example:</b>
            /// <para>leader-user</para>
            /// </summary>
            [NameInMap("LeaderName")]
            [Validation(Required=false)]
            public string LeaderName { get; set; }

            /// <summary>
            /// <para>The team name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-team</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The running status of the team. This parameter is empty when the team is running normally.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deleting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of team members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("TeamMembers")]
            [Validation(Required=false)]
            public List<ListTeamsResponseBodyItemsTeamMembers> TeamMembers { get; set; }
            public class ListTeamsResponseBodyItemsTeamMembers : TeaModel {
                /// <summary>
                /// <para>The team name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-team</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of Worker names associated with the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;worker-1&quot;]</para>
            /// </summary>
            [NameInMap("WorkerNames")]
            [Validation(Required=false)]
            public List<string> WorkerNames { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is empty if no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-list-teams-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
