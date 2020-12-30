// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QuotaApplication")]
        [Validation(Required=false)]
        public GetQuotaApplicationResponseBodyQuotaApplication QuotaApplication { get; set; }
        public class GetQuotaApplicationResponseBodyQuotaApplication : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public int? DesireValue { get; set; }
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }
        };

    }

}
