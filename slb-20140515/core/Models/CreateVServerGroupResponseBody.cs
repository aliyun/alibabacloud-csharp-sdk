// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateVServerGroupResponseBody : TeaModel {
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public CreateVServerGroupResponseBodyBackendServers BackendServers { get; set; }
        public class CreateVServerGroupResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<CreateVServerGroupResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class CreateVServerGroupResponseBodyBackendServersBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
            }
        };

    }

}
