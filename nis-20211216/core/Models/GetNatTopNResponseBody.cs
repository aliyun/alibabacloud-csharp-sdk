// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNatTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether Network Intelligence Service (NIS) is activated. The NatGatewayTopN parameter returns an empty array when NIS is not activated.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: activated</description></item>
        /// <item><description><b>false</b>: not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTopNOpen")]
        [Validation(Required=false)]
        public bool? IsTopNOpen { get; set; }

        /// <summary>
        /// <para>An array of statistics about real-time SNAT performance ranking.</para>
        /// </summary>
        [NameInMap("NatGatewayTopN")]
        [Validation(Required=false)]
        public List<GetNatTopNResponseBodyNatGatewayTopN> NatGatewayTopN { get; set; }
        public class GetNatTopNResponseBodyNatGatewayTopN : TeaModel {
            /// <summary>
            /// <para>The number of concurrent connections. Unit: connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public float? ActiveSessionCount { get; set; }

            /// <summary>
            /// <para>The inbound data transfer. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public float? InBps { get; set; }

            /// <summary>
            /// <para>This field is reserved and not in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InFlowPerMinute")]
            [Validation(Required=false)]
            public float? InFlowPerMinute { get; set; }

            /// <summary>
            /// <para>The inbound packet forwarding rate. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public float? InPps { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.156.101</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The new connection creation rate. Unit: connections per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NewSessionPerSecond")]
            [Validation(Required=false)]
            public float? NewSessionPerSecond { get; set; }

            /// <summary>
            /// <para>The outbound data transfer. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public float? OutBps { get; set; }

            /// <summary>
            /// <para>This field is reserved and not in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OutFlowPerMinute")]
            [Validation(Required=false)]
            public float? OutFlowPerMinute { get; set; }

            /// <summary>
            /// <para>The outbound packet forwarding rate. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public float? OutPps { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77C512B5-12f3-f892-BD94-88A98271C1A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
