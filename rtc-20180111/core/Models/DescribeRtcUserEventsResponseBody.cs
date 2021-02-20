// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcUserEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeRtcUserEventsResponseBodyEvents> Events { get; set; }
        public class DescribeRtcUserEventsResponseBodyEvents : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

    }

}
