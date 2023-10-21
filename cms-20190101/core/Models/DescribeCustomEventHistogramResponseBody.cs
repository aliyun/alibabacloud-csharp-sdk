// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventHistogramResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the number of times that the custom event occurred during each interval of a time period.
        /// </summary>
        [NameInMap("EventHistograms")]
        [Validation(Required=false)]
        public DescribeCustomEventHistogramResponseBodyEventHistograms EventHistograms { get; set; }
        public class DescribeCustomEventHistogramResponseBodyEventHistograms : TeaModel {
            [NameInMap("EventHistogram")]
            [Validation(Required=false)]
            public List<DescribeCustomEventHistogramResponseBodyEventHistogramsEventHistogram> EventHistogram { get; set; }
            public class DescribeCustomEventHistogramResponseBodyEventHistogramsEventHistogram : TeaModel {
                /// <summary>
                /// The information about the number of times that the custom event occurred during an interval of a time period.
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

        /// <summary>
        /// The returned message. If the call was successful, the value success is returned. If the call failed, an error message is returned.
        /// </summary>
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

    }

}
