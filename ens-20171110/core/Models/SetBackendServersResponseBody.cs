// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersResponseBody : TeaModel {
        /// <summary>
        /// The backend servers.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public SetBackendServersResponseBodyBackendServers BackendServers { get; set; }
        public class SetBackendServersResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<SetBackendServersResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class SetBackendServersResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// The IP address of the backend server.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The backend port that is used by the ELB instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the instance that you want to use as the backend server.
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// The type of the backend server. Valid values:
                /// 
                /// *   **ens**: ENS instance.
                /// *   **eni**: ENI instance.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the backend server. Default value: 100. Valid values: **0** to **100**.
                /// 
                /// >  The value 0 indicates that requests are not forwarded to the backend server.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
