// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayPortRouteProtocolResponseBody : TeaModel {
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayPortRouteProtocolResponseBodyPorts> Ports { get; set; }
        public class ViewSmartAccessGatewayPortRouteProtocolResponseBodyPorts : TeaModel {
            [NameInMap("NeighborIp")]
            [Validation(Required=false)]
            public string NeighborIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65535</para>
            /// </summary>
            [NameInMap("RemoteAs")]
            [Validation(Required=false)]
            public string RemoteAs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.XX.XX.1</para>
            /// </summary>
            [NameInMap("RemoteIp")]
            [Validation(Required=false)]
            public string RemoteIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UP</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Vlan")]
            [Validation(Required=false)]
            public string Vlan { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>877F5673-FFD1-5168-99D1-1E8009FBFF7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates> TaskStates { get; set; }
        public class ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1586765938000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
