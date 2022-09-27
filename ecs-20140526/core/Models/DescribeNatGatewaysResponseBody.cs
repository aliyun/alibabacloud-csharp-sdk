// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public DescribeNatGatewaysResponseBodyNatGateways NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            [NameInMap("NatGateway")]
            [Validation(Required=false)]
            public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGateway> NatGateway { get; set; }
            public class DescribeNatGatewaysResponseBodyNatGatewaysNatGateway : TeaModel {
                [NameInMap("BandwidthPackageIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayBandwidthPackageIds BandwidthPackageIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayBandwidthPackageIds : TeaModel {
                    [NameInMap("BandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> BandwidthPackageId { get; set; }

                }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ForwardTableIds")]
                [Validation(Required=false)]
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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

    }

}
