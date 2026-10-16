// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AttachPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Policy Name of the access policy.</para>
        /// <para>Policy Name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdministratorAccess</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The type of the access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom: custom access policy.</description></item>
        /// <item><description>System: system access policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The name of the authorization object. The format varies based on the object type:</para>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) user: <UserName>@<AccountAlias>.onaliyun.com, where <UserName> is the RAM username and <AccountAlias> is the account alias.</description></item>
        /// <item><description>RAM user group: <GroupName>@group.<AccountAlias>.onaliyun.com, where <GroupName> is the RAM user group name and <AccountAlias> is the account alias.</description></item>
        /// <item><description>RAM role: <RoleName>@role.<AccountAlias>.onaliyunservice.com, where <RoleName> is the RAM role name and <AccountAlias> is the account alias.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The account alias is part of the default domain name. Invoke <a href="https://help.aliyun.com/document_detail/186720.html">GetDefaultDomain</a> to obtain the account alias.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice@demo.onaliyun.com">alice@demo.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// <para>The authorization object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMSUser: Resource Access Management (RAM) user.</description></item>
        /// <item><description>IMSGroup: RAM user group.</description></item>
        /// <item><description>ServiceRole: RAM role.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMSUser</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The authorization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Resource group ID: The permissions take effect within the specified resource group.</description></item>
        /// <item><description>Alibaba Cloud account ID: The ID of the Alibaba Cloud account to which the principal belongs. The permissions take effect within the Alibaba Cloud account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
