// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeStsGrantStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The authorization status of Anti-DDoS Pro or Anti-DDoS Premium.
        /// </summary>
        [NameInMap("StsGrant")]
        [Validation(Required=false)]
        public DescribeStsGrantStatusResponseBodyStsGrant StsGrant { get; set; }
        public class DescribeStsGrantStatusResponseBodyStsGrant : TeaModel {
            /// <summary>
            /// The authorization status. Valid values:
            /// 
            /// *   **0**: Anti-DDoS Pro or Anti-DDoS Premium is not authorized to access other cloud services.
            /// *   **1**: Anti-DDoS Pro or Anti-DDoS Premium is authorized to access other cloud services.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
