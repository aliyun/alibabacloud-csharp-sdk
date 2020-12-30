// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAttackEventsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeDomainAttackEventsResponseBodyEvents> Events { get; set; }
        public class DescribeDomainAttackEventsResponseBodyEvents : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public int? MaxQps { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public long? BlockCount { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
