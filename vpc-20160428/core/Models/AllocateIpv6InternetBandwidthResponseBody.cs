// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateIpv6InternetBandwidthResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Internet bandwidth that you purchased for the IPv6 gateway.
        /// </summary>
        [NameInMap("InternetBandwidthId")]
        [Validation(Required=false)]
        public string InternetBandwidthId { get; set; }

        /// <summary>
        /// The ID of the IPv6 address.
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
