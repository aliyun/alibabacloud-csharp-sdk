// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationMembersResponseBody : TeaModel {
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
        /// 成员列表
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListOrganizationMembersResponseBodyMembers> Members { get; set; }
        public class ListOrganizationMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// 阿里云用户ID
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// 生日
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public long? Birthday { get; set; }

            /// <summary>
            /// 部门名称列表
            /// </summary>
            [NameInMap("deptLists")]
            [Validation(Required=false)]
            public List<string> DeptLists { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 入职时间
            /// </summary>
            [NameInMap("hiredDate")]
            [Validation(Required=false)]
            public long? HiredDate { get; set; }

            /// <summary>
            /// 第三方信息
            /// </summary>
            [NameInMap("identities")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyMembersIdentities Identities { get; set; }
            public class ListOrganizationMembersResponseBodyMembersIdentities : TeaModel {
                [NameInMap("externUid")]
                [Validation(Required=false)]
                public string ExternUid { get; set; }
                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }
            };

            /// <summary>
            /// 加入云效企业时间
            /// </summary>
            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// 最近一次访问时间
            /// </summary>
            [NameInMap("lastVisitTime")]
            [Validation(Required=false)]
            public long? LastVisitTime { get; set; }

            /// <summary>
            /// 手机号
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 企业成员名
            /// </summary>
            [NameInMap("organizationMemberName")]
            [Validation(Required=false)]
            public string OrganizationMemberName { get; set; }

            /// <summary>
            /// 企业角色Id
            /// </summary>
            [NameInMap("organizationRoleId")]
            [Validation(Required=false)]
            public string OrganizationRoleId { get; set; }

            /// <summary>
            /// 企业角色名字
            /// </summary>
            [NameInMap("organizationRoleName")]
            [Validation(Required=false)]
            public string OrganizationRoleName { get; set; }

            /// <summary>
            /// 用户状态
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// 分页Token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
