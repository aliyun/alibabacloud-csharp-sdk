// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class BatchCopyVpcFirewallControlPolicyRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// The ID of the policy group of the source VPC firewall. Valid values:
        /// 
        /// *   If the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance.
        /// *   If the VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall.
        /// 
        /// >  You can call the [DescribeVpcFirewallAclGroupList](~~159760~~) operation to query the IDs of policy groups.
        /// </summary>
        [NameInMap("SourceVpcFirewallId")]
        [Validation(Required=false)]
        public string SourceVpcFirewallId { get; set; }

        /// <summary>
        /// The ID of the policy group of the destination VPC firewall. Valid values:
        /// 
        /// *   If the VPC firewall protects mutual access traffic between a VPC and a specified network instance that is attached to a CEN instance, the value of this parameter is the ID of the CEN instance. The network instance can be a VPC, a VBR, or a CCN instance.
        /// *   If the VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall.
        /// 
        /// >  You can call the [DescribeVpcFirewallAclGroupList](~~159760~~) operation to query the IDs of policy groups.
        /// </summary>
        [NameInMap("TargetVpcFirewallId")]
        [Validation(Required=false)]
        public string TargetVpcFirewallId { get; set; }

    }

}
