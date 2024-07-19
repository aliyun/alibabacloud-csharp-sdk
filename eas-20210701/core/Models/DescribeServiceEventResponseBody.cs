// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEventResponseBody : TeaModel {
        /// <summary>
        /// The events.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeServiceEventResponseBodyEvents> Events { get; set; }
        public class DescribeServiceEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// The returned message. The message is formatted and returned in the JSON format.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The cause of the event. The information about the change in the service status is returned.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The time when the event occurred. The time must be in UTC.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The event type. Valid values:
            /// 
            /// *   Normal
            /// *   Warning
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public long? TotalPageNum { get; set; }

    }

}
