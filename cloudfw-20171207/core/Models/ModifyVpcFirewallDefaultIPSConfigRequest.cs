// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallDefaultIPSConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable basic protection. Valid values:
        /// 
        /// *   **1**: yes.
        /// *   **0**: no.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public string BasicRules { get; set; }

        /// <summary>
        /// Specifies whether to enable virtual patching. Valid values:
        /// 
        /// *   **1**: yes.
        /// *   **0**: no.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public string EnableAllPatch { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default)
        /// *   **en**
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UID of the member that is managed by your Alibaba Cloud account.
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// The level of the rule group for the IPS. Valid values:
        /// 
        /// *   **1**: loose
        /// *   **2**: medium
        /// *   **3**: strict
        /// </summary>
        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public string RuleClass { get; set; }

        /// <summary>
        /// The mode of the intrusion prevention system (IPS). Valid values:
        /// 
        /// *   **1**: block mode.
        /// *   **0**: monitor mode.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// 
        /// *   If the VPC firewall protects traffic between a VPC and a network instance that is attached to a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance. The network instance can be a VPC, a virtual border router (VBR), or a Cloud Connect Network (CCN) instance. You can call the [DescribeVpcFirewallCenList](https://help.aliyun.com/document_detail/345777.html) operation to query the IDs of CEN instances.
        /// *   If the VPC firewall protects traffic between two VPCs that are connected by using an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall. You can call the [DescribeVpcFirewallList](https://help.aliyun.com/document_detail/342932.html) operation to query the instance IDs of VPC firewalls.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

    }

}
