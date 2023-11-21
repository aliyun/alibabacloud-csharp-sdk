// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 50**. Default value: **10**.
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
        /// The information about the queried VBR.
        /// </summary>
        [NameInMap("VirtualBorderRouterSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet VirtualBorderRouterSet { get; set; }
        public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet : TeaModel {
            [NameInMap("VirtualBorderRouterType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType> VirtualBorderRouterType { get; set; }
            public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType : TeaModel {
                /// <summary>
                /// The ID of the access point.
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// The time when the VBR was first activated.
                /// </summary>
                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                /// <summary>
                /// The information about the Cloud Enterprise Network (CEN) instance to which the VBR is attached.
                /// </summary>
                [NameInMap("AssociatedCens")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens AssociatedCens { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens : TeaModel {
                    [NameInMap("AssociatedCen")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen> AssociatedCen { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen : TeaModel {
                        /// <summary>
                        /// The ID of the CEN instance.
                        /// </summary>
                        [NameInMap("CenId")]
                        [Validation(Required=false)]
                        public string CenId { get; set; }

                        /// <summary>
                        /// The ID of the Alibaba Cloud account to which the CEN instance belongs.
                        /// </summary>
                        [NameInMap("CenOwnerId")]
                        [Validation(Required=false)]
                        public long? CenOwnerId { get; set; }

                        /// <summary>
                        /// The status of the CEN instance. Valid values:
                        /// 
                        /// *   **Attached**: The VBR is attached to the CEN instance.
                        /// *   **Attaching**: The VBR is being attached to the CEN instance.
                        /// *   **Detached**: The VBR is detached from the CEN instance.
                        /// *   **Detaching**: The VBR is being detached from the CEN instance.
                        /// *   If no value is returned, the VBR is not attached to a CEN instance.
                        /// </summary>
                        [NameInMap("CenStatus")]
                        [Validation(Required=false)]
                        public string CenStatus { get; set; }

                    }

                }

                /// <summary>
                /// The information about the Express Connect circuit that is associated with the VBR.
                /// </summary>
                [NameInMap("AssociatedPhysicalConnections")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections AssociatedPhysicalConnections { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections : TeaModel {
                    [NameInMap("AssociatedPhysicalConnection")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection> AssociatedPhysicalConnection { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection : TeaModel {
                        /// <summary>
                        /// The circuit code of the Express Connect circuit. The circuit code is provided by the ISP.
                        /// </summary>
                        [NameInMap("CircuitCode")]
                        [Validation(Required=false)]
                        public string CircuitCode { get; set; }

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
                        /// The IPv4 address of the gateway device on the user side.
                        /// </summary>
                        [NameInMap("PeerGatewayIp")]
                        [Validation(Required=false)]
                        public string PeerGatewayIp { get; set; }

                        /// <summary>
                        /// The IPv6 address of the gateway device on the user side.
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
                        /// The business status of the Express Connect circuit.
                        /// 
                        /// *   **Normal:** The Express Connect circuit is running as normal.
                        /// *   **FinancialLocked:** The Express Connect circuit is locked due to overdue payments.
                        /// </summary>
                        [NameInMap("PhysicalConnectionBusinessStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionBusinessStatus { get; set; }

                        /// <summary>
                        /// The ID of the Express Connect circuit.
                        /// </summary>
                        [NameInMap("PhysicalConnectionId")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionId { get; set; }

                        /// <summary>
                        /// The ID of the Alibaba Cloud account to which the Express Connect circuit belongs.
                        /// </summary>
                        [NameInMap("PhysicalConnectionOwnerUid")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionOwnerUid { get; set; }

                        /// <summary>
                        /// The status of the Express Connect circuit.
                        /// 
                        /// *   **Initial:** The application is under review.
                        /// *   **Approved**: The application is approved.
                        /// *   **Allocating**: The system is allocating resources.
                        /// *   **Allocated**: The Express Connect circuit is under construction.
                        /// *   **Confirmed**: The Express Connect circuit is to be confirmed.
                        /// *   **Enabled**: The Express Connect circuit is enabled.
                        /// *   **Rejected**: The application is rejected.
                        /// *   **Canceled**: The application is canceled.
                        /// *   **Allocation Failed:** The system failed to allocate resources.
                        /// *   **Terminated:** The Express Connect circuit is disabled.
                        /// </summary>
                        [NameInMap("PhysicalConnectionStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionStatus { get; set; }

                        /// <summary>
                        /// The status of the VBR. Valid values:
                        /// 
                        /// *   **unconfirmed**
                        /// *   **active**
                        /// *   **terminating**
                        /// *   **terminated**
                        /// *   **recovering**
                        /// *   **deleting**
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The VLAN ID of the VBR.
                        /// </summary>
                        [NameInMap("VlanId")]
                        [Validation(Required=false)]
                        public string VlanId { get; set; }

                        /// <summary>
                        /// The ID of the VBR interface, which can be used as the next hop of a VBR route.
                        /// </summary>
                        [NameInMap("VlanInterfaceId")]
                        [Validation(Required=false)]
                        public string VlanInterfaceId { get; set; }

                    }

                }

                /// <summary>
                /// The bandwidth of the VBR. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The circuit code of the Express Connect circuit. The circuit code is provided by the Internet service provider (ISP).
                /// </summary>
                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                /// <summary>
                /// The ID of the cloud box.
                /// </summary>
                [NameInMap("CloudBoxInstanceId")]
                [Validation(Required=false)]
                public string CloudBoxInstanceId { get; set; }

                /// <summary>
                /// The time when the VBR was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the VBR.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The multiple of the detection time.
                /// 
                /// This value indicates the maximum number of dropped packets that is allowed by the receiver when the initiator transmits packets. This value can be used to check whether the connection works as expected.
                /// 
                /// Valid values: **3 to 10**.
                /// </summary>
                [NameInMap("DetectMultiplier")]
                [Validation(Required=false)]
                public long? DetectMultiplier { get; set; }

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
                /// The time interval to receive BFD packets. Valid values: **200 to 1000**. Unit: milliseconds.
                /// </summary>
                [NameInMap("MinRxInterval")]
                [Validation(Required=false)]
                public long? MinRxInterval { get; set; }

                /// <summary>
                /// The time interval to send Bidirectional Forwarding Detection (BFD) packets. Valid values: **200 to 1000**. Unit: milliseconds.
                /// </summary>
                [NameInMap("MinTxInterval")]
                [Validation(Required=false)]
                public long? MinTxInterval { get; set; }

                /// <summary>
                /// The name of the VBR.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The billing method of the VBR. Valid values:
                /// 
                /// *   **PrePaid**: subscription. If you choose this billing method, make sure that your Alibaba Cloud account supports balance payments or credit payments.
                /// *   **PostPaid**: pay-as-you-go
                /// </summary>
                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                /// <summary>
                /// The time when the VBR expires.
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
                /// </summary>
                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                /// <summary>
                /// The subnet mask of the IPv6 addresses configured on the user side and Alibaba Cloud side.
                /// </summary>
                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                /// <summary>
                /// The subnet mask of the IPv4 addresses configured on the user side and Alibaba Cloud side.
                /// </summary>
                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                /// <summary>
                /// The business status of the Express Connect circuit.
                /// 
                /// *   **Normal:** The Express Connect circuit is running asnormal.
                /// *   **FinancialLocked:** The Express Connect circuit is locked due to overdue payments.
                /// </summary>
                [NameInMap("PhysicalConnectionBusinessStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionBusinessStatus { get; set; }

                /// <summary>
                /// The ID of the Express Connect circuit to which the VBR belongs.
                /// </summary>
                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the Express Connect circuit belongs.
                /// </summary>
                [NameInMap("PhysicalConnectionOwnerUid")]
                [Validation(Required=false)]
                public string PhysicalConnectionOwnerUid { get; set; }

                /// <summary>
                /// The status of the Express Connect circuit.
                /// 
                /// *   **Initial:** The application is under review.
                /// *   **Approved**: The application is approved.
                /// *   **Allocating**: The system is allocating resources.
                /// *   **Allocated**: The Express Connect circuit is under construction.
                /// *   **Confirmed**: The Express Connect circuit is to be confirmed.
                /// *   **Enabled**: The Express Connect circuit is enabled.
                /// *   **Rejected**: The application is rejected.
                /// *   **Canceled**: The application is canceled.
                /// *   **Allocation Failed:** The system failed to allocate resources.
                /// *   **Terminated:** The Express Connect circuit is disabled.
                /// </summary>
                [NameInMap("PhysicalConnectionStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionStatus { get; set; }

                /// <summary>
                /// The time when the status of the VBR last changed from **terminated** to **active**.
                /// </summary>
                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the VBR route table.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// The status of the VBR. Valid values:
                /// 
                /// *   **unconfirmed**
                /// *   **active**
                /// *   **terminating**
                /// *   **terminated**
                /// *   **recovering**
                /// *   **deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTags Tags { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTagsTags> Tags { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeTagsTags : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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
                /// The VLAN ID of the VBR.
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

                /// <summary>
                /// The ID of the VBR interface.
                /// </summary>
                [NameInMap("VlanInterfaceId")]
                [Validation(Required=false)]
                public string VlanInterfaceId { get; set; }

            }

        }

    }

}
