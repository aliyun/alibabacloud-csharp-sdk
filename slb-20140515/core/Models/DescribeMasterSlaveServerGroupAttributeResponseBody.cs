// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers MasterSlaveBackendServers { get; set; }
        public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers : TeaModel {
            [NameInMap("MasterSlaveBackendServer")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer> MasterSlaveBackendServer { get; set; }
            public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer : TeaModel {
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
