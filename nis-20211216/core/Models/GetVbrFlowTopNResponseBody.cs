// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ranking result of hybrid cloud traffic data.</para>
        /// </summary>
        [NameInMap("VirtualBorderRouterFlowlogTopN")]
        [Validation(Required=false)]
        public List<GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN> VirtualBorderRouterFlowlogTopN { get; set; }
        public class GetVbrFlowTopNResponseBodyVirtualBorderRouterFlowlogTopN : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156237031628****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The CEN connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-u6v1j3jre0fe9h****</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The total volume of traffic in the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>108</para>
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// <para>The local IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.24.X.X</para>
            /// </summary>
            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            /// <summary>
            /// <para>The local port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            /// <summary>
            /// <para>The local region where the local IP address resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// <para>The remote IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222.85.X.X</para>
            /// </summary>
            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            /// <summary>
            /// <para>The remote port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10965</para>
            /// </summary>
            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            /// <summary>
            /// <para>The total number of packets in the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            /// <summary>
            /// <para>The protocol number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the VBR that is associated with the Express Connect circuit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-k1atj46citwuek42j****</para>
            /// </summary>
            [NameInMap("VirtualBorderRouterId")]
            [Validation(Required=false)]
            public string VirtualBorderRouterId { get; set; }

        }

    }

}
