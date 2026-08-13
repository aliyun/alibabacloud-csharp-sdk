// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAuthorizedUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>授权模式：SPECIFIED_USERS / ALL_USERS</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("authMode")]
        [Validation(Required=false)]
        public string AuthMode { get; set; }

        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>已授权对象列表</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAuthorizedUsersResponseBodyItems> Items { get; set; }
        public class ListAuthorizedUsersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>授权截止时间戳（毫秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("expireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>最后修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>授权人用户 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("grantedBy")]
            [Validation(Required=false)]
            public long? GrantedBy { get; set; }

            /// <summary>
            /// <para>被授权对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleGranteeId</para>
            /// </summary>
            [NameInMap("granteeId")]
            [Validation(Required=false)]
            public string GranteeId { get; set; }

            /// <summary>
            /// <para>被授权对象类型：USER / USER_GROUP</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("granteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>授权记录 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>用户组成员数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// <para>已授权的权限列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

            /// <summary>
            /// <para>用户组 ID（granteeType=USER_GROUP 时有值）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleUserGroupId</para>
            /// </summary>
            [NameInMap("userGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            /// <summary>
            /// <para>用户组名</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("userGroupName")]
            [Validation(Required=false)]
            public string UserGroupName { get; set; }

            /// <summary>
            /// <para>用户 ID（granteeType=USER 时有值）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>授权记录总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
