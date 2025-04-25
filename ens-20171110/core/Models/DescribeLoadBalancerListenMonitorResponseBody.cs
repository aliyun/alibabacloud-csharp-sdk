// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerListenMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The TCP/UDP monitoring data of the ELB instance.</para>
        /// </summary>
        [NameInMap("LoadBalancerMonitorListenData")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenMonitorResponseBodyLoadBalancerMonitorListenData> LoadBalancerMonitorListenData { get; set; }
        public class DescribeLoadBalancerListenMonitorResponseBodyLoadBalancerMonitorListenData : TeaModel {
            /// <summary>
            /// <para>The number of active connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80285</para>
            /// </summary>
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public string ActConns { get; set; }

            /// <summary>
            /// <para>The business time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-15 16:03:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <para>The number of new connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37150</para>
            /// </summary>
            [NameInMap("Conns")]
            [Validation(Required=false)]
            public string Conns { get; set; }

            /// <summary>
            /// <para>The number of dropped connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DropConns")]
            [Validation(Required=false)]
            public string DropConns { get; set; }

            /// <summary>
            /// <para>The ID of the node to which the ELB instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-dongguan-9</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The number of inactive connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16322</para>
            /// </summary>
            [NameInMap("InActConns")]
            [Validation(Required=false)]
            public string InActConns { get; set; }

            /// <summary>
            /// <para>The inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67532</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <para>The dropped inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>324</para>
            /// </summary>
            [NameInMap("InDropBytes")]
            [Validation(Required=false)]
            public string InDropBytes { get; set; }

            /// <summary>
            /// <para>The number of dropped inbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("InDropPkts")]
            [Validation(Required=false)]
            public string InDropPkts { get; set; }

            /// <summary>
            /// <para>The number of inbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public string InPkts { get; set; }

            /// <summary>
            /// <para>The number of unavailable servers that are attached to the monitored ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InValidRsNum")]
            [Validation(Required=false)]
            public string InValidRsNum { get; set; }

            /// <summary>
            /// <para>The ID of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-5q73cv04zeyh43lh74lp4****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5155487</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            /// <summary>
            /// <para>The dropped outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutDropBytes")]
            [Validation(Required=false)]
            public string OutDropBytes { get; set; }

            /// <summary>
            /// <para>The number of dropped outbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("OutDropPkts")]
            [Validation(Required=false)]
            public string OutDropPkts { get; set; }

            /// <summary>
            /// <para>The number of outbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("OutPkts")]
            [Validation(Required=false)]
            public string OutPkts { get; set; }

            /// <summary>
            /// <para>The network protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The VIP port of the ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("VPort")]
            [Validation(Required=false)]
            public string VPort { get; set; }

            /// <summary>
            /// <para>The number of available servers that are attached to the monitored ELB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ValidRsNum")]
            [Validation(Required=false)]
            public string ValidRsNum { get; set; }

            /// <summary>
            /// <para>The virtual IP address (VIP) of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.8.<em>.</em></para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            /// <summary>
            /// <para>The ID of the tunnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53284</para>
            /// </summary>
            [NameInMap("Vni")]
            [Validation(Required=false)]
            public string Vni { get; set; }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
