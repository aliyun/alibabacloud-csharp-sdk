// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public DescribeLoadBalancersResponseBodyLoadBalancers LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer> LoadBalancer { get; set; }
            public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer : TeaModel {
                public string VpcId { get; set; }
                public long? CreateTimeStamp { get; set; }
                public string LoadBalancerId { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public string AddressType { get; set; }
                public string NetworkType { get; set; }
                public string AddressIPVersion { get; set; }
                public string LoadBalancerName { get; set; }
                public int? Bandwidth { get; set; }
                public string Address { get; set; }
                public string SlaveZoneId { get; set; }
                public string MasterZoneId { get; set; }
                public string InternetChargeTypeAlias { get; set; }
                public string LoadBalancerSpec { get; set; }
                public string RegionId { get; set; }
                public string ModificationProtectionReason { get; set; }
                public string ModificationProtectionStatus { get; set; }
                public string VSwitchId { get; set; }
                public string LoadBalancerStatus { get; set; }
                public string ResourceGroupId { get; set; }
                public string InternetChargeType { get; set; }
                public string DeleteProtection { get; set; }
                public string RegionIdAlias { get; set; }
            }
        };

    }

}
