// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBgpBpsDataResponseBody : TeaModel {
        /// <summary>
        /// The BGP bandwidth data that is collected for each interval.
        /// </summary>
        [NameInMap("BgpDataInterval")]
        [Validation(Required=false)]
        public List<DescribeDcdnBgpBpsDataResponseBodyBgpDataInterval> BgpDataInterval { get; set; }
        public class DescribeDcdnBgpBpsDataResponseBodyBgpDataInterval : TeaModel {
            /// <summary>
            /// The inbound bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("In")]
            [Validation(Required=false)]
            public float? In { get; set; }

            /// <summary>
            /// The outbound bandwidth. Unit: bit/s.
            /// </summary>
            [NameInMap("Out")]
            [Validation(Required=false)]
            public float? Out { get; set; }

            /// <summary>
            /// The timestamp of the returned data.
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
