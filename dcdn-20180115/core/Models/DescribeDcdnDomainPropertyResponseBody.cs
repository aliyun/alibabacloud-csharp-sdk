// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainPropertyResponseBody : TeaModel {
        /// <summary>
        /// The name of the protocol. Valid values:
        /// 
        /// *   **udp**: User Datagram Protocol (UDP)
        /// *   **tcp**: Transmission Control Protocol (TCP)
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// >  The maximum number of times that users can call this operation per second is 10.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The accelerated domain name that is queried.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
