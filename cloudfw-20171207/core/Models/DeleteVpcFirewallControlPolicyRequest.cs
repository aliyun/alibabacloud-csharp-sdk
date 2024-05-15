// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the access control policy. 
        /// 
        /// To delete an access control policy, you must provide the ID of the policy. You can call the **DescribeVpcFirewallControlPolicy** operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// The natural language of the request and response. Valid values: 
        /// 
        /// - **zh**: Chinese
        /// - **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the group to which the access control policy belongs. You can call the **DescribeVpcFirewallAclGroupList** operation to query the ID.  
        /// 
        /// Valid values:
        /// 
        /// - If the VPC firewall is used to protect a CEN instance, the value of this parameter is the ID of the CEN instance.  
        /// 
        /// Example: cen-ervw0g12b5jbw****
        /// - If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the ID of the VPC firewall.  
        /// 
        /// Example: vfw-a42bbb7b887148c9****
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
