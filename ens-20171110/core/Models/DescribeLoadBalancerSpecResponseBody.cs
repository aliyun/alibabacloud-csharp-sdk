// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The specifications. Valid values:</para>
        /// </summary>
        [NameInMap("LoadBalancerSpecs")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs> LoadBalancerSpecs { get; set; }
        public class DescribeLoadBalancerSpecResponseBodyLoadBalancerSpecs : TeaModel {
            /// <summary>
            /// <para>The display name of the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elb.s1.small</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The specifications of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elb.s1.small</para>
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
