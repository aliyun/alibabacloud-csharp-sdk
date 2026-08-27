// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetTeamResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTeamResponseBodyData Data { get; set; }
        public class GetTeamResponseBodyData : TeaModel {
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
            /// <para>The list of rooms associated with the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("Rooms")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyDataRooms> Rooms { get; set; }
            public class GetTeamResponseBodyDataRooms : TeaModel {
                /// <summary>
                /// <para>The room ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>room-xxx</para>
                /// </summary>
                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                /// <summary>
                /// <para>The room type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The running status of the team. This field is empty when the team is running normally.</para>
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
            public List<GetTeamResponseBodyDataTeamMembers> TeamMembers { get; set; }
            public class GetTeamResponseBodyDataTeamMembers : TeaModel {
                /// <summary>
                /// <para>The member name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>member-user</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The time when the team was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-10T12:00:00</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The list of worker names associated with the team.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;worker-1&quot;]</para>
            /// </summary>
            [NameInMap("WorkerNames")]
            [Validation(Required=false)]
            public List<string> WorkerNames { get; set; }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-get-team-001</para>
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

    }

}
