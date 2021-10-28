// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewaysResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Gateways")]
        [Validation(Required=false)]
        public DescribeGatewaysResponseBodyGateways Gateways { get; set; }
        public class DescribeGatewaysResponseBodyGateways : TeaModel {
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public List<DescribeGatewaysResponseBodyGatewaysGateway> Gateway { get; set; }
            public class DescribeGatewaysResponseBodyGatewaysGateway : TeaModel {
                public long? ActivatedTime { get; set; }
                public string BuyURL { get; set; }
                public int? Capacity { get; set; }
                public string Category { get; set; }
                public string CommonBuyInstanceId { get; set; }
                public long? CreatedTime { get; set; }
                public int? DataLoadInterval { get; set; }
                public string DataLoadType { get; set; }
                public string Description { get; set; }
                public string EcsInstanceId { get; set; }
                public bool? ElasticGateway { get; set; }
                public DescribeGatewaysResponseBodyGatewaysGatewayElasticNodes ElasticNodes { get; set; }
                public class DescribeGatewaysResponseBodyGatewaysGatewayElasticNodes : TeaModel {
                    [NameInMap("ElasticNode")]
                    [Validation(Required=false)]
                    public List<string> ElasticNode { get; set; }

                }
                public int? ExpireStatus { get; set; }
                public long? ExpiredTime { get; set; }
                public string GatewayClass { get; set; }
                public string GatewayId { get; set; }
                public string GatewayType { get; set; }
                public string GatewayVersion { get; set; }
                public string InnerIp { get; set; }
                public string InnerIpv6Ip { get; set; }
                public string Ip { get; set; }
                public bool? IsPostPaid { get; set; }
                public bool? IsReleaseAfterExpiration { get; set; }
                public string LastErrorKey { get; set; }
                public string Location { get; set; }
                public int? MaxThroughput { get; set; }
                public string Name { get; set; }
                public int? PublicNetworkBandwidth { get; set; }
                public string RenewURL { get; set; }
                public string Status { get; set; }
                public string StorageBundleId { get; set; }
                public string TaskId { get; set; }
                public string Type { get; set; }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
