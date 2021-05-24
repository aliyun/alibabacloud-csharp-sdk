// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetVServerGroupAttributeResponseBody : TeaModel {
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public SetVServerGroupAttributeResponseBodyBackendServers BackendServers { get; set; }
        public class SetVServerGroupAttributeResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<SetVServerGroupAttributeResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class SetVServerGroupAttributeResponseBodyBackendServersBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
            }
        };

    }

}
