// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchDescribeCdnIpInfoResponseBody : TeaModel {
        /// <summary>
        /// The results about IP addresses returned.
        /// </summary>
        [NameInMap("IpInfoList")]
        [Validation(Required=false)]
        public List<BatchDescribeCdnIpInfoResponseBodyIpInfoList> IpInfoList { get; set; }
        public class BatchDescribeCdnIpInfoResponseBodyIpInfoList : TeaModel {
            /// <summary>
            /// Indicates whether the IP address belongs to an Alibaba Cloud CDN point of presence (POP).
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CdnIp")]
            [Validation(Required=false)]
            public string CdnIp { get; set; }

            /// <summary>
            /// The city to which the IP address belongs.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The country to which the IP address belongs.
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The ISP to which the IP address belongs.
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// The province to which the IP address belongs.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
