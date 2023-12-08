// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ranking result of hybrid cloud traffic data.
        /// </summary>
        [NameInMap("VirtualBorderRouterFlowlogTopN")]
        [Validation(Required=false)]
        public List<GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN> VirtualBorderRouterFlowlogTopN { get; set; }
        public class GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN : TeaModel {
            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The CEN connection ID.
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// The total volume of traffic in the specified time range.
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// The local IP address.
            /// </summary>
            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            /// <summary>
            /// The local port.
            /// </summary>
            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            /// <summary>
            /// The local region where the local IP address resides.
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// The remote IP address.
            /// </summary>
            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            /// <summary>
            /// The remote port.
            /// </summary>
            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            /// <summary>
            /// The total number of packets in the specified time range.
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            /// <summary>
            /// The protocol number.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The ID of the VBR that is associated with the Express Connect circuit.
            /// </summary>
            [NameInMap("VirtualBorderRouterId")]
            [Validation(Required=false)]
            public string VirtualBorderRouterId { get; set; }

        }

    }

}
