// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeVirtualBorderRoutersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("VirtualBorderRouterSet")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet> VirtualBorderRouterSet { get; set; }
        public class DescribeVirtualBorderRoutersResponseBodyVirtualBorderRouterSet : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VlanInterfaceId")]
            [Validation(Required=false)]
            public string VlanInterfaceId { get; set; }

            [NameInMap("CircuitCode")]
            [Validation(Required=false)]
            public string CircuitCode { get; set; }

            [NameInMap("PhysicalConnectionOwnerUid")]
            [Validation(Required=false)]
            public string PhysicalConnectionOwnerUid { get; set; }

            [NameInMap("LocalGatewayIp")]
            [Validation(Required=false)]
            public string LocalGatewayIp { get; set; }

            [NameInMap("ActivationTime")]
            [Validation(Required=false)]
            public string ActivationTime { get; set; }

            [NameInMap("PhysicalConnectionBusinessStatus")]
            [Validation(Required=false)]
            public string PhysicalConnectionBusinessStatus { get; set; }

            [NameInMap("PeeringSubnetMask")]
            [Validation(Required=false)]
            public string PeeringSubnetMask { get; set; }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("PhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string PhysicalConnectionStatus { get; set; }

            [NameInMap("RecoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

            [NameInMap("TerminationTime")]
            [Validation(Required=false)]
            public string TerminationTime { get; set; }

            [NameInMap("PeerGatewayIp")]
            [Validation(Required=false)]
            public string PeerGatewayIp { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public int? VlanId { get; set; }

        }

    }

}
