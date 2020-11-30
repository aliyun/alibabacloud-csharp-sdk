// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSEventsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long Total { get; set; }

        [NameInMap("Events")]
        [Validation(Required=true)]
        public List<DescribeDDoSEventsResponseEvents> Events { get; set; }
        public class DescribeDDoSEventsResponseEvents : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public long EndTime { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=true)]
            public int? Interval { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}
