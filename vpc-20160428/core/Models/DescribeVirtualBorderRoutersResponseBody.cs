// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VirtualBorderRouterSet")]
        [Validation(Required=false)]
        public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet VirtualBorderRouterSet { get; set; }
        public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet : TeaModel {
            [NameInMap("VirtualBorderRouterType")]
            [Validation(Required=false)]
            public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType> VirtualBorderRouterType { get; set; }
            public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterType : TeaModel {
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("ActivationTime")]
                [Validation(Required=false)]
                public string ActivationTime { get; set; }

                [NameInMap("AssociatedCens")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens AssociatedCens { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCens : TeaModel {
                    [NameInMap("AssociatedCen")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen> AssociatedCen { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedCensAssociatedCen : TeaModel {
                        [NameInMap("CenId")]
                        [Validation(Required=false)]
                        public string CenId { get; set; }

                        [NameInMap("CenOwnerId")]
                        [Validation(Required=false)]
                        public long? CenOwnerId { get; set; }

                        [NameInMap("CenStatus")]
                        [Validation(Required=false)]
                        public string CenStatus { get; set; }

                    }

                }

                [NameInMap("AssociatedPhysicalConnections")]
                [Validation(Required=false)]
                public DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections AssociatedPhysicalConnections { get; set; }
                public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnections : TeaModel {
                    [NameInMap("AssociatedPhysicalConnection")]
                    [Validation(Required=false)]
                    public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection> AssociatedPhysicalConnection { get; set; }
                    public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSetVirtualBorderRouterTypeAssociatedPhysicalConnectionsAssociatedPhysicalConnection : TeaModel {
                        [NameInMap("CircuitCode")]
                        [Validation(Required=false)]
                        public string CircuitCode { get; set; }

                        [NameInMap("EnableIpv6")]
                        [Validation(Required=false)]
                        public bool? EnableIpv6 { get; set; }

                        [NameInMap("LocalGatewayIp")]
                        [Validation(Required=false)]
                        public string LocalGatewayIp { get; set; }

                        [NameInMap("LocalIpv6GatewayIp")]
                        [Validation(Required=false)]
                        public string LocalIpv6GatewayIp { get; set; }

                        [NameInMap("PeerGatewayIp")]
                        [Validation(Required=false)]
                        public string PeerGatewayIp { get; set; }

                        [NameInMap("PeerIpv6GatewayIp")]
                        [Validation(Required=false)]
                        public string PeerIpv6GatewayIp { get; set; }

                        [NameInMap("PeeringIpv6SubnetMask")]
                        [Validation(Required=false)]
                        public string PeeringIpv6SubnetMask { get; set; }

                        [NameInMap("PeeringSubnetMask")]
                        [Validation(Required=false)]
                        public string PeeringSubnetMask { get; set; }

                        [NameInMap("PhysicalConnectionBusinessStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionBusinessStatus { get; set; }

                        [NameInMap("PhysicalConnectionId")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionId { get; set; }

                        [NameInMap("PhysicalConnectionOwnerUid")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionOwnerUid { get; set; }

                        [NameInMap("PhysicalConnectionStatus")]
                        [Validation(Required=false)]
                        public string PhysicalConnectionStatus { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("VlanId")]
                        [Validation(Required=false)]
                        public string VlanId { get; set; }

                        [NameInMap("VlanInterfaceId")]
                        [Validation(Required=false)]
                        public string VlanInterfaceId { get; set; }

                    }

                }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                [NameInMap("CloudBoxInstanceId")]
                [Validation(Required=false)]
                public string CloudBoxInstanceId { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DetectMultiplier")]
                [Validation(Required=false)]
                public long? DetectMultiplier { get; set; }

                [NameInMap("EccId")]
                [Validation(Required=false)]
                public string EccId { get; set; }

                [NameInMap("EnableIpv6")]
                [Validation(Required=false)]
                public bool? EnableIpv6 { get; set; }

                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                [NameInMap("LocalIpv6GatewayIp")]
                [Validation(Required=false)]
                public string LocalIpv6GatewayIp { get; set; }

                [NameInMap("MinRxInterval")]
                [Validation(Required=false)]
                public long? MinRxInterval { get; set; }

                [NameInMap("MinTxInterval")]
                [Validation(Required=false)]
                public long? MinTxInterval { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PConnVbrChargeType")]
                [Validation(Required=false)]
                public string PConnVbrChargeType { get; set; }

                [NameInMap("PConnVbrExpireTime")]
                [Validation(Required=false)]
                public string PConnVbrExpireTime { get; set; }

                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                [NameInMap("PeerIpv6GatewayIp")]
                [Validation(Required=false)]
                public string PeerIpv6GatewayIp { get; set; }

                [NameInMap("PeeringIpv6SubnetMask")]
                [Validation(Required=false)]
                public string PeeringIpv6SubnetMask { get; set; }

                [NameInMap("PeeringSubnetMask")]
                [Validation(Required=false)]
                public string PeeringSubnetMask { get; set; }

                [NameInMap("PhysicalConnectionBusinessStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionBusinessStatus { get; set; }

                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                [NameInMap("PhysicalConnectionOwnerUid")]
                [Validation(Required=false)]
                public string PhysicalConnectionOwnerUid { get; set; }

                [NameInMap("PhysicalConnectionStatus")]
                [Validation(Required=false)]
                public string PhysicalConnectionStatus { get; set; }

                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public string RecoveryTime { get; set; }

                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TerminationTime")]
                [Validation(Required=false)]
                public string TerminationTime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public int? VlanId { get; set; }

                [NameInMap("VlanInterfaceId")]
                [Validation(Required=false)]
                public string VlanInterfaceId { get; set; }

            }

        }

    }

}
