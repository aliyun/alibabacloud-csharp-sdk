// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of ELB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public DescribeLoadBalancersResponseBodyLoadBalancers LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer> LoadBalancer { get; set; }
            public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer : TeaModel {
                /// <summary>
                /// <para>The IP address that the ELB instance uses to provide services.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.XX.XX</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The IP version. Valid values: ipv4 and ipv6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                /// <summary>
                /// <para>The time when the ELB instance was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-06T11:13:41Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the ENS node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wuhan-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the ELB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-5snthcyu1x10g7tywj7iu****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The name of the ELB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("LoadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// <para>The status of the listener for the ELB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b>: The listener for the instance can forward the received traffic based on forwarding rules.</description></item>
                /// <item><description><b>InActive</b>: The listener for the instance does not forward the received traffic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InActive</para>
                /// </summary>
                [NameInMap("LoadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                /// <summary>
                /// <para>The ID of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n-5rz0rj1caexauilpsjx0w****</para>
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid</b>: subscription.</description></item>
                /// <item><description><b>PostPaid</b>: pay-as-you-go. Only this billing method is supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-5rllcjb3ol6duzjdnbm1om****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: <b>10</b> to <b>100</b>.</para>
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
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
