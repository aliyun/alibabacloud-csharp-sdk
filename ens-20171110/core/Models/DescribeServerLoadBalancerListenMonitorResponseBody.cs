// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServerLoadBalancerListenMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request。</para>
        /// 
        /// <b>Example:</b>
        /// <para>125B04C7-3D0D-4245-AF96-14E3758E3F06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of objects.</para>
        /// </summary>
        [NameInMap("ServerLoadBalancerMonitorData")]
        [Validation(Required=false)]
        public List<DescribeServerLoadBalancerListenMonitorResponseBodyServerLoadBalancerMonitorData> ServerLoadBalancerMonitorData { get; set; }
        public class DescribeServerLoadBalancerListenMonitorResponseBodyServerLoadBalancerMonitorData : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public int? Acc { get; set; }

            /// <summary>
            /// <para>The log business time. The log collection granularity is 1 minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-16 15:00:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <para>The ID of the edge node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-fuzhou-7</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The load balancing instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-5rcvo1n1t3hykfhhjwjgqp****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The load balancing instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esk-edge-service-lb-8377****</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The load balancing instance specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elb.s2.medium</para>
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

            /// <summary>
            /// <para>The request protocol, such as http, https, and tcp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The number of 2xx status code responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Reqs2xx")]
            [Validation(Required=false)]
            public int? Reqs2xx { get; set; }

            /// <summary>
            /// <para>The number of 3xx status code responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs3xx")]
            [Validation(Required=false)]
            public int? Reqs3xx { get; set; }

            /// <summary>
            /// <para>The number of 4xx status code responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs4xx")]
            [Validation(Required=false)]
            public int? Reqs4xx { get; set; }

            /// <summary>
            /// <para>The number of 5xx status code responses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Reqs5xx")]
            [Validation(Required=false)]
            public int? Reqs5xx { get; set; }

            /// <summary>
            /// <para>The average request latency in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1037</para>
            /// </summary>
            [NameInMap("RtAvg")]
            [Validation(Required=false)]
            public int? RtAvg { get; set; }

            /// <summary>
            /// <para>The VIP of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0****</para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            /// <summary>
            /// <para>The tunnel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52497</para>
            /// </summary>
            [NameInMap("Vni")]
            [Validation(Required=false)]
            public int? Vni { get; set; }

            /// <summary>
            /// <para>The VIP port, such as 80, 8080, and 443.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Vport")]
            [Validation(Required=false)]
            public int? Vport { get; set; }

        }

    }

}
