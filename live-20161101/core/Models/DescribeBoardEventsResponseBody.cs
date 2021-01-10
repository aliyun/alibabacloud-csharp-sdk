// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeBoardEventsResponseBodyEvents> Events { get; set; }
        public class DescribeBoardEventsResponseBodyEvents : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public int? EventType { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public int? UserId { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
