// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// <remarks>
        /// <para>Warning: For Quick BI versions released after December 31, 2024, AccountId is a required parameter. Update your API calls before this date.</para>
        /// </remarks>
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
        /// <para>The Alibaba Cloud account name.</para>
        /// <list type="bullet">
        /// <item><description>Note: For a RAM user, the format is &quot;primary account:RAM user&quot;. Example: <a href="mailto:master_test@aliyun.com">master_test@aliyun.com</a>:subaccount</description></item>
        /// <item><description>Format check: The maximum length is 50 characters.</description></item>
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
        /// <para>Specifies whether to assign the organization administrator role. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Yes. </description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para><notice>This parameter is deprecated. When RoleIds is specified, this parameter does not take effect.</notice></para>
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
        /// <para>Specifies whether to assign the organization permission management administrator role. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Yes. </description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para><notice>This parameter has expired and is no longer recommended. When RoleIds is specified, this parameter does not take effect.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <para>The intelligent module quotas of the user. Separate multiple modules with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>qreport -- Small Q Report</description></item>
        /// <item><description>qExploreNum -- Small Q Explorer</description></item>
        /// <item><description>smartQAskNum -- Small Q Ask</description></item>
        /// <item><description>smartQDevNum -- Small Q Builder</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>qreport,qExploreNum</para>
        /// </summary>
        [NameInMap("CopilotModules")]
        [Validation(Required=false)]
        public string CopilotModules { get; set; }

        /// <summary>
        /// <para>The nickname of the Alibaba Cloud account.</para>
        /// <list type="bullet">
        /// <item><description>Format check: The maximum length is 50 characters.</description></item>
        /// <item><description>Special character validation: Chinese characters, English characters, digits, _ \ / | () ] [</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The IDs of preset or custom organization roles to attach to the user, separated by commas (,). A maximum of three role IDs are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Organization administrator (preset role): 111111111</description></item>
        /// <item><description>Permission management administrator (preset role): 111111112</description></item>
        /// <item><description>Common user (preset role): 111111113</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>111111111,456</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The user type of the organization member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Developer.</description></item>
        /// <item><description>2: Visitor.</description></item>
        /// <item><description>3: Analyst.</description></item>
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
