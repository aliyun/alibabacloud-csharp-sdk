// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>Whether to assign the organization administrator role to the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c></para>
        /// </description></item>
        /// <item><description><para><c>false</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated and is ignored if RoleIds is also specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AdminUser")]
        [Validation(Required=false)]
        public bool? AdminUser { get; set; }

        /// <summary>
        /// <para>Whether to assign the permission administrator role to the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c></para>
        /// </description></item>
        /// <item><description><para><c>false</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated and is ignored if RoleIds is also specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;moduleType&quot;: &quot;smartQAskNum&quot;,
        ///         &quot;status&quot;: 1
        ///     },
        ///     {
        ///         &quot;moduleType&quot;: &quot;smartQDevNum&quot;,
        ///         &quot;status&quot;: 0
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("CopilotModules")]
        [Validation(Required=false)]
        public string CopilotModules { get; set; }

        /// <summary>
        /// <para>The user status:</para>
        /// <list type="bullet">
        /// <item><description><para><b><c>false</c></b>: active</para>
        /// </description></item>
        /// <item><description><para><b><c>true</c></b>: inactive</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>The nickname of the user.</para>
        /// <list type="bullet">
        /// <item><description><para>The nickname can be up to 50 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The nickname can contain Chinese characters, letters, digits, and the following special characters: <c>_ \\ / | () ] [</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The IDs of the built-in or custom organization roles to assign to the user. Specify up to three comma-separated role IDs.</para>
        /// <list type="bullet">
        /// <item><description><para>organization administrator (built-in role): 111111111</para>
        /// </description></item>
        /// <item><description><para>permission administrator (built-in role): 111111112</para>
        /// </description></item>
        /// <item><description><para>standard user (built-in role): 111111113</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>111111111,456</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The ID of the Quick BI user to update. This is not an Alibaba Cloud UID.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para><c>1</c>: developer</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: viewer</para>
        /// </description></item>
        /// <item><description><para><c>3</c>: analyst</para>
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

}
