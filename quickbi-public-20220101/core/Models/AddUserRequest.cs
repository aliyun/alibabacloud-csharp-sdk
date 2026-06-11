// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.&gt;Warning: The <c>AccountId</c> parameter will be required in Quick BI versions released after December 31, 2024. We recommend that you update your API calls to include this parameter before then.</para>
        /// 
        /// <b>Example:</b>
        /// <para>191476xxxxx23754</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the Alibaba Cloud account.</para>
        /// <list type="bullet">
        /// <item><description><para>For a sub-account, use the format <c>master account:sub-account</c>. Example: <c>master_test@aliyun.com:subaccount</c>.</para>
        /// </description></item>
        /// <item><description><para>The maximum length is 50 characters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxxxx@163.com">xxxxxx@163.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccountName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to assign the organization administrator role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated. It is ignored if <c>RoleIds</c> is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AdminUser")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AdminUser { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to assign the permission administrator role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated. It is ignored if <c>RoleIds</c> is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <para>The Copilot modules to enable for the user. To enable multiple modules, specify their codes separated by a comma (,).</para>
        /// <list type="bullet">
        /// <item><description><para><c>qreport</c>: Q Report</para>
        /// </description></item>
        /// <item><description><para><c>qExploreNum</c>: Q Explore</para>
        /// </description></item>
        /// <item><description><para><c>smartQAskNum</c>: Q\&amp;A with Data</para>
        /// </description></item>
        /// <item><description><para><c>smartQDevNum</c>: Q-assisted Building</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>qreport,qExploreNum</para>
        /// </summary>
        [NameInMap("CopilotModules")]
        [Validation(Required=false)]
        public string CopilotModules { get; set; }

        /// <summary>
        /// <para>The user\&quot;s nickname.</para>
        /// <list type="bullet">
        /// <item><description><para>The maximum length is 50 characters.</para>
        /// </description></item>
        /// <item><description><para>The nickname can contain Chinese characters, letters, digits, and the following special characters: <c>_ \\ / | () []</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The IDs of the predefined or custom organization roles to assign. You can specify up to three role IDs, separated by commas (,). Valid values for predefined roles:</para>
        /// <list type="bullet">
        /// <item><description><para><c>111111111</c>: organization administrator</para>
        /// </description></item>
        /// <item><description><para><c>111111112</c>: permission administrator</para>
        /// </description></item>
        /// <item><description><para><c>111111113</c>: regular user</para>
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
        /// <para>The type of the organization member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: developer</para>
        /// </description></item>
        /// <item><description><para>2: viewer</para>
        /// </description></item>
        /// <item><description><para>3: analyst</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
