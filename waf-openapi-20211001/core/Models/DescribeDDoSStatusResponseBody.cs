// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDDoSStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether DDoS attacks occur on specific domain names.
        /// </summary>
        [NameInMap("DDoSStatus")]
        [Validation(Required=false)]
        public List<DescribeDDoSStatusResponseBodyDDoSStatus> DDoSStatus { get; set; }
        public class DescribeDDoSStatusResponseBodyDDoSStatus : TeaModel {
            /// <summary>
            /// The type of events that are triggered by DDoS attacks. Valid values:
            /// 
            /// *   defense: traffic scrubbing events.
            /// *   blackhole: blackhole filtering events.
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// Indicates whether DDoS attacks occur on specific domain names. Valid value:
            /// 
            /// *   **doing**: DDoS attacks occur on specific domain names.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
