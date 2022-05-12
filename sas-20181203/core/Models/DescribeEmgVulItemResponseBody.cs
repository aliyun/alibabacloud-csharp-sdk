// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeEmgVulItemResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeEmgVulItemResponseBodyGroupedVulItems : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            [NameInMap("GmtLastCheck")]
            [Validation(Required=false)]
            public long? GmtLastCheck { get; set; }

            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public long? GmtPublish { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
