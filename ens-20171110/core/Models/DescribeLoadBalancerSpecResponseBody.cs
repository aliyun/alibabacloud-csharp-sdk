// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerSpecResponseBody : TeaModel {
        [NameInMap("LoadBalancerSpecs")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs> LoadBalancerSpecs { get; set; }
        public class DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
