// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficTotalResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the assets that are protected by the Internet firewall.
        /// </summary>
        [NameInMap("TotalAssets")]
        [Validation(Required=false)]
        public long? TotalAssets { get; set; }

        /// <summary>
        /// The total number of the assets that are protected by the NAT firewall.
        /// </summary>
        [NameInMap("TotalNatAssets")]
        [Validation(Required=false)]
        public long? TotalNatAssets { get; set; }

        /// <summary>
        /// The total traffic for the NAT firewall. Unit: bytes.
        /// </summary>
        [NameInMap("TotalNatTraffic")]
        [Validation(Required=false)]
        public long? TotalNatTraffic { get; set; }

        /// <summary>
        /// The total traffic for the Internet firewall. Unit: bytes.
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

    }

}
