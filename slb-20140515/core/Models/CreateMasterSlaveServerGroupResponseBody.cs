// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateMasterSlaveServerGroupResponseBody : TeaModel {
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServers MasterSlaveBackendServers { get; set; }
        public class CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServers : TeaModel {
            [NameInMap("MasterSlaveBackendServer")]
            [Validation(Required=false)]
            public List<CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer> MasterSlaveBackendServer { get; set; }
            public class CreateMasterSlaveServerGroupResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer : TeaModel {
                public string Type { get; set; }
                public int? Weight { get; set; }
                public string Description { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
                public string ServerType { get; set; }
            }
        };

    }

}
