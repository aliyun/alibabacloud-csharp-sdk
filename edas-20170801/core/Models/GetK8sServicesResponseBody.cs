// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sServicesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the change process.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of services in the Kubernetes cluster.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetK8sServicesResponseBodyServices> Services { get; set; }
        public class GetK8sServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// The IP address of the service in the Kubernetes cluster.
            /// </summary>
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The mapping of service ports.
            /// </summary>
            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<GetK8sServicesResponseBodyServicesServicePorts> ServicePorts { get; set; }
            public class GetK8sServicesResponseBodyServicesServicePorts : TeaModel {
                /// <summary>
                /// The port of the node.
                /// </summary>
                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public int? NodePort { get; set; }

                /// <summary>
                /// The frontend service port.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol of the service.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The backend container port.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public string TargetPort { get; set; }

            }

            /// <summary>
            /// The type of the service.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
