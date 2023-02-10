// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningsResponseBody : TeaModel {
        [NameInMap("CheckWarnings")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningsResponseBodyCheckWarnings> CheckWarnings { get; set; }
        public class DescribeCheckWarningsResponseBodyCheckWarnings : TeaModel {
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            [NameInMap("CheckWarningId")]
            [Validation(Required=false)]
            public long? CheckWarningId { get; set; }

            [NameInMap("ExecErrorMessage")]
            [Validation(Required=false)]
            public string ExecErrorMessage { get; set; }

            [NameInMap("FixStatus")]
            [Validation(Required=false)]
            public int? FixStatus { get; set; }

            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

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
