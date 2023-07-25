// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBgpTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// The BGP traffic at each time interval.
        /// </summary>
        [NameInMap("BgpDataInterval")]
        [Validation(Required=false)]
        public List<DescribeDcdnBgpTrafficDataResponseBodyBgpDataInterval> BgpDataInterval { get; set; }
        public class DescribeDcdnBgpTrafficDataResponseBodyBgpDataInterval : TeaModel {
            /// <summary>
            /// The inbound traffic. Unit: bytes.
            /// </summary>
            [NameInMap("In")]
            [Validation(Required=false)]
            public long? In { get; set; }

            /// <summary>
            /// The outbound traffic. Unit: bytes.
            /// </summary>
            [NameInMap("Out")]
            [Validation(Required=false)]
            public long? Out { get; set; }

            /// <summary>
            /// The timestamp of the data returned.
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
