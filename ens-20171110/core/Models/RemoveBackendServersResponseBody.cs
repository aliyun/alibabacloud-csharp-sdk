// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveBackendServersResponseBody : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public RemoveBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class RemoveBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<RemoveBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class RemoveBackendServersResponseBodyBackendServersBackendServer : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
