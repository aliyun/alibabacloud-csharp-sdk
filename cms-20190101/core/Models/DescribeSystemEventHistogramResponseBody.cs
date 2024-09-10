// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventHistogramResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true: The request was successful. false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The information about the number of times the system event occurred during each interval of a time period.
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
                /// The number of times the system event occurred.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The end time.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The start time.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

    }

}
