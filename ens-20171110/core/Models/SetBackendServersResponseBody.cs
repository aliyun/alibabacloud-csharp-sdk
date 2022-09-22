// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersResponseBody : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public SetBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class SetBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<SetBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class SetBackendServersResponseBodyBackendServersBackendServer : TeaModel {
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
