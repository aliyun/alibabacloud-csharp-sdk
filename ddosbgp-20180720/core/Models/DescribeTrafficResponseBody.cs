// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried traffic statistics.</para>
        /// </summary>
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeTrafficResponseBodyFlowList> FlowList { get; set; }
        public class DescribeTrafficResponseBodyFlowList : TeaModel {
            /// <summary>
            /// <para>The bandwidth of attack traffic. Unit: bit/s.</para>
            /// <remarks>
            /// <para> This parameter is returned only if attack traffic exists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of attack traffic. Unit: packets per second.</para>
            /// <remarks>
            /// <para> This parameter is returned only if attack traffic exists.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// <para>The type of the traffic statistics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>max</b>: the peak traffic within the specified interval</description></item>
            /// <item><description><b>avg</b>: the average traffic within the specified interval</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>max</para>
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// <para>The bandwidth of the total traffic. Unit: Kbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>417</para>
            /// </summary>
            [NameInMap("Kbps")]
            [Validation(Required=false)]
            public int? Kbps { get; set; }

            /// <summary>
            /// <para>The ID of the traffic statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8e33f19e-5644-11eb-b5c1-d89d67182200</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of the total traffic. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>274</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// <para>The time when the traffic statistics are calculated. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620951900</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A507DC8-F657-4C13-84E2-D1D1B9400753</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
