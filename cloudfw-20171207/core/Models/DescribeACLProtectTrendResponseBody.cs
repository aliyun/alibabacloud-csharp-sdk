// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendResponseBody : TeaModel {
        /// <summary>
        /// The number of internal requests that are blocked by the ACL feature.
        /// </summary>
        [NameInMap("InProtectCnt")]
        [Validation(Required=false)]
        public long? InProtectCnt { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("InterVPCProtectCnt")]
        [Validation(Required=false)]
        public long? InterVPCProtectCnt { get; set; }

        /// <summary>
        /// The interval for returning data. Unit: seconds.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The number of external requests that are blocked by the ACL feature.
        /// </summary>
        [NameInMap("OutProtectCnt")]
        [Validation(Required=false)]
        public long? OutProtectCnt { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of requests that are blocked by the ACL feature.
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

        /// <summary>
        /// The statistics on the requests that are blocked by the ACL feature.
        /// </summary>
        [NameInMap("TrendList")]
        [Validation(Required=false)]
        public List<DescribeACLProtectTrendResponseBodyTrendList> TrendList { get; set; }
        public class DescribeACLProtectTrendResponseBodyTrendList : TeaModel {
            /// <summary>
            /// The number of requests that are blocked by ACL on the current day.
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public int? ProtectCnt { get; set; }

            /// <summary>
            /// The UNIX timestamp at midnight (00:00:00) of each day, which indicates the date of the current day. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

    }

}
