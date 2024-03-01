// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeCfwRiskLevelSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeCfwRiskLevelSummaryResponseBodyRiskList> RiskList { get; set; }
        public class DescribeCfwRiskLevelSummaryResponseBodyRiskList : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Num")]
            [Validation(Required=false)]
            public string Num { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
