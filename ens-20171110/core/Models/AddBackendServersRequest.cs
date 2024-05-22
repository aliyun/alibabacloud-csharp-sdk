// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to add. You can add at most 20 backend servers.
        /// 
        /// >  Only ENS instances that are in the running state can be attached to the ELB instance as backend servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<AddBackendServersRequestBackendServers> BackendServers { get; set; }
        public class AddBackendServersRequestBackendServers : TeaModel {
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
            /// The ID of the ENS instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The type of the backend server. Valid values:
            /// 
            /// *   **ens**: ENS instance.
            /// *   **eni**: ENI.
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

        /// <summary>
        /// The frontend port that is used by the Edge Load Balance (ELB) instance. Valid values: **1** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
