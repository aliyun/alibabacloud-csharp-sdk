// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallTimeTopResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public long? DataCount { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallTimeTopResponseBodyDataList> DataList { get; set; }
        public class DescribeNatFirewallTimeTopResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.66.231.XXX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vfw-tr-7a9c8901ed394****</para>
            /// </summary>
            [NameInMap("NatFirewallId")]
            [Validation(Required=false)]
            public string NatFirewallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vfw-test</para>
            /// </summary>
            [NameInMap("NatFirewallName")]
            [Validation(Required=false)]
            public string NatFirewallName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-uf6pnry5vpawb****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ngw-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("NewConn")]
            [Validation(Required=false)]
            public string NewConn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-bp130nn8h6157dir****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public string SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5DDD596-1191-5F36-A504-8733045A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1656923760</para>
        /// </summary>
        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public string TrafficTime { get; set; }

    }

}
