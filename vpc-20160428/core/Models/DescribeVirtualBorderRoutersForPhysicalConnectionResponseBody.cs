// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about VBRs.
        /// </summary>
        [NameInMap("VirtualBorderRouterForPhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet VirtualBorderRouterForPhysicalConnectionSet { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSet : TeaModel {
            [NameInMap("VirtualBorderRouterForPhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType> VirtualBorderRouterForPhysicalConnectionType { get; set; }
            public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseBodyVirtualBorderRouterForPhysicalConnectionSetVirtualBorderRouterForPhysicalConnectionType : TeaModel {
                /// <summary>
                /// The time when the VBR was first activated.
                /// </summary>
                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                /// <summary>
                /// The bandwidth of the VBR that is associated with the Express Connect circuit. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The status of the bandwidth. Valid values:
                /// 
                /// *   **Active**
                /// *   **Inactive**
                /// </summary>
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                /// <summary>
                /// The circuit code of the Express Connect circuit. The circuit code is provided by the Internet service provider (ISP).
                /// </summary>
                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                /// <summary>
                /// The time when the VBR was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the ECC instance.
                /// </summary>
                [NameInMap("EccId")]
                [Validation(Required=false)]
                public string EccId { get; set; }

                /// <summary>
                /// Indicates whether IPv6 is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("EnableIpv6")]
                [Validation(Required=false)]
                public bool? EnableIpv6 { get; set; }

                /// <summary>
                /// The IPv4 address of the gateway device on the Alibaba Cloud side.
                /// </summary>
                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                /// <summary>
                /// The IPv6 address of the gateway device on the Alibaba Cloud side.
                /// </summary>
                [NameInMap("LocalIpv6GatewayIp")]
                [Validation(Required=false)]
                public string LocalIpv6GatewayIp { get; set; }

                /// <summary>
                /// The status of the VBR that is associated with the Express Connect circuit. Valid values:
                /// 
                /// *   **Normal**: The VBR is running as expected.
                /// *   **FinancialLocked**: The VBR is locked due to overdue payments.
                /// </summary>
                [NameInMap("PConnVbrBussinessStatus")]
                [Validation(Required=false)]
                public string PConnVbrBussinessStatus { get; set; }

                /// <summary>
                /// The billing method of the VBR that is associated with the Express Connect circuit. Valid values:
                /// 
                /// *   **PrePaid**: subscription. If you choose this billing method, make sure that your Alibaba Cloud account supports balance payments or credit payments.
                /// *   **PostPaid**: pay-as-you-go.
                /// </summary>
                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                /// <summary>
                /// The time when the VBR that is associated with the Express Connect circuit expires.
                /// </summary>
                [NameInMap("PConnVbrExpireTime")]
                [Validation(Required=false)]
                public string PConnVbrExpireTime { get; set; }

                /// <summary>
                /// The IPv4 address of the gateway device on the user side.
                /// </summary>
                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                /// <summary>
                /// The IPv6 address of the gateway device on the user side.
                /// 
                /// This parameter is required if you create a VBR for the owner of the Express Connect circuit. You can leave this parameter empty if you create a VBR for other Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                /// <summary>
                /// The subnet mask for the IPv6 addresses of the gateway devices on the Alibaba Cloud side and on the user side.
                /// 
                /// The two IPv6 addresses must fall within the same subnet.
                /// </summary>
                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                /// <summary>
                /// The subnet mask for the IPv4 addresses of the gateway devices on the Alibaba Cloud side and on the user side.
                /// 
                /// The two IPv4 addresses must fall within the same subnet.
                /// </summary>
                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                /// <summary>
                /// The time when the status of the VBR last changed from Terminated to Active.
                /// </summary>
                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                /// <summary>
                /// The status of the VBR. Valid values:
                /// 
                /// *   **Unconfirmed**: The VBR is pending confirmation from other users.
                /// *   **Active**: The VBR is normal.
                /// *   **Terminating**: The VBR is being disabled.
                /// *   **Terminated**: The VBR is disabled.
                /// *   **Recovering**: The VBR is being recovered.
                /// *   **Deleting**: The VBR is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the VBR was last disabled.
                /// </summary>
                [NameInMap("TerminationTime")]
                [Validation(Required=false)]
                public string TerminationTime { get; set; }

                /// <summary>
                /// The type of the VBR.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The VBR ID.
                /// </summary>
                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the VBR belongs.
                /// 
                /// If the owner of the VBR is the same as that of the Express Connect circuit, this parameter is left empty.
                /// </summary>
                [NameInMap("VbrOwnerUid")]
                [Validation(Required=false)]
                public long? VbrOwnerUid { get; set; }

                /// <summary>
                /// The virtual local area network (VLAN) ID of the VBR.
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

            }

        }

    }

}
