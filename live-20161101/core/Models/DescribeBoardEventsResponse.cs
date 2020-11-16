// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardEventsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=true)]
        public List<DescribeBoardEventsResponseEvents> Events { get; set; }
        public class DescribeBoardEventsResponseEvents : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=true)]
            public long EventId { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=true)]
            public int? EventType { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=true)]
            public int? UserId { get; set; }

            [NameInMap("Data")]
            [Validation(Required=true)]
            public string Data { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=true)]
            public long Timestamp { get; set; }

        }

    }

}
