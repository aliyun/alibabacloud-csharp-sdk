// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDomainResolveResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the DNS record of the domain name.
        /// </summary>
        [NameInMap("ResolveResult")]
        [Validation(Required=false)]
        public DescribeDomainResolveResponseBodyResolveResult ResolveResult { get; set; }
        public class DescribeDomainResolveResponseBodyResolveResult : TeaModel {
            /// <summary>
            /// The IP address to which the domain name is resolved. Multiple IP addresses are separated by commas (,).
            /// </summary>
            [NameInMap("IpAddrs")]
            [Validation(Required=false)]
            public string IpAddrs { get; set; }

            /// <summary>
            /// The time when the domain name was resolved. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
