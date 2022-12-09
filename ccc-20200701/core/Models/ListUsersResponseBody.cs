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
                [NameInMap("DeviceExt")]
                [Validation(Required=false)]
                public string DeviceExt { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("PersonalOutboundNumberList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListPersonalOutboundNumberList> PersonalOutboundNumberList { get; set; }
                public class ListUsersResponseBodyDataListPersonalOutboundNumberList : TeaModel {
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                [NameInMap("PrimaryAccount")]
                [Validation(Required=false)]
                public bool? PrimaryAccount { get; set; }

                [NameInMap("RamId")]
                [Validation(Required=false)]
                public long? RamId { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("SkillLevelList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListSkillLevelList> SkillLevelList { get; set; }
                public class ListUsersResponseBodyDataListSkillLevelList : TeaModel {
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    [NameInMap("SkillLevel")]
                    [Validation(Required=false)]
                    public int? SkillLevel { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("WorkMode")]
                [Validation(Required=false)]
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

    }

}
