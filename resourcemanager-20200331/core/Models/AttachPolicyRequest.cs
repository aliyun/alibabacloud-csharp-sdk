// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AttachPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The access policy name.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdministratorAccess</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The access policy type. Valid values:</para>
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
        /// <para>The name of the principal for authorization. The format is as follows:</para>
        /// <list type="bullet">
        /// <item><description>RAM user: <UserName>@<AccountAlias>.onaliyun.com, where <UserName> is the RAM username and <AccountAlias> is the account alias.</description></item>
        /// <item><description>RAM user group: <GroupName>@group.<AccountAlias>.onaliyun.com, where <GroupName> is the RAM user group name and <AccountAlias> is the account alias.</description></item>
        /// <item><description>RAM role: <RoleName>@role.<AccountAlias>.onaliyunservice.com, where <RoleName> is the RAM role name and <AccountAlias> is the account alias.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The account alias is a part of the default domain name. You can invoke the <a href="https://help.aliyun.com/document_detail/186720.html">GetDefaultDomain</a> operation to obtain the account alias.</para>
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
        /// <para>The type of the principal for authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMSUser: RAM user.</description></item>
        /// <item><description>IMSGroup: RAM user group.</description></item>
        /// <item><description>ServiceRole: RAM role.</description></item>
        /// </list>
        /// <remarks>
        /// <para>ServiceRole refers to a regular RAM role. The access policy of a service-linked role is predefined by the cloud service and cannot be modified, nor can you associate an access policy with it by calling this operation.</para>
        /// </remarks>
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
        /// <item><description>Resource group ID: The policy takes effect only within the specified resource group.</description></item>
        /// <item><description>Alibaba Cloud account ID: The ID of the Alibaba Cloud account to which the principal belongs. The policy takes effect within the Alibaba Cloud account.</description></item>
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
