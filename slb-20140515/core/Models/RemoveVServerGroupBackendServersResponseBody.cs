// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveVServerGroupBackendServersResponseBody : TeaModel {
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public RemoveVServerGroupBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class RemoveVServerGroupBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<RemoveVServerGroupBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class RemoveVServerGroupBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
            }
        };

    }

}
