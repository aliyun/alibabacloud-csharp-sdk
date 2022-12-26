// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningSummaryResponseBodyList> List { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyList : TeaModel {
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            [NameInMap("CheckLevel")]
            [Validation(Required=false)]
            public string CheckLevel { get; set; }

            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
