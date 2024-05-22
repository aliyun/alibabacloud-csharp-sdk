// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to add. You can modify at most 20 backend servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<SetBackendServersRequestBackendServers> BackendServers { get; set; }
        public class SetBackendServersRequestBackendServers : TeaModel {
            /// <summary>
            /// The ID of the instance that you want to use as the backend server.
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
            /// *   **eni**: Elastic Network Interface (ENI) instance.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The weight of the backend server. Default value: 100. Valid values: **0** to **100**.
            /// 
            /// >  The value 0 indicates that requests are not forwarded to the backend server.
            /// 
            /// This parameter is required.
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
