// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeInspectionResultRequest : TeaModel {
        [NameInMap("ContinuousDays")]
        [Validation(Required=false)]
        public int? ContinuousDays { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RiskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

    }

}
