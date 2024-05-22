// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to remove. You can remove up to 20 backend servers at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<RemoveBackendServersRequestBackendServers> BackendServers { get; set; }
        public class RemoveBackendServersRequestBackendServers : TeaModel {
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
            /// The instance ID of the backend server.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The type of the backend server. Valid values:
            /// 
            /// *   **ens**: an Edge Node Service (ENS) instance.
            /// *   **eni**: an elastic network interface (ENI).
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The weight of the backend server.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The ID of the Edge Load Balancer (ELB) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
