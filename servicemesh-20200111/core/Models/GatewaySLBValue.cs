// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GatewaySLBValue : TeaModel {
        [NameInMap("SLBAddress")]
        [Validation(Required=false)]
        public string SLBAddress { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public GatewaySLBValueBackendServers BackendServers { get; set; }
        public class GatewaySLBValueBackendServers : TeaModel {
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }
            [NameInMap("ServerHealthStatus")]
            [Validation(Required=false)]
            public string ServerHealthStatus { get; set; }
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public long? ListenerPort { get; set; }
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EniHost")]
            [Validation(Required=false)]
            public string EniHost { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("SLBHealthCheckState")]
        [Validation(Required=false)]
        public string SLBHealthCheckState { get; set; }

    }

}
