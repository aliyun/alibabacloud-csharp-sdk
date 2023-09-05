// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSpareIpsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The secondary IP addresses that are associated with the CNAME.
        /// </summary>
        [NameInMap("SpareIps")]
        [Validation(Required=false)]
        public List<ListSpareIpsResponseBodySpareIps> SpareIps { get; set; }
        public class ListSpareIpsResponseBodySpareIps : TeaModel {
            /// <summary>
            /// The secondary IP address that is associated with the CNAME. If the acceleration area becomes unavailable, GA redirects traffic to the secondary IP address.
            /// </summary>
            [NameInMap("SpareIp")]
            [Validation(Required=false)]
            public string SpareIp { get; set; }

            /// <summary>
            /// The status of the secondary IP address. Valid values:
            /// 
            /// *   **active:** The secondary IP address is available.
            /// *   **inuse:** The secondary IP address is in use.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
