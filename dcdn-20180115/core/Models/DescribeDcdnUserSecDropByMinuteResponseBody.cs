// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropByMinuteResponseBody : TeaModel {
        /// <summary>
        /// The description of HTTP responses.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Len")]
        [Validation(Required=false)]
        public int? Len { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array.
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserSecDropByMinuteResponseBodyRows> Rows { get; set; }
        public class DescribeDcdnUserSecDropByMinuteResponseBodyRows : TeaModel {
            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The number of packets blocked within 5 minutes.
            /// </summary>
            [NameInMap("Drops")]
            [Validation(Required=false)]
            public int? Drops { get; set; }

            /// <summary>
            /// The object that triggered rate limiting.
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// The rule that was triggered.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The security feature that blocked the packets.
            /// </summary>
            [NameInMap("SecFunc")]
            [Validation(Required=false)]
            public string SecFunc { get; set; }

            /// <summary>
            /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("TmStr")]
            [Validation(Required=false)]
            public string TmStr { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
