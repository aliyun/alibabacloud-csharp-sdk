// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public DescribeNatGatewaysResponseBodyNatGateways NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("NatGateway")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGateway> NatGateway { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysNatGateway : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string VpcId { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayBandwidthPackageIds BandwidthPackageIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayBandwidthPackageIds : TeaModel {
                    [NameInMap("BandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> BandwidthPackageId { get; set; }

                }
                public string Spec { get; set; }
                public string InstanceChargeType { get; set; }
                public string RegionId { get; set; }
                public string Description { get; set; }
                public string NatGatewayId { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }
                public string BusinessStatus { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
