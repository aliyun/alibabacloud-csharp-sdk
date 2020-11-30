// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAttackEventsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long Total { get; set; }

        [NameInMap("Events")]
        [Validation(Required=true)]
        public List<DescribeDomainAttackEventsResponseEvents> Events { get; set; }
        public class DescribeDomainAttackEventsResponseEvents : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public long EndTime { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=true)]
            public int? Duration { get; set; }

            [NameInMap("Finished")]
            [Validation(Required=true)]
            public bool? Finished { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=true)]
            public int? MaxQps { get; set; }

            [NameInMap("BlockCount")]
            [Validation(Required=true)]
            public long BlockCount { get; set; }

        }

    }

}
