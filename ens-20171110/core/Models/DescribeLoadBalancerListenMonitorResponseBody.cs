// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerListenMonitorResponseBody : TeaModel {
        [NameInMap("LoadBalancerMonitorListenData")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenMonitorResponseBodyLoadBalancerMonitorListenData> LoadBalancerMonitorListenData { get; set; }
        public class DescribeLoadBalancerListenMonitorResponseBodyLoadBalancerMonitorListenData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>80285</para>
            /// </summary>
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public string ActConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-15 16:03:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37150</para>
            /// </summary>
            [NameInMap("Conns")]
            [Validation(Required=false)]
            public string Conns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DropConns")]
            [Validation(Required=false)]
            public string DropConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-dongguan-9</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16322</para>
            /// </summary>
            [NameInMap("InActConns")]
            [Validation(Required=false)]
            public string InActConns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>67532</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public string InBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>324</para>
            /// </summary>
            [NameInMap("InDropBytes")]
            [Validation(Required=false)]
            public string InDropBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("InDropPkts")]
            [Validation(Required=false)]
            public string InDropPkts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public string InPkts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InValidRsNum")]
            [Validation(Required=false)]
            public string InValidRsNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-5q73cv04zeyh43lh74lp4****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5155487</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public string OutBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutDropBytes")]
            [Validation(Required=false)]
            public string OutDropBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>76</para>
            /// </summary>
            [NameInMap("OutDropPkts")]
            [Validation(Required=false)]
            public string OutDropPkts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("OutPkts")]
            [Validation(Required=false)]
            public string OutPkts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("VPort")]
            [Validation(Required=false)]
            public string VPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ValidRsNum")]
            [Validation(Required=false)]
            public string ValidRsNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.8.<em>.</em></para>
            /// </summary>
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            /// <summary>
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
