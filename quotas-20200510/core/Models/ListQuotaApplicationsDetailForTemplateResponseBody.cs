// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsDetailForTemplateResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QuotaApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplications> QuotaApplications { get; set; }
        public class ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplications : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            [NameInMap("ApproveValue")]
            [Validation(Required=false)]
            public double? ApproveValue { get; set; }

            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }

            [NameInMap("BatchQuotaApplicationId")]
            [Validation(Required=false)]
            public string BatchQuotaApplicationId { get; set; }

            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public double? DesireValue { get; set; }

            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            [NameInMap("EnvLanguage")]
            [Validation(Required=false)]
            public string EnvLanguage { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public int? NoticeType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplicationsPeriod Period { get; set; }
            public class ListQuotaApplicationsDetailForTemplateResponseBodyQuotaApplicationsPeriod : TeaModel {
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

            }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            [NameInMap("QuotaDimension")]
            [Validation(Required=false)]
            public Dictionary<string, string> QuotaDimension { get; set; }

            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
