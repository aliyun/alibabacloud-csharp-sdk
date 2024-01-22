// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsStatResponseBody : TeaModel {
        /// <summary>
        /// The event.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryEventsStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryEventsStatResponseBodyItems : TeaModel {
            /// <summary>
            /// The system event category. For more information, see [View the event history of an ApsaraDB RDS instance](~~129759~~).
            /// </summary>
            [NameInMap("EventCategory")]
            [Validation(Required=false)]
            public string EventCategory { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
