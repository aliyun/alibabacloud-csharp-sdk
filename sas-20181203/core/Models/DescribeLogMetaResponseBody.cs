// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogMetaResponseBody : TeaModel {
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<DescribeLogMetaResponseBodyLogMetaList> LogMetaList { get; set; }
        public class DescribeLogMetaResponseBodyLogMetaList : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            [NameInMap("LogDesc")]
            [Validation(Required=false)]
            public string LogDesc { get; set; }

            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            [NameInMap("UserLogStore")]
            [Validation(Required=false)]
            public string UserLogStore { get; set; }

            [NameInMap("UserProject")]
            [Validation(Required=false)]
            public string UserProject { get; set; }

            [NameInMap("UserRegion")]
            [Validation(Required=false)]
            public string UserRegion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
