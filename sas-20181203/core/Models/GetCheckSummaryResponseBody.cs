// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Summarys")]
        [Validation(Required=false)]
        public List<GetCheckSummaryResponseBodySummarys> Summarys { get; set; }
        public class GetCheckSummaryResponseBodySummarys : TeaModel {
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public long? PassCount { get; set; }

            [NameInMap("Standards")]
            [Validation(Required=false)]
            public List<GetCheckSummaryResponseBodySummarysStandards> Standards { get; set; }
            public class GetCheckSummaryResponseBodySummarysStandards : TeaModel {
                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public int? FailCount { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("PassCount")]
                [Validation(Required=false)]
                public int? PassCount { get; set; }

                [NameInMap("RiskLevelHighCount")]
                [Validation(Required=false)]
                public int? RiskLevelHighCount { get; set; }

                [NameInMap("RiskLevelLowCount")]
                [Validation(Required=false)]
                public int? RiskLevelLowCount { get; set; }

                [NameInMap("RiskLevelMediumCount")]
                [Validation(Required=false)]
                public int? RiskLevelMediumCount { get; set; }

                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
