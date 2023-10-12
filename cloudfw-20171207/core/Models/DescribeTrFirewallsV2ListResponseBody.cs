// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTrFirewallsV2ListResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The VPC firewalls.
        /// </summary>
        [NameInMap("VpcTrFirewalls")]
        [Validation(Required=false)]
        public List<DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls> VpcTrFirewalls { get; set; }
        public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewalls : TeaModel {
            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The name of the CEN instance.
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            /// <summary>
            /// The instance ID of the VPC firewall.
            /// </summary>
            [NameInMap("FirewallId")]
            [Validation(Required=false)]
            public string FirewallId { get; set; }

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
            /// >  If you do not specify this parameter, VPC firewalls in all states are queried.
            /// </summary>
            [NameInMap("FirewallSwitchStatus")]
            [Validation(Required=false)]
            public string FirewallSwitchStatus { get; set; }

            /// <summary>
            /// The information about the intrusion prevention system (IPS) configuration.
            /// </summary>
            [NameInMap("IpsConfig")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig IpsConfig { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsIpsConfig : TeaModel {
                /// <summary>
                /// Indicates whether basic protection is enabled. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("BasicRules")]
                [Validation(Required=false)]
                public int? BasicRules { get; set; }

                /// <summary>
                /// Indicates whether virtual patching is enabled. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("EnableAllPatch")]
                [Validation(Required=false)]
                public int? EnableAllPatch { get; set; }

                /// <summary>
                /// The mode of the IPS. Valid values:
                /// 
                /// *   **1**: block mode
                /// *   **0**: monitor mode
                /// </summary>
                [NameInMap("RunMode")]
                [Validation(Required=false)]
                public int? RunMode { get; set; }

            }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the VPC belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// Indicates whether the VPC firewall can be automatically enabled. Valid values:
            /// 
            /// *   **passed**: yes
            /// *   **failed**: no
            /// *   **unknown**
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// The protected resources.
            /// </summary>
            [NameInMap("ProtectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource ProtectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsProtectedResource : TeaModel {
                /// <summary>
                /// The number of protected resources.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The protected peer transit routers.
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// The protected virtual border routers (VBRs).
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// The protected VPCs.
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// The protected VPN gateways.
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// The region ID of the transit router.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// Indicates whether you can create a VPC firewall in a specified region. Valid values:
            /// 
            /// *   **enable**: yes
            /// *   **disable**: no
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// The result code of the operation that creates the VPC firewall. Valid values:
            /// 
            /// *   **RegionDisable**: VPC Firewall is not supported in the region of the network instance. You cannot create a VPC firewall for the network instance.
            /// *   **Empty string**: You can create a VPC firewall for the network instance.
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

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
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The unprotected resources.
            /// </summary>
            [NameInMap("UnprotectedResource")]
            [Validation(Required=false)]
            public DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource UnprotectedResource { get; set; }
            public class DescribeTrFirewallsV2ListResponseBodyVpcTrFirewallsUnprotectedResource : TeaModel {
                /// <summary>
                /// The number of unprotected resources.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The unprotected peer transit routers.
                /// </summary>
                [NameInMap("PeerTrList")]
                [Validation(Required=false)]
                public List<string> PeerTrList { get; set; }

                /// <summary>
                /// The unprotected VBRs.
                /// </summary>
                [NameInMap("VbrList")]
                [Validation(Required=false)]
                public List<string> VbrList { get; set; }

                /// <summary>
                /// The unprotected VPCs.
                /// </summary>
                [NameInMap("VpcList")]
                [Validation(Required=false)]
                public List<string> VpcList { get; set; }

                /// <summary>
                /// The unprotected VPN gateways.
                /// </summary>
                [NameInMap("VpnList")]
                [Validation(Required=false)]
                public List<string> VpnList { get; set; }

            }

            /// <summary>
            /// The instance name of the VPC firewall.
            /// </summary>
            [NameInMap("VpcFirewallName")]
            [Validation(Required=false)]
            public string VpcFirewallName { get; set; }

        }

    }

}
