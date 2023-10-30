// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostResponseBody : TeaModel {
        /// <summary>
        /// The fingerprint of the host. This parameter uniquely identifies a host.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public GetHostResponseBodyHost Host { get; set; }
        public class GetHostResponseBodyHost : TeaModel {
            /// <summary>
            /// The public endpoint of the host. You can set this parameter to a domain name or an IP address.
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// The ID of the ECS instance or dedicated cluster host that was queried.
            /// 
            /// >  No value is returned for this parameter if the **Source** parameter is set to **Local**.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The ID of the Bastionhost instance where you want to query the host.
            /// 
            /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The description of the host.
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// The status of the host. Valid values:
            /// 
            /// - **Normal**: The host is normal.
            /// 
            /// - **Release**: The host is released.
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

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
            /// GetHost
            /// </summary>
            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<GetHostResponseBodyHostProtocols> Protocols { get; set; }
            public class GetHostResponseBodyHostProtocols : TeaModel {
                /// <summary>
                /// WB662865
                /// </summary>
                [NameInMap("HostFingerPrint")]
                [Validation(Required=false)]
                public string HostFingerPrint { get; set; }

                /// <summary>
                /// GetHost
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("ProtocolName")]
                [Validation(Required=false)]
                public string ProtocolName { get; set; }

            }

            /// <summary>
            /// The protocol information of the host.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// Queries the details of a specified host, such as the name, source, endpoint, protocol, and service port of the host.
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~315526~~).
            /// 
            /// For more information about sample requests, see the "Examples" section of this topic.
            /// </summary>
            [NameInMap("SourceInstanceState")]
            [Validation(Required=false)]
            public string SourceInstanceState { get; set; }

        }

        /// <summary>
        /// The endpoint type of the host. Valid values:
        /// 
        /// *   **Public**: a public endpoint
        /// *   **Private**: an internal endpoint
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
