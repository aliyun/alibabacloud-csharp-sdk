// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSessionStatisticResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics.
        /// </summary>
        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeSessionStatisticResponseBodyStatistic> Statistic { get; set; }
        public class DescribeSessionStatisticResponseBodyStatistic : TeaModel {
            /// <summary>
            /// The total number of sessions in the time range.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The point in time.
            /// </summary>
            [NameInMap("TimePoint")]
            [Validation(Required=false)]
            public long? TimePoint { get; set; }

        }

        /// <summary>
        /// The total number of sessions returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
