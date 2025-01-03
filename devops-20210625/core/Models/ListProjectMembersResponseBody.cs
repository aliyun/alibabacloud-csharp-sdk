// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListProjectMembersResponseBodyMembers> Members { get; set; }
        public class ListProjectMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxx.png">https://xxxxxx.png</a></para>
            /// </summary>
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("dingTalkId")]
            [Validation(Required=false)]
            public string DingTalkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mingcheng</para>
            /// </summary>
            [NameInMap("displayNickName")]
            [Validation(Required=false)]
            public string DisplayNickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>名称</para>
            /// </summary>
            [NameInMap("displayRealName")]
            [Validation(Required=false)]
            public string DisplayRealName { get; set; }

            [NameInMap("division")]
            [Validation(Required=false)]
            public ListProjectMembersResponseBodyMembersDivision Division { get; set; }
            public class ListProjectMembersResponseBodyMembersDivision : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1345xxxxxxx947xxxx</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:accountsxxxx@mail.com">accountsxxxx@mail.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xxxx31947xxxx</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>135xxxxxxxxx</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("nameEn")]
            [Validation(Required=false)]
            public string NameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>昵称</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nicheng</para>
            /// </summary>
            [NameInMap("nickNamePinyin")]
            [Validation(Required=false)]
            public string NickNamePinyin { get; set; }

            [NameInMap("organizationUserInfo")]
            [Validation(Required=false)]
            public ListProjectMembersResponseBodyMembersOrganizationUserInfo OrganizationUserInfo { get; set; }
            public class ListProjectMembersResponseBodyMembersOrganizationUserInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5e7xxxxb3cd3711dd6xxx2c</para>
                /// </summary>
                [NameInMap("organizationIdentifier")]
                [Validation(Required=false)]
                public string OrganizationIdentifier { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("realName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("realNamePinyin")]
            [Validation(Required=false)]
            public string RealNamePinyin { get; set; }

            /// <summary>
            /// <para>角色名称</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("tbRoleId")]
            [Validation(Required=false)]
            public string TbRoleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
