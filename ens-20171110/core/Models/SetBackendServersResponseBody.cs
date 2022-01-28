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
                public string Ip { get; set; }
                public int? Port { get; set; }
                public string ServerId { get; set; }
                public string Type { get; set; }
                public int? Weight { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
