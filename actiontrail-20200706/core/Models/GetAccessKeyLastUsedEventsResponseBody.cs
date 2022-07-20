// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedEventsResponseBody : TeaModel {
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedEventsResponseBodyEvents> Events { get; set; }
        public class GetAccessKeyLastUsedEventsResponseBodyEvents : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
