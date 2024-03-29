// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventCountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the custom event.
        /// </summary>
        [NameInMap("CustomEventCounts")]
        [Validation(Required=false)]
        public DescribeCustomEventCountResponseBodyCustomEventCounts CustomEventCounts { get; set; }
        public class DescribeCustomEventCountResponseBodyCustomEventCounts : TeaModel {
            [NameInMap("CustomEventCount")]
            [Validation(Required=false)]
            public List<DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount> CustomEventCount { get; set; }
            public class DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount : TeaModel {
                /// <summary>
                /// The name of the custom event.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of times that the custom event occurred in the specified time period.
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public int? Num { get; set; }

                /// <summary>
                /// The time when the custom event occurred.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

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
        public bool? Success { get; set; }

    }

}
