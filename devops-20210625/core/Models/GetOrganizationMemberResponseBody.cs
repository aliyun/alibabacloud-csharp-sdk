// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetOrganizationMemberResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 成员
        /// </summary>
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
                /// <summary>
                /// 第三方系统的用户 id
                /// </summary>
                [NameInMap("externUid")]
                [Validation(Required=false)]
                public string ExternUid { get; set; }

                /// <summary>
                /// 第三方系统
                /// </summary>
                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }
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
        };

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
