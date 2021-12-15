// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// member信息
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListProjectMembersResponseBodyMembers> Members { get; set; }
        public class ListProjectMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// 登陆账号
            /// </summary>
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// 用户头像
            /// </summary>
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// 钉钉id
            /// </summary>
            [NameInMap("dingTalkId")]
            [Validation(Required=false)]
            public string DingTalkId { get; set; }

            /// <summary>
            /// 展示名
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 展示昵称
            /// </summary>
            [NameInMap("displayNickName")]
            [Validation(Required=false)]
            public string DisplayNickName { get; set; }

            /// <summary>
            /// 展示真名
            /// </summary>
            [NameInMap("displayRealName")]
            [Validation(Required=false)]
            public string DisplayRealName { get; set; }

            /// <summary>
            /// 部门信息
            /// </summary>
            [NameInMap("division")]
            [Validation(Required=false)]
            public ListProjectMembersResponseBodyMembersDivision Division { get; set; }
            public class ListProjectMembersResponseBodyMembersDivision : TeaModel {
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }
            };

            /// <summary>
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 性别
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// 用户唯一 标识符
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 手机号
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 英文名
            /// </summary>
            [NameInMap("nameEn")]
            [Validation(Required=false)]
            public string NameEn { get; set; }

            /// <summary>
            /// 昵称
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 昵称拼音
            /// </summary>
            [NameInMap("nickNamePinyin")]
            [Validation(Required=false)]
            public string NickNamePinyin { get; set; }

            /// <summary>
            /// 企业信息
            /// </summary>
            [NameInMap("organizationUserInfo")]
            [Validation(Required=false)]
            public ListProjectMembersResponseBodyMembersOrganizationUserInfo OrganizationUserInfo { get; set; }
            public class ListProjectMembersResponseBodyMembersOrganizationUserInfo : TeaModel {
                [NameInMap("organizationIdentifier")]
                [Validation(Required=false)]
                public string OrganizationIdentifier { get; set; }
            };

            /// <summary>
            /// 真名
            /// </summary>
            [NameInMap("realName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// 真名拼音
            /// </summary>
            [NameInMap("realNamePinyin")]
            [Validation(Required=false)]
            public string RealNamePinyin { get; set; }

            /// <summary>
            /// 用户类型
            /// </summary>
            [NameInMap("stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("tbRoleId")]
            [Validation(Required=false)]
            public string TbRoleId { get; set; }

        }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
