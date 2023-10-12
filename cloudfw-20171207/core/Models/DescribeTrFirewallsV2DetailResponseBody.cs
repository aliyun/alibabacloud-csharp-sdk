// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2DetailResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The description of the VPC firewall.
        /// </summary>
        [NameInMap("FirewallDescription")]
        [Validation(Required=false)]
        public string FirewallDescription { get; set; }

        /// <summary>
        /// The ID of the Elastic Network Interface (ENI) with which the VPC firewall is associated.
        /// </summary>
        [NameInMap("FirewallEniId")]
        [Validation(Required=false)]
        public string FirewallEniId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the ENI is attached.
        /// </summary>
        [NameInMap("FirewallEniVpcId")]
        [Validation(Required=false)]
        public string FirewallEniVpcId { get; set; }

        /// <summary>
        /// The ID of the vSwitch with which the ENI is associated.
        /// </summary>
        [NameInMap("FirewallEniVswitchId")]
        [Validation(Required=false)]
        public string FirewallEniVswitchId { get; set; }

        /// <summary>
        /// The instance ID of the VPC firewall.
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// The name of the VPC firewall.
        /// </summary>
        [NameInMap("FirewallName")]
        [Validation(Required=false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// The status of the VPC firewall. Valid values:
        /// 
        /// *   Creating
        /// *   Deleting
        /// *   Ready
        /// </summary>
        [NameInMap("FirewallStatus")]
        [Validation(Required=false)]
        public string FirewallStatus { get; set; }

        /// <summary>
        /// The subnet CIDR block of the VPC in which the ENI of the firewall is stored in automatic mode.
        /// </summary>
        [NameInMap("FirewallSubnetCidr")]
        [Validation(Required=false)]
        public string FirewallSubnetCidr { get; set; }

        /// <summary>
        /// The status of the VPC firewall. Valid values:
        /// 
        /// *   **opened**: The VPC firewall is enabled.
        /// *   **closed**: The VPC firewall is disabled.
        /// *   **notconfigured**: The VPC firewall is not created.
        /// *   **configured**: The VPC firewall is created but is not enabled.
        /// *   **creating**: The VPC firewall is being created.
        /// *   **opening**: The VPC firewall is being enabled.
        /// *   **deleting**: The VPC firewall is being deleted.
        /// 
        /// > If you do not specify this parameter, VPC firewalls in all states are queried.
        /// </summary>
        [NameInMap("FirewallSwitchStatus")]
        [Validation(Required=false)]
        public string FirewallSwitchStatus { get; set; }

        /// <summary>
        /// The CIDR block that is allocated to the VPC created for the VPC firewall in automatic mode.
        /// </summary>
        [NameInMap("FirewallVpcCidr")]
        [Validation(Required=false)]
        public string FirewallVpcCidr { get; set; }

        /// <summary>
        /// The region ID of the transit router.
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The routing mode of the VPC firewall. Valid values:
        /// 
        /// *   **managed**: automatic mode
        /// *   **manual**: manual mode
        /// </summary>
        [NameInMap("RouteMode")]
        [Validation(Required=false)]
        public string RouteMode { get; set; }

        /// <summary>
        /// The primary subnet CIDR block that the VPC uses to connect to the transit router in automatic mode.
        /// </summary>
        [NameInMap("TrAttachmentMasterCidr")]
        [Validation(Required=false)]
        public string TrAttachmentMasterCidr { get; set; }

        /// <summary>
        /// The secondary subnet CIDR block that the VPC uses to connect to the transit router in automatic mode.
        /// </summary>
        [NameInMap("TrAttachmentSlaveCidr")]
        [Validation(Required=false)]
        public string TrAttachmentSlaveCidr { get; set; }

        /// <summary>
        /// The ID of the transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
