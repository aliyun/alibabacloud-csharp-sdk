// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallControlPolicyPositionRequest : TeaModel {
        /// <summary>
        /// The UUID of the access control policy.
        /// 
        /// If you want to modify the configurations of an access control policy, you must provide the UUID of the policy. You can call the [DescribeVpcFirewallControlPolicy](https://help.aliyun.com/document_detail/159758.html) operation to query the UUID.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The language of the content within the request and the response.
        /// 
        /// Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The new priority of the access control policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// The original priority of the access control policy.
        /// 
        /// > This parameter is not recommended. We recommend that you use the AclUuid parameter to specify the policy that you want to modify.
        /// </summary>
        [NameInMap("OldOrder")]
        [Validation(Required=false)]
        public string OldOrder { get; set; }

        /// <summary>
        /// The ID of the group to which the access control policy belongs. You can call the [DescribeVpcFirewallAclGroupList](https://help.aliyun.com/document_detail/159760.html) operation to query the ID.
        /// 
        /// Valid values:
        /// 
        /// *   If the VPC firewall is used to protect a CEN instance, the value of this parameter must be the ID of the CEN instance.
        /// 
        ///     Example: cen-ervw0g12b5jbw\\*\\*\\*\\*
        /// 
        /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter must be the instance ID of the VPC firewall.
        /// 
        ///     Example: vfw-a42bbb7b887148c9\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
