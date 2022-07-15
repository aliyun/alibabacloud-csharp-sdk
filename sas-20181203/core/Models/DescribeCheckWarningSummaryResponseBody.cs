// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryResponseBody : TeaModel {
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

        [NameInMap("WarningSummarys")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningSummaryResponseBodyWarningSummarys> WarningSummarys { get; set; }
        public class DescribeCheckWarningSummaryResponseBodyWarningSummarys : TeaModel {
            [NameInMap("CheckCount")]
            [Validation(Required=false)]
            public int? CheckCount { get; set; }

            [NameInMap("CheckExploit")]
            [Validation(Required=false)]
            public bool? CheckExploit { get; set; }

            [NameInMap("DatabaseRisk")]
            [Validation(Required=false)]
            public bool? DatabaseRisk { get; set; }

            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            [NameInMap("LastFoundTime")]
            [Validation(Required=false)]
            public string LastFoundTime { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

    }

}
