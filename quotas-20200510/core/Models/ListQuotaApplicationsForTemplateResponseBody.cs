// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QuotaBatchApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications> QuotaBatchApplications { get; set; }
        public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications : TeaModel {
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            [NameInMap("AuditStatusVos")]
            [Validation(Required=false)]
            public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos> AuditStatusVos { get; set; }
            public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("BatchQuotaApplicationId")]
            [Validation(Required=false)]
            public string BatchQuotaApplicationId { get; set; }

            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public double? DesireValue { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
