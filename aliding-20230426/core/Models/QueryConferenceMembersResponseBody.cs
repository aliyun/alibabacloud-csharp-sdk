// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryConferenceMembersResponseBody : TeaModel {
        [NameInMap("memberModels")]
        [Validation(Required=false)]
        public List<QueryConferenceMembersResponseBodyMemberModels> MemberModels { get; set; }
        public class QueryConferenceMembersResponseBodyMemberModels : TeaModel {
            [NameInMap("AttendStatus")]
            [Validation(Required=false)]
            public int? AttendStatus { get; set; }

            [NameInMap("CoHost")]
            [Validation(Required=false)]
            public bool? CoHost { get; set; }

            [NameInMap("ConferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public bool? Host { get; set; }

            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            [NameInMap("LeaveTime")]
            [Validation(Required=false)]
            public long? LeaveTime { get; set; }

            [NameInMap("OuterOrgMember")]
            [Validation(Required=false)]
            public bool? OuterOrgMember { get; set; }

            [NameInMap("PstnJoin")]
            [Validation(Required=false)]
            public bool? PstnJoin { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
