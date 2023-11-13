// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainAttackEventsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the DDoS attack event.
        /// </summary>
        [NameInMap("DomainAttackEvents")]
        [Validation(Required=false)]
        public List<DescribeDomainAttackEventsResponseBodyDomainAttackEvents> DomainAttackEvents { get; set; }
        public class DescribeDomainAttackEventsResponseBodyDomainAttackEvents : TeaModel {
            /// <summary>
            /// The attacked domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The time when the DDoS attack stopped. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The peak attack QPS.
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// The time when the DDoS attack started. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned DDoS attack events.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
