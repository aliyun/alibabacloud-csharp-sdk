// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the hosts returned.
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsResponseBodyHosts> Hosts { get; set; }
        public class ListHostsResponseBodyHosts : TeaModel {
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
            /// The number of host accounts.
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
            /// The private address of the host. The value is a domain name or an IP address.
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
            /// *   **Local**: a host in a data center
            /// *   **Ecs**: an ECS instance
            /// *   **Rds**: a host in an ApsaraDB MyBase dedicated cluster
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster.
            /// 
            /// > No value is returned for this parameter if the **Source** parameter is set to **Local**.
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
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of hosts returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
