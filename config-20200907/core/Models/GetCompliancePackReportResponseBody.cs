// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CompliancePackReport")]
        [Validation(Required=false)]
        public GetCompliancePackReportResponseBodyCompliancePackReport CompliancePackReport { get; set; }
        public class GetCompliancePackReportResponseBodyCompliancePackReport : TeaModel {
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("ReportCreateTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateTimestamp { get; set; }
        };

    }

}
