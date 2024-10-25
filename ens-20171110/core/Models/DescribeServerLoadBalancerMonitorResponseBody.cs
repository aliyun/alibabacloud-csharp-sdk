// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeServerLoadBalancerMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request。</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerLoadBalancerMonitorData")]
        [Validation(Required=false)]
        public List<DescribeServerLoadBalancerMonitorResponseBodyServerLoadBalancerMonitorData> ServerLoadBalancerMonitorData { get; set; }
        public class DescribeServerLoadBalancerMonitorResponseBodyServerLoadBalancerMonitorData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public int? Acc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-15 16:00:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-wuxi-10</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-5sc1s9zrui8lpb8u7cl4f****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esk-edge-service-lb-a34****</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>elb.s2.medium</para>
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public string LoadBalancerSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Reqs2xx")]
            [Validation(Required=false)]
            public int? Reqs2xx { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs3xx")]
            [Validation(Required=false)]
            public int? Reqs3xx { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Reqs4xx")]
            [Validation(Required=false)]
            public int? Reqs4xx { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Reqs5xx")]
            [Validation(Required=false)]
            public int? Reqs5xx { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1404</para>
            /// </summary>
            [NameInMap("RtAvg")]
            [Validation(Required=false)]
            public int? RtAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0****</para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3018</para>
            /// </summary>
            [NameInMap("Vni")]
            [Validation(Required=false)]
            public int? Vni { get; set; }

        }

    }

}
