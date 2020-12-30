// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetProductQuotaResponseBodyQuota Quota { get; set; }
        public class GetProductQuotaResponseBodyQuota : TeaModel {
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }
            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public float? TotalUsage { get; set; }
            [NameInMap("ApplicableRange")]
            [Validation(Required=false)]
            public List<string> ApplicableRange { get; set; }
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }
            [NameInMap("Period")]
            [Validation(Required=false)]
            public GetProductQuotaResponseBodyQuotaPeriod Period { get; set; }
            public class GetProductQuotaResponseBodyQuotaPeriod : TeaModel {
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public int? PeriodValue { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

            }
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }
            [NameInMap("ApplicableType")]
            [Validation(Required=false)]
            public string ApplicableType { get; set; }
            [NameInMap("QuotaItems")]
            [Validation(Required=false)]
            public List<GetProductQuotaResponseBodyQuotaQuotaItems> QuotaItems { get; set; }
            public class GetProductQuotaResponseBodyQuotaQuotaItems : TeaModel {
                public string Type { get; set; }
                public string Quota { get; set; }
                public string QuotaUnit { get; set; }
                public string Usage { get; set; }
            }
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Dimensions { get; set; }
            [NameInMap("Adjustable")]
            [Validation(Required=false)]
            public bool? Adjustable { get; set; }
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }
            [NameInMap("UnadjustableDetail")]
            [Validation(Required=false)]
            public string UnadjustableDetail { get; set; }
            [NameInMap("Consumable")]
            [Validation(Required=false)]
            public bool? Consumable { get; set; }
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public float? TotalQuota { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
        };

    }

}
