// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
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
                public string VpcId { get; set; }
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string NatType { get; set; }
                public string Spec { get; set; }
                public bool? DeletionProtection { get; set; }
                public string RegionId { get; set; }
                public string InstanceChargeType { get; set; }
                public bool? EcsMetricEnabled { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists IpLists { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists : TeaModel {
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList> IpList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        [NameInMap("SnatEntryEnabled")]
                        [Validation(Required=false)]
                        public bool? SnatEntryEnabled { get; set; }

                    }

                }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo NatGatewayPrivateInfo { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo : TeaModel {
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public string EniInstanceId { get; set; }

                    [NameInMap("MaxBandwidth")]
                    [Validation(Required=false)]
                    public int? MaxBandwidth { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                }
                public string ResourceGroupId { get; set; }
                public string NatGatewayId { get; set; }
                public string InternetChargeType { get; set; }
                public string BusinessStatus { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds SnatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds : TeaModel {
                    [NameInMap("SnatTableId")]
                    [Validation(Required=false)]
                    public List<string> SnatTableId { get; set; }

                }
                public string Name { get; set; }
            }
        };

    }

}
