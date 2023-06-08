// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainTopClientIpVisitResponseBody : TeaModel {
        /// <summary>
        /// A list of client IP addresses.
        /// </summary>
        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<DescribeDomainTopClientIpVisitResponseBodyClientIpList> ClientIpList { get; set; }
        public class DescribeDomainTopClientIpVisitResponseBodyClientIpList : TeaModel {
            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// The client IP address returned. Only IPv4 addressed are supported.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The ranking of the client IP address returned.
            /// </summary>
            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            /// <summary>
            /// The total amount of network traffic consumed. Unit: bytes.
            /// </summary>
            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
