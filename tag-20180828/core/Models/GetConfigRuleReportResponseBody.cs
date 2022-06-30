// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetConfigRuleReportResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConfigRuleReportResponseBodyData Data { get; set; }
        public class GetConfigRuleReportResponseBodyData : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
