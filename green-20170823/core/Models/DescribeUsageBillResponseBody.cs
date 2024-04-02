// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeUsageBillResponseBody : TeaModel {
        [NameInMap("BillList")]
        [Validation(Required=false)]
        public List<DescribeUsageBillResponseBodyBillList> BillList { get; set; }
        public class DescribeUsageBillResponseBodyBillList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("ConfirmCount")]
            [Validation(Required=false)]
            public long? ConfirmCount { get; set; }

            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("FreeCount")]
            [Validation(Required=false)]
            public long? FreeCount { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ReviewCount")]
            [Validation(Required=false)]
            public long? ReviewCount { get; set; }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
