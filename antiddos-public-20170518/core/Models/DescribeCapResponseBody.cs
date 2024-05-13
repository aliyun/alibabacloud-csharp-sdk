// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeCapResponseBody : TeaModel {
        /// <summary>
        /// The download link to the traffic data that is captured when a DDoS attack event occurs.
        /// </summary>
        [NameInMap("CapUrl")]
        [Validation(Required=false)]
        public DescribeCapResponseBodyCapUrl CapUrl { get; set; }
        public class DescribeCapResponseBodyCapUrl : TeaModel {
            /// <summary>
            /// The download link to the traffic data.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
