// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyItems Items { get; set; }
        public class DescribeProcessListResponseBodyItems : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyItemsProcess> Process { get; set; }
            public class DescribeProcessListResponseBodyItemsProcess : TeaModel {
                public string StartTime { get; set; }
                public int? Time { get; set; }
                public string ProcessId { get; set; }
                public string Host { get; set; }
                public string DB { get; set; }
                public string Command { get; set; }
                public string User { get; set; }
                public int? Id { get; set; }
                public string Info { get; set; }
            }
        };

    }

}
