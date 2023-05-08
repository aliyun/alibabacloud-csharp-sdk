// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeEipResourcesResponseBody : TeaModel {
        /// <summary>
        /// The EIPs.
        /// </summary>
        [NameInMap("EipList")]
        [Validation(Required=false)]
        public List<DescribeEipResourcesResponseBodyEipList> EipList { get; set; }
        public class DescribeEipResourcesResponseBodyEipList : TeaModel {
            /// <summary>
            /// The ID of the EIP.
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// The type of the resource that is associated with the EIP. Valid values:
            /// 
            /// *   `EcsInstance`: an ECS instance in a VPC
            /// *   `SlbInstance`: a Server Load Balancer (SLB) instance in a VPC
            /// *   `Nat`: a NAT gateway
            /// *   `HaVip`: a high-availability virtual IP address (HAVIP)
            /// *   `NetworkInterface`: a secondary elastic network interface (ENI)
            /// 
            /// Default value: `EcsInstance`.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The IP address of the EIP.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The status of the EIP. Valid values:
            /// 
            /// *   `Associating`: The EIP is being associated with a resource.
            /// *   `Unassociating`: The EIP is being disassociated from a resource.
            /// *   `InUse`: The EIP is associated with a resource.
            /// *   `Available`: The EIP is available.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public DescribeEipResourcesResponseBodyPageResult PageResult { get; set; }
        public class DescribeEipResourcesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
