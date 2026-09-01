// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to assign the organization administrator role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
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
        public bool? AdminUser { get; set; }

        /// <summary>
        /// <para>Specifies whether to assign the organization permission management administrator role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para><notice>This parameter has expired and is not recommended. When RoleIds is specified, this parameter does not take effect.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthAdminUser")]
        [Validation(Required=false)]
        public bool? AuthAdminUser { get; set; }

        /// <summary>
        /// <para>The intelligent module quota modification information.</para>
        /// <para>Pass the parameter as a JSON array. Each array element contains the following fields:</para>
        /// <para>moduleType -- The intelligent module.</para>
        /// <list type="bullet">
        /// <item><description>smartQAskNum -- Smart Q questions.</description></item>
        /// <item><description>smartQDevNum -- Smart Q building.</description></item>
        /// <item><description>qreport -- Smart Q reports.</description></item>
        /// <item><description>qExploreNum -- Smart Q exploration edition.</description></item>
        /// </list>
        /// <para>status -- Specifies whether to enable the module.</para>
        /// <list type="bullet">
        /// <item><description>0 -- Revoke authorization.</description></item>
        /// <item><description>1 -- Grant authorization.</description></item>
        /// </list>
        /// 
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
        /// <para>The user status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Activated.</description></item>
        /// <item><description><b>true</b>: Deactivated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>The nickname.</para>
        /// <list type="bullet">
        /// <item><description>Format check: The maximum length is 50 characters.</description></item>
        /// <item><description>Special format check: Chinese characters, English characters, digits, _ \ / | () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// <para>The ID of the user to update. This user ID is the Quick BI UserID, not the Alibaba Cloud UID.</para>
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

}
