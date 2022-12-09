// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListInstancesOfUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesOfUserResponseBodyData Data { get; set; }
        public class ListInstancesOfUserResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListInstancesOfUserResponseBodyDataList> List { get; set; }
            public class ListInstancesOfUserResponseBodyDataList : TeaModel {
                [NameInMap("AdminList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListAdminList> AdminList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListAdminList : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("WorkMode")]
                    [Validation(Required=false)]
                    public string WorkMode { get; set; }

                }

                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                [NameInMap("ConsoleUrl")]
                [Validation(Required=false)]
                public string ConsoleUrl { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NumberList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListNumberList> NumberList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListNumberList : TeaModel {
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("ContactFlowId")]
                    [Validation(Required=false)]
                    public string ContactFlowId { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    [NameInMap("SkillGroups")]
                    [Validation(Required=false)]
                    public List<ListInstancesOfUserResponseBodyDataListNumberListSkillGroups> SkillGroups { get; set; }
                    public class ListInstancesOfUserResponseBodyDataListNumberListSkillGroups : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PhoneNumberCount")]
                        [Validation(Required=false)]
                        public int? PhoneNumberCount { get; set; }

                        [NameInMap("SkillGroupId")]
                        [Validation(Required=false)]
                        public string SkillGroupId { get; set; }

                        [NameInMap("UserCount")]
                        [Validation(Required=false)]
                        public int? UserCount { get; set; }

                    }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
