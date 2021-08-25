// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRulesReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRulesReport")]
        [Validation(Required=false)]
        public GetConfigRulesReportResponseBodyConfigRulesReport ConfigRulesReport { get; set; }
        public class GetConfigRulesReportResponseBodyConfigRulesReport : TeaModel {
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("ReportCreateTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateTimestamp { get; set; }
        };

    }

}
