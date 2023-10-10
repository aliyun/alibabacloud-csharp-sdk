// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateK8sServiceRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The policy used for external traffic management. Valid values:
        /// 
        /// *   Local: The network traffic can be routed to pods on the node where the Service is deployed.
        /// *   Cluster: The network traffic can be routed to pods on other nodes in the cluster.
        /// 
        /// Default value: Local.
        /// </summary>
        [NameInMap("ExternalTrafficPolicy")]
        [Validation(Required=false)]
        public string ExternalTrafficPolicy { get; set; }

        /// <summary>
        /// The name of the Kubernetes Service.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The port mapping of the Kubernetes Service. Set this parameter to a JSON array. The following parameters are included in the configurations:
        /// 
        /// *   **protocol**: the protocol used by the Service. Valid values: TCP and UDP. This parameter is mandatory.
        /// *   **port**: the frontend service port. Valid values: 1 to 65535. This parameter is mandatory.
        /// *   **targetPort**: the backend container port. Valid values: 1 to 65535. This parameter is mandatory.
        /// 
        /// Example: `[{"protocol": "TCP", "port": 80, "targetPort": 8080},{"protocol": "TCP", "port": 81, "targetPort": 8081}]`
        /// </summary>
        [NameInMap("ServicePorts")]
        [Validation(Required=false)]
        public Dictionary<string, object> ServicePorts { get; set; }

        /// <summary>
        /// The type of the Kubernetes Service. Set the value to ClusterIP.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
