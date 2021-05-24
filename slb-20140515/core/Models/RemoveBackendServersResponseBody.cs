// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveBackendServersResponseBody : TeaModel {
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public RemoveBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class RemoveBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<RemoveBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class RemoveBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public string ServerId { get; set; }
            }
        };

    }

}
