// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeImportedServicesDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the services.
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeImportedServicesDetailResponseBodyDetails> Details { get; set; }
        public class DescribeImportedServicesDetailResponseBodyDetails : TeaModel {
            /// <summary>
            /// The clusters on the data plane.
            /// </summary>
            [NameInMap("ClusterIds")]
            [Validation(Required=false)]
            public List<string> ClusterIds { get; set; }

            /// <summary>
            /// The labels of the service.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// The namespace in which the service resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The ports declared for the service.
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeImportedServicesDetailResponseBodyDetailsPorts> Ports { get; set; }
            public class DescribeImportedServicesDetailResponseBodyDetailsPorts : TeaModel {
                /// <summary>
                /// The name of a port.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The node port.
                /// </summary>
                [NameInMap("NodePort")]
                [Validation(Required=false)]
                public int? NodePort { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol of the port.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The container port.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// The name of a service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The type of the service.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
