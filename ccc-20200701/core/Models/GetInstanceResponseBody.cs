// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ConsoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("AdminList")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataAdminList> AdminList { get; set; }
            public class GetInstanceResponseBodyDataAdminList : TeaModel {
                public string DisplayName { get; set; }
                public string Extension { get; set; }
                public string LoginName { get; set; }
                public string Email { get; set; }
                public string WorkMode { get; set; }
                public string Mobile { get; set; }
                public string UserId { get; set; }
                public string RoleName { get; set; }
                public string InstanceId { get; set; }
                public string RoleId { get; set; }
            }
            [NameInMap("NumberList")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataNumberList> NumberList { get; set; }
            public class GetInstanceResponseBodyDataNumberList : TeaModel {
                public bool? Active { get; set; }
                public string UserId { get; set; }
                public string Number { get; set; }
                public string City { get; set; }
                public string InstanceId { get; set; }
                public string Usage { get; set; }
                public string ContactFlowId { get; set; }
                public string Province { get; set; }
                public List<GetInstanceResponseBodyDataNumberListSkillGroups> SkillGroups { get; set; }
                public class GetInstanceResponseBodyDataNumberListSkillGroups : TeaModel {
                    public string DisplayName { get; set; }
                    public string Description { get; set; }
                    public int? PhoneNumberCount { get; set; }
                    public string SkillGroupId { get; set; }
                    public int? UserCount { get; set; }
                    public string InstanceId { get; set; }
                    public string Name { get; set; }
                }
            }
        };

    }

}
