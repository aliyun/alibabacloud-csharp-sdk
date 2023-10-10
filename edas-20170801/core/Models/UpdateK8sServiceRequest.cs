// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sServiceRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The policy used for external traffic management. Valid values:
        /// 
        /// *   Local: local mode
        /// *   Cluster: cluster mode
        /// 
        /// Default value: Local.
        /// </summary>
        [NameInMap("ExternalTrafficPolicy")]
        [Validation(Required=false)]
        public string ExternalTrafficPolicy { get; set; }

        /// <summary>
        /// The name of the service in a Kubernetes cluster.
        /// 
        /// *   The name can contain lowercase letters, digits, and hyphens (-).
        /// *   It must start with a letter and end with a letter or digit.
        /// *   The name can be 2 to 32 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The mappings between service ports. Set this parameter to a JSON array. The following parameters are included in the configurations:
        /// 
        /// *   **protocol**: the protocol used by the service. Valid values: TCP and UDP. This parameter is required.
        /// *   **port**: the frontend service port. Valid values: 1 to 65535. This parameter is required.
        /// *   **targetPort**: the backend container port. Valid values: 1 to 65535. This parameter is required.
        /// 
        /// Example: `[{"protocol": "TCP", "port": 80, "targetPort": 8080},{"protocol": "TCP", "port": 81, "targetPort": 8081}]`
        /// </summary>
        [NameInMap("ServicePorts")]
        [Validation(Required=false)]
        public Dictionary<string, object> ServicePorts { get; set; }

        /// <summary>
        /// The type of the service in a Kubernetes cluster. Set the value to ClusterIP.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
