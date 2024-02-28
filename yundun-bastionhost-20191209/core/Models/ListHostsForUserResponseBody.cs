// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserResponseBody : TeaModel {
        /// <summary>
        /// The hosts returned.
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsForUserResponseBodyHosts> Hosts { get; set; }
        public class ListHostsForUserResponseBodyHosts : TeaModel {
            /// <summary>
            /// The endpoint type of the host. Valid values:
            /// 
            /// *   **Public**: public endpoint
            /// *   **Private**: internal endpoint
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
            /// The name of the host.
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
            /// The public endpoint of the host. The value is a domain name or an IP address.
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

        }

        /// <summary>
        /// The request ID.
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
