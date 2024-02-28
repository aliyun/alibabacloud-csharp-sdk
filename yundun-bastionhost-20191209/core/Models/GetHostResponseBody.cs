// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostResponseBody : TeaModel {
        /// <summary>
        /// The information about the host that was queried.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public GetHostResponseBodyHost Host { get; set; }
        public class GetHostResponseBodyHost : TeaModel {
            /// <summary>
            /// The address type of the host. Valid values:
            /// 
            /// *   **Public**: a public address
            /// *   **Private**: a private address
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// The description of the host.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The hostname.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The internal endpoint of the host. The value is a domain name or an IP address.
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// The public address of the host. The value is a domain name or an IP address.
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

            /// <summary>
            /// The ID of the new network domain to which the host belongs.
            /// </summary>
            [NameInMap("NetworkDomainId")]
            [Validation(Required=false)]
            public string NetworkDomainId { get; set; }

            /// <summary>
            /// The operating system of the host. Valid values:
            /// 
            /// *   **Linux**
            /// *   **Windows**
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// The protocol information about the host.
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<GetHostResponseBodyHostProtocols> Protocols { get; set; }
            public class GetHostResponseBodyHostProtocols : TeaModel {
                /// <summary>
                /// The fingerprint of the host. This parameter uniquely identifies a host.
                /// </summary>
                [NameInMap("HostFingerPrint")]
                [Validation(Required=false)]
                public string HostFingerPrint { get; set; }

                /// <summary>
                /// The service port of the host.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol that is used to connect to the host. Valid values:
                /// 
                /// *   **SSH**
                /// *   **RDP**
                /// </summary>
                [NameInMap("ProtocolName")]
                [Validation(Required=false)]
                public string ProtocolName { get; set; }

            }

            /// <summary>
            /// The source of the host. Valid values:
            /// 
            /// *   **Local**: a host in a data center
            /// *   **Ecs**: an Elastic Compute Service (ECS) instance
            /// *   **Rds**: a host in an ApsaraDB MyBase dedicated cluster
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster.
            /// 
            /// >  If **Local** is returned for the **Source** parameter, no value is returned for this parameter.
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// The status of the host. Valid values:
            /// 
            /// *   **Normal**: normal
            /// *   **Release**: released
            /// </summary>
            [NameInMap("SourceInstanceState")]
            [Validation(Required=false)]
            public string SourceInstanceState { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
