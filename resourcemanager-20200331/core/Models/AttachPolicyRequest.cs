// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AttachPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission policy.</para>
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
        /// <para>The type of the permission policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom</description></item>
        /// <item><description>System</description></item>
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
        /// <para>The name of the object to which you want to attach the permission policy.</para>
        /// <list type="bullet">
        /// <item><description>If you want to attach the permission policy to a RAM user, specify the name in the @.onaliyun.com format. indicates the name of the RAM user, and indicates the alias of the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>If you want to attach the permission policy to a RAM user group, specify the name in the @group..onaliyun.com format. indicates the name of the RAM user group, and indicates the alias of the Alibaba Cloud account to which the RAM user group belongs.</description></item>
        /// <item><description>If you want to attach the permission policy to a RAM role, specify the name in the @role..onaliyunservice.com format. indicates the name of the RAM role, and indicates the alias of the Alibaba Cloud account to which the RAM role belongs.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The alias of an Alibaba Cloud account is a part of the default domain name. You can call the <a href="https://help.aliyun.com/document_detail/186720.html">GetDefaultDomain</a> operation to obtain the alias of an Alibaba Cloud account.</para>
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
        /// <para>The type of the object to which you want to attach the permission policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMSUser: RAM user</description></item>
        /// <item><description>IMSGroup: RAM user group</description></item>
        /// <item><description>ServiceRole: RAM role</description></item>
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
        /// <para>The effective scope of the permission policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ID of a resource group: indicates that the permission policy takes effect for the resources in the resource group.</description></item>
        /// <item><description>ID of the Alibaba Cloud account to which the authorized object belongs: indicates that the permission policy takes effect for the resources within the Alibaba Cloud account.</description></item>
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
