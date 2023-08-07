// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpCidrResponseBody : TeaModel {
        /// <summary>
        /// The ID of the NAT CIDR block.
        /// </summary>
        [NameInMap("NatIpCidrId")]
        [Validation(Required=false)]
        public string NatIpCidrId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
