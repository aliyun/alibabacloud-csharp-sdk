// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRequestGraphResponseBody : TeaModel {
        /// <summary>
        /// The information about the DNS requests.
        /// </summary>
        [NameInMap("RequestDetails")]
        [Validation(Required=false)]
        public DescribeRequestGraphResponseBodyRequestDetails RequestDetails { get; set; }
        public class DescribeRequestGraphResponseBodyRequestDetails : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop : TeaModel {
                /// <summary>
                /// The number of DNS requests.
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// The statistical time. The value is a string. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The statistical timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
