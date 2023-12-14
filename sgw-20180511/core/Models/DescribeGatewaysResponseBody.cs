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
                [NameInMap("ActivatedTime")]
                [Validation(Required=false)]
                public long? ActivatedTime { get; set; }

                [NameInMap("BuyURL")]
                [Validation(Required=false)]
                public string BuyURL { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CommonBuyInstanceId")]
                [Validation(Required=false)]
                public string CommonBuyInstanceId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("DataLoadInterval")]
                [Validation(Required=false)]
                public int? DataLoadInterval { get; set; }

                [NameInMap("DataLoadType")]
                [Validation(Required=false)]
                public string DataLoadType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                [NameInMap("ElasticGateway")]
                [Validation(Required=false)]
                public bool? ElasticGateway { get; set; }

                [NameInMap("ElasticNodes")]
                [Validation(Required=false)]
                public DescribeGatewaysResponseBodyGatewaysGatewayElasticNodes ElasticNodes { get; set; }
                public class DescribeGatewaysResponseBodyGatewaysGatewayElasticNodes : TeaModel {
                    [NameInMap("ElasticNode")]
                    [Validation(Required=false)]
                    public List<string> ElasticNode { get; set; }

                }

                [NameInMap("ExpireStatus")]
                [Validation(Required=false)]
                public int? ExpireStatus { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("GatewayClass")]
                [Validation(Required=false)]
                public string GatewayClass { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("GatewayRegionId")]
                [Validation(Required=false)]
                public string GatewayRegionId { get; set; }

                [NameInMap("GatewayType")]
                [Validation(Required=false)]
                public string GatewayType { get; set; }

                [NameInMap("GatewayVersion")]
                [Validation(Required=false)]
                public string GatewayVersion { get; set; }

                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                [NameInMap("InnerIpv6Ip")]
                [Validation(Required=false)]
                public string InnerIpv6Ip { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("IsPostPaid")]
                [Validation(Required=false)]
                public bool? IsPostPaid { get; set; }

                [NameInMap("IsReleaseAfterExpiration")]
                [Validation(Required=false)]
                public bool? IsReleaseAfterExpiration { get; set; }

                [NameInMap("LastErrorKey")]
                [Validation(Required=false)]
                public string LastErrorKey { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("MaxThroughput")]
                [Validation(Required=false)]
                public int? MaxThroughput { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PublicNetworkBandwidth")]
                [Validation(Required=false)]
                public int? PublicNetworkBandwidth { get; set; }

                [NameInMap("RenewURL")]
                [Validation(Required=false)]
                public string RenewURL { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageBundleId")]
                [Validation(Required=false)]
                public string StorageBundleId { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
