// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddVServerGroupBackendServersResponseBody : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public AddVServerGroupBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class AddVServerGroupBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<AddVServerGroupBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class AddVServerGroupBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                public string Description { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
                public string Type { get; set; }
                public int? Weight { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
