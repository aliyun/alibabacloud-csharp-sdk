// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserInfoByAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user information of the organization member.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserInfoByAccountResponseBodyResult Result { get; set; }
        public class QueryUserInfoByAccountResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud ID. For users not added through RAM self-service, this ID becomes available only after the user\&quot;s first login.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135****5848</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name. For a RAM user, the domain suffix (the part after the @ symbol) is omitted. For example, for the user <c>test@test.com</c>, the value <c>test</c> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****@163.com</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is assigned the organization administrator role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes</para>
            /// </description></item>
            /// <item><description><para>false: No</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is deprecated. Use the <c>RoleIdList</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is assigned the permission administrator role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes</para>
            /// </description></item>
            /// <item><description><para>false: No</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is deprecated. Use the <c>RoleIdList</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            /// <summary>
            /// <para>The intelligent modules for which the user has a quota.</para>
            /// </summary>
            [NameInMap("CopilotModules")]
            [Validation(Required=false)]
            public List<string> CopilotModules { get; set; }

            /// <summary>
            /// <para>The user\&quot;s email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****@163.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The user\&quot;s nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The user\&quot;s phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The IDs of the organization roles assigned to the user.</para>
            /// </summary>
            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public List<long?> RoleIdList { get; set; }

            /// <summary>
            /// <para>The user ID in Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The user type of the organization member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: developer</para>
            /// </description></item>
            /// <item><description><para>2: viewer</para>
            /// </description></item>
            /// <item><description><para>3: analyst</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
