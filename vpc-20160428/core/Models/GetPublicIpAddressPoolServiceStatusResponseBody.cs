// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetPublicIpAddressPoolServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the IP address pool feature is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false** You can call OpenPublicIpAddressPoolService to enable the IP address pool feature.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
