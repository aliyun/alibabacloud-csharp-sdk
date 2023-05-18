// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AttachPolicyRequest : TeaModel {
        /// <summary>
        /// The name of the policy.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The type of the policy. Valid values:
        /// 
        /// *   Custom: custom policy
        /// *   System: system policy
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// The name of the object to which you want to attach the policy.
        /// 
        /// *   If you want to attach the policy to a RAM user, specify the name in the \<UserName>@\<AccountAlias>.onaliyun.com format. \<UserName> indicates the name of the RAM user, and \<AccountAlias> indicates the alias of the Alibaba Cloud account to which the RAM user belongs.
        /// *   If you want to attach the policy to a RAM user group, specify the name in the \<GroupName>@group.\<AccountAlias>.onaliyun.com format. \<GroupName> indicates the name of the RAM user group, and \<AccountAlias> indicates the alias of the Alibaba Cloud account to which the RAM user group belongs.
        /// *   If you want to attach the policy to a RAM role, specify the name in the \<RoleName>@role.\<AccountAlias>.onaliyun.com format. \<RoleName> indicates the name of the RAM role, and \<AccountAlias> indicates the alias of the Alibaba Cloud account to which the RAM role belongs.
        /// 
        /// >  The alias of an Alibaba Cloud account is a part of the default domain name. You can call the [GetDefaultDomain](~~186720~~) operation to obtain the alias of an Alibaba Cloud account.
        /// </summary>
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// The type of the object to which you want to attach the policy. Valid values:
        /// 
        /// *   IMSUser: RAM user
        /// *   IMSGroup: RAM user group
        /// *   ServiceRole: RAM role
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// The effective scope of the policy. You can set this parameter to one of the following items:
        /// 
        /// *   ID of a resource group: indicates that the policy takes effect for the resources in the resource group.
        /// *   ID of the Alibaba Cloud account to which the authorized object belongs: indicates that the policy takes effect for the resources within the Alibaba Cloud account.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
