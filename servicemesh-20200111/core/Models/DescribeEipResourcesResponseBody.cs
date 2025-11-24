// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeEipResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The EIPs.</para>
        /// </summary>
        [NameInMap("EipList")]
        [Validation(Required=false)]
        public List<DescribeEipResourcesResponseBodyEipList> EipList { get; set; }
        public class DescribeEipResourcesResponseBodyEipList : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-2zeerraiwb7ujxscd****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of the resource that is associated with the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>EcsInstance</c>: an ECS instance in a VPC</description></item>
            /// <item><description><c>SlbInstance</c>: a Server Load Balancer (SLB) instance in a VPC</description></item>
            /// <item><description><c>Nat</c>: a NAT gateway</description></item>
            /// <item><description><c>HaVip</c>: a high-availability virtual IP address (HAVIP)</description></item>
            /// <item><description><c>NetworkInterface</c>: a secondary elastic network interface (ENI)</description></item>
            /// </list>
            /// <para>Default value: <c>EcsInstance</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SlbInstance</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The IP address of the EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.xx.xx.112</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The status of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Associating</c>: The EIP is being associated with a resource.</description></item>
            /// <item><description><c>Unassociating</c>: The EIP is being disassociated from a resource.</description></item>
            /// <item><description><c>InUse</c>: The EIP is associated with a resource.</description></item>
            /// <item><description><c>Available</c>: The EIP is available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InUse</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public DescribeEipResourcesResponseBodyPageResult PageResult { get; set; }
        public class DescribeEipResourcesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
