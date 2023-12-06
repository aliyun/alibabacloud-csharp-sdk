// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetOrganizationMemberResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("member")]
        [Validation(Required=false)]
        public GetOrganizationMemberResponseBodyMember Member { get; set; }
        public class GetOrganizationMemberResponseBodyMember : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("birthday")]
            [Validation(Required=false)]
            public long? Birthday { get; set; }

            [NameInMap("deptLists")]
            [Validation(Required=false)]
            public List<string> DeptLists { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("hiredDate")]
            [Validation(Required=false)]
            public long? HiredDate { get; set; }

            [NameInMap("identities")]
            [Validation(Required=false)]
            public GetOrganizationMemberResponseBodyMemberIdentities Identities { get; set; }
            public class GetOrganizationMemberResponseBodyMemberIdentities : TeaModel {
                [NameInMap("externUid")]
                [Validation(Required=false)]
                public string ExternUid { get; set; }

                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }

            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            [NameInMap("lastVisitTime")]
            [Validation(Required=false)]
            public long? LastVisitTime { get; set; }

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("organizationMemberName")]
            [Validation(Required=false)]
            public string OrganizationMemberName { get; set; }

            [NameInMap("organizationRoleId")]
            [Validation(Required=false)]
            public string OrganizationRoleId { get; set; }

            [NameInMap("organizationRoleName")]
            [Validation(Required=false)]
            public string OrganizationRoleName { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
