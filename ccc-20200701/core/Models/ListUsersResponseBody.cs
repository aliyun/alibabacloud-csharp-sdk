// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListUsersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataList> List { get; set; }
            public class ListUsersResponseBodyDataList : TeaModel {
                public string DisplayId { get; set; }
                public string DisplayName { get; set; }
                public string Email { get; set; }
                public string LoginName { get; set; }
                public string Mobile { get; set; }
                public List<ListUsersResponseBodyDataListPersonalOutboundNumberList> PersonalOutboundNumberList { get; set; }
                public class ListUsersResponseBodyDataListPersonalOutboundNumberList : TeaModel {
                    public bool? Active { get; set; }
                    public string City { get; set; }
                    public string Number { get; set; }
                    public string Province { get; set; }
                    public string Usage { get; set; }
                }
                public bool? PrimaryAccount { get; set; }
                public string RoleId { get; set; }
                public string RoleName { get; set; }
                public List<ListUsersResponseBodyDataListSkillLevelList> SkillLevelList { get; set; }
                public class ListUsersResponseBodyDataListSkillLevelList : TeaModel {
                    public string SkillGroupId { get; set; }
                    public string SkillGroupName { get; set; }
                    public int? SkillLevel { get; set; }
                }
                public string UserId { get; set; }
                public string WorkMode { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
