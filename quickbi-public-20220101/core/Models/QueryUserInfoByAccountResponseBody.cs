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
        /// <para>The organization user information returned.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserInfoByAccountResponseBodyResult Result { get; set; }
        public class QueryUserInfoByAccountResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID. For users who are not added through RAM self-service reading, the Alibaba Cloud ID can be obtained only after logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135****5848</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name. For RAM users, the domain name after the at sign (@) is removed. For example, <a href="mailto:test@test.com">test@test.com</a> returns test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****@163.com</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the organization administrator role is bound. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// <para><notice>This parameter is deprecated. Use the RoleIdList parameter instead.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <para>Indicates whether the permission management administrator role is attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// <para><notice>This parameter has expired and is no longer recommended. Use the RoleIdList parameter instead.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            /// <summary>
            /// <para>The intelligent modules with quota.</para>
            /// </summary>
            [NameInMap("CopilotModules")]
            [Validation(Required=false)]
            public List<string> CopilotModules { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****@163.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Disabled.</description></item>
            /// <item><description>false: Active.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>The nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestUser</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1386587****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The list of organization role IDs bound to the user.</para>
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
            /// <item><description>1: Developer.</description></item>
            /// <item><description>2: Visitor.</description></item>
            /// <item><description>3: Analyst.</description></item>
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
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
