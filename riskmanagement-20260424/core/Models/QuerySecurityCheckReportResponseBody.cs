// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QuerySecurityCheckReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySecurityCheckReportResponseBodyData Data { get; set; }
        public class QuerySecurityCheckReportResponseBodyData : TeaModel {
            [NameInMap("CloudSecurityGuide")]
            [Validation(Required=false)]
            public int? CloudSecurityGuide { get; set; }

            [NameInMap("ConfigCheckNumber")]
            [Validation(Required=false)]
            public int? ConfigCheckNumber { get; set; }

            [NameInMap("ContactCheckNumber")]
            [Validation(Required=false)]
            public int? ContactCheckNumber { get; set; }

            [NameInMap("RiskEventNumber")]
            [Validation(Required=false)]
            public int? RiskEventNumber { get; set; }

            [NameInMap("SasCheckNumber")]
            [Validation(Required=false)]
            public int? SasCheckNumber { get; set; }

            [NameInMap("SecurityStatus")]
            [Validation(Required=false)]
            public int? SecurityStatus { get; set; }

            [NameInMap("SuggestionText")]
            [Validation(Required=false)]
            public string SuggestionText { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
