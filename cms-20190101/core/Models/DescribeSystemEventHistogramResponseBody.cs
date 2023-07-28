// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventHistogramResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The information about the number of times that the system event occurred during each interval of a time period.
        /// </summary>
        [NameInMap("SystemEventHistograms")]
        [Validation(Required=false)]
        public DescribeSystemEventHistogramResponseBodySystemEventHistograms SystemEventHistograms { get; set; }
        public class DescribeSystemEventHistogramResponseBodySystemEventHistograms : TeaModel {
            [NameInMap("SystemEventHistogram")]
            [Validation(Required=false)]
            public List<DescribeSystemEventHistogramResponseBodySystemEventHistogramsSystemEventHistogram> SystemEventHistogram { get; set; }
            public class DescribeSystemEventHistogramResponseBodySystemEventHistogramsSystemEventHistogram : TeaModel {
                /// <summary>
                /// The number of times that the system event occurred.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The end of an interval.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The beginning of an interval.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

    }

}
