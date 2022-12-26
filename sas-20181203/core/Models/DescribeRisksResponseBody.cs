// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRisksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Risks")]
        [Validation(Required=false)]
        public List<DescribeRisksResponseBodyRisks> Risks { get; set; }
        public class DescribeRisksResponseBodyRisks : TeaModel {
            [NameInMap("RiskDetail")]
            [Validation(Required=false)]
            public string RiskDetail { get; set; }

            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            [NameInMap("SubRiskType")]
            [Validation(Required=false)]
            public string SubRiskType { get; set; }

            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
