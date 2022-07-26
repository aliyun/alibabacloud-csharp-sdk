// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveBackendServersRequest : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<RemoveBackendServersRequestBackendServers> BackendServers { get; set; }
        public class RemoveBackendServersRequestBackendServers : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
