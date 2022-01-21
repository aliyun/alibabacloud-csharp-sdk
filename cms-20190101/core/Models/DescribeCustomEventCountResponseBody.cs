// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CustomEventCounts")]
        [Validation(Required=false)]
        public DescribeCustomEventCountResponseBodyCustomEventCounts CustomEventCounts { get; set; }
        public class DescribeCustomEventCountResponseBodyCustomEventCounts : TeaModel {
            [NameInMap("CustomEventCount")]
            [Validation(Required=false)]
            public List<DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount> CustomEventCount { get; set; }
            public class DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount : TeaModel {
                public string Name { get; set; }
                public int? Num { get; set; }
                public long? Time { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
