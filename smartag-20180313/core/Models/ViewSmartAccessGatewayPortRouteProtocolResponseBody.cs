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

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("RemoteAs")]
            [Validation(Required=false)]
            public string RemoteAs { get; set; }

            [NameInMap("RemoteIp")]
            [Validation(Required=false)]
            public string RemoteIp { get; set; }

            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Vlan")]
            [Validation(Required=false)]
            public string Vlan { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates> TaskStates { get; set; }
        public class ViewSmartAccessGatewayPortRouteProtocolResponseBodyTaskStates : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
