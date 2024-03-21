// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainCidrResponseBody : TeaModel {
        /// <summary>
        /// The back-to-origin IPv4 and IPv6 CIDR blocks.
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public List<string> Cidr { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
