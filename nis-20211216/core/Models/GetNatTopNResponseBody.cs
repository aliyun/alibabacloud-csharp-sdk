// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNatTopNResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether Network Intelligence Service (NIS) is activated. The NatGatewayTopN parameter returns an empty array when NIS is not activated.
        /// 
        /// *   **true**: activated
        /// *   **false**: not activated
        /// </summary>
        [NameInMap("IsTopNOpen")]
        [Validation(Required=false)]
        public bool? IsTopNOpen { get; set; }

        /// <summary>
        /// An array of statistics about real-time SNAT performance ranking.
        /// </summary>
        [NameInMap("NatGatewayTopN")]
        [Validation(Required=false)]
        public List<GetNatTopNResponseBodyNatGatewayTopN> NatGatewayTopN { get; set; }
        public class GetNatTopNResponseBodyNatGatewayTopN : TeaModel {
            /// <summary>
            /// The number of concurrent connections. Unit: connections.
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public float? ActiveSessionCount { get; set; }

            /// <summary>
            /// The inbound data transfer. Unit: bit/s.
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public float? InBps { get; set; }

            /// <summary>
            /// This field is reserved and not in use.
            /// </summary>
            [NameInMap("InFlowPerMinute")]
            [Validation(Required=false)]
            public float? InFlowPerMinute { get; set; }

            /// <summary>
            /// The inbound packet forwarding rate. Unit: packets per second.
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public float? InPps { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The new connection creation rate. Unit: connections per second.
            /// </summary>
            [NameInMap("NewSessionPerSecond")]
            [Validation(Required=false)]
            public float? NewSessionPerSecond { get; set; }

            /// <summary>
            /// The outbound data transfer. Unit: bit/s.
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public float? OutBps { get; set; }

            /// <summary>
            /// This field is reserved and not in use.
            /// </summary>
            [NameInMap("OutFlowPerMinute")]
            [Validation(Required=false)]
            public float? OutFlowPerMinute { get; set; }

            /// <summary>
            /// The outbound packet forwarding rate. Unit: packets per second.
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public float? OutPps { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
