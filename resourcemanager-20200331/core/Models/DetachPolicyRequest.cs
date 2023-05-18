// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DetachPolicyRequest : TeaModel {
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
        /// The name of the object to which the policy is attached.
        /// </summary>
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// The type of the object to which the policy is attached. Valid values:
        /// 
        /// *   IMSUser: RAM user
        /// *   IMSGroup: RAM user group
        /// *   ServiceRole: RAM role
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// The ID of the resource group or the ID of the Alibaba Cloud account to which the resource group belongs.
        /// 
        /// This parameter specifies the resource group or Alibaba Cloud account for which you want to revoke permissions.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
