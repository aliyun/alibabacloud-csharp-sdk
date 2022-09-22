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
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                [NameInMap("LoadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                [NameInMap("LoadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

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
