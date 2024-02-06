// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerSpecResponseBody : TeaModel {
        /// <summary>
        /// The specifications. Valid values:
        /// </summary>
        [NameInMap("LoadBalancerSpecs")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs> LoadBalancerSpecs { get; set; }
        public class DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs : TeaModel {
            /// <summary>
            /// The display name of the instance type.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The specifications of the ELB instance.
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
