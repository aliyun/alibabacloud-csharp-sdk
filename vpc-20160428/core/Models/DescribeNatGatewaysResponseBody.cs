// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
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
                public bool? AutoPay { get; set; }
                public string BusinessStatus { get; set; }
                public string CreationTime { get; set; }
                public bool? DeletionProtection { get; set; }
                public string Description { get; set; }
                public bool? EcsMetricEnabled { get; set; }
                public string ExpiredTime { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds ForwardTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayForwardTableIds : TeaModel {
                    [NameInMap("ForwardTableId")]
                    [Validation(Required=false)]
                    public List<string> ForwardTableId { get; set; }

                }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds FullNatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayFullNatTableIds : TeaModel {
                    [NameInMap("FullNatTableId")]
                    [Validation(Required=false)]
                    public List<string> FullNatTableId { get; set; }

                }
                public bool? IcmpReplyEnabled { get; set; }
                public string InstanceChargeType { get; set; }
                public string InternetChargeType { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists IpLists { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpLists : TeaModel {
                    [NameInMap("IpList")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList> IpList { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayIpListsIpList : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        [NameInMap("PrivateIpAddress")]
                        [Validation(Required=false)]
                        public string PrivateIpAddress { get; set; }

                        [NameInMap("SnatEntryEnabled")]
                        [Validation(Required=false)]
                        public bool? SnatEntryEnabled { get; set; }

                        [NameInMap("UsingStatus")]
                        [Validation(Required=false)]
                        public string UsingStatus { get; set; }

                    }

                }
                public string Name { get; set; }
                public string NatGatewayId { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo NatGatewayPrivateInfo { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayNatGatewayPrivateInfo : TeaModel {
                    [NameInMap("EniInstanceId")]
                    [Validation(Required=false)]
                    public string EniInstanceId { get; set; }

                    [NameInMap("EniType")]
                    [Validation(Required=false)]
                    public string EniType { get; set; }

                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    [NameInMap("MaxBandwidth")]
                    [Validation(Required=false)]
                    public int? MaxBandwidth { get; set; }

                    [NameInMap("MaxSessionEstablishRate")]
                    [Validation(Required=false)]
                    public int? MaxSessionEstablishRate { get; set; }

                    [NameInMap("MaxSessionQuota")]
                    [Validation(Required=false)]
                    public int? MaxSessionQuota { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }
                public string NatType { get; set; }
                public string NetworkType { get; set; }
                public bool? PrivateLinkEnabled { get; set; }
                public string PrivateLinkMode { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public bool? SecurityProtectionEnabled { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds SnatTableIds { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewaySnatTableIds : TeaModel {
                    [NameInMap("SnatTableId")]
                    [Validation(Required=false)]
                    public List<string> SnatTableId { get; set; }

                }
                public string Spec { get; set; }
                public string Status { get; set; }
                public DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags Tags { get; set; }
                public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag> Tag { get; set; }
                    public class DescribeNatGatewaysResponseBodyNatGatewaysNatGatewayTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
                public string VpcId { get; set; }
            }
        };

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
