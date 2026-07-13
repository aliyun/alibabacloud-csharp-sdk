// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetTeamResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTeamResponseBodyData Data { get; set; }
        public class GetTeamResponseBodyData : TeaModel {
            [NameInMap("AdminName")]
            [Validation(Required=false)]
            public string AdminName { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LeaderName")]
            [Validation(Required=false)]
            public string LeaderName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Rooms")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyDataRooms> Rooms { get; set; }
            public class GetTeamResponseBodyDataRooms : TeaModel {
                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TeamMembers")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyDataTeamMembers> TeamMembers { get; set; }
            public class GetTeamResponseBodyDataTeamMembers : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("WorkerNames")]
            [Validation(Required=false)]
            public List<string> WorkerNames { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
