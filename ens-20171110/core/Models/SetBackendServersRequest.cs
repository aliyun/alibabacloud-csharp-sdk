// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to add. You can add at most 20 backend servers.
        /// 
        /// >  Only ENS instances that are in the running state can be attached to the ELB instance as backend servers.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<SetBackendServersRequestBackendServers> BackendServers { get; set; }
        public class SetBackendServersRequestBackendServers : TeaModel {
            /// <summary>
            /// The ID of the instance that is used as the backend server.
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
        /// The ID of the Edge Load Balancer (ELB) instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
