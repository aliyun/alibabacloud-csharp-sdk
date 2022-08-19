// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ReplaceServersInServerGroupRequest : TeaModel {
        [NameInMap("AddedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestAddedServers> AddedServers { get; set; }
        public class ReplaceServersInServerGroupRequestAddedServers : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RemovedServers")]
        [Validation(Required=false)]
        public List<ReplaceServersInServerGroupRequestRemovedServers> RemovedServers { get; set; }
        public class ReplaceServersInServerGroupRequestRemovedServers : TeaModel {
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

        }

        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
