// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsResponseBody : TeaModel {
        /// <summary>
        /// The hosts that were queried.
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsResponseBodyHosts> Hosts { get; set; }
        public class ListHostsResponseBodyHosts : TeaModel {
            /// <summary>
            /// The endpoint type of the host. Valid values:
            /// 
            /// *   **Public**: a public endpoint
            /// *   **Private**: an internal endpoint
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
            /// The number of host accounts of the host.
            /// </summary>
            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public int? HostAccountCount { get; set; }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The name of the host.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The internal endpoint of the host. You can set this parameter to a domain name or an IP address.
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// The public endpoint of the host. You can set this parameter to a domain name or an IP address.
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
            /// The source of the host. Valid values:
            /// 
            /// *   **Local**: an on-premises host
            /// *   **Ecs**: an Elastic Compute Service (ECS) instance
            /// *   **Rds**: a host in a dedicated cluster
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The ID of the ECS instance or dedicated cluster host that was queried.
            /// 
            /// >  No value is returned for this parameter if the **Source** parameter is set to **Local**.
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// The status of the host. Valid values:
            /// 
            /// - **Normal**: The host is normal.
            /// 
            /// - **Release**: The host is released.
            /// </summary>
            [NameInMap("SourceInstanceState")]
            [Validation(Required=false)]
            public string SourceInstanceState { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of hosts that were queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
