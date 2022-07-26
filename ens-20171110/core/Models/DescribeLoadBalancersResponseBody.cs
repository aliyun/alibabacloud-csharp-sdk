// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public DescribeLoadBalancersResponseBodyLoadBalancers LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer> LoadBalancer { get; set; }
            public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer : TeaModel {
                public string Address { get; set; }
                public string AddressIPVersion { get; set; }
                public string CreateTime { get; set; }
                public string EnsRegionId { get; set; }
                public string LoadBalancerId { get; set; }
                public string LoadBalancerName { get; set; }
                public string LoadBalancerStatus { get; set; }
                public string NetworkId { get; set; }
                public string PayType { get; set; }
                public string VSwitchId { get; set; }
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
