// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEventResponseBody : TeaModel {
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeServiceEventResponseBodyEvents> Events { get; set; }
        public class DescribeServiceEventResponseBodyEvents : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public long? TotalPageNum { get; set; }

    }

}
