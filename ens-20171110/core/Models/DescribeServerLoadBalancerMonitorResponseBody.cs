// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServerLoadBalancerMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the monitoring data.</para>
        /// </summary>
        [NameInMap("ServerLoadBalancerMonitorData")]
        [Validation(Required=false)]
        public List<DescribeServerLoadBalancerMonitorResponseBodyServerLoadBalancerMonitorData> ServerLoadBalancerMonitorData { get; set; }
        public class DescribeServerLoadBalancerMonitorResponseBodyServerLoadBalancerMonitorData : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public int? Acc { get; set; }

            /// <summary>
            /// <para>The business time of the log. Logs are collected every minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-15 16:00:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <para>The ID of the node to which the ELB instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wuxi-10</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-5sc1s9zrui8lpb8u7cl4f****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esk-edge-service-lb-a34****</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The specification of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elb.s2.medium</para>
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

            /// <summary>
            /// <para>The number of requests with HTTP 2xx status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Reqs2xx")]
            [Validation(Required=false)]
            public int? Reqs2xx { get; set; }

            /// <summary>
            /// <para>The number of requests with HTTP 3xx status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs3xx")]
            [Validation(Required=false)]
            public int? Reqs3xx { get; set; }

            /// <summary>
            /// <para>The number of requests with HTTP 4xx status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Reqs4xx")]
            [Validation(Required=false)]
            public int? Reqs4xx { get; set; }

            /// <summary>
            /// <para>The number of requests with HTTP 5xx status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs5xx")]
            [Validation(Required=false)]
            public int? Reqs5xx { get; set; }

            /// <summary>
            /// <para>The average response time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1404</para>
            /// </summary>
            [NameInMap("RtAvg")]
            [Validation(Required=false)]
            public int? RtAvg { get; set; }

            /// <summary>
            /// <para>The virtual IP address (VIP) of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0****</para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            /// <summary>
            /// <para>The ID of the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3018</para>
            /// </summary>
            [NameInMap("Vni")]
            [Validation(Required=false)]
            public int? Vni { get; set; }

        }

    }

}
