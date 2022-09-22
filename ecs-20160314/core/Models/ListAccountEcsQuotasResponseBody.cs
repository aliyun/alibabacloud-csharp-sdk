// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ListAccountEcsQuotasResponseBody : TeaModel {
        [NameInMap("EcsQuotas")]
        [Validation(Required=false)]
        public ListAccountEcsQuotasResponseBodyEcsQuotas EcsQuotas { get; set; }
        public class ListAccountEcsQuotasResponseBodyEcsQuotas : TeaModel {
            [NameInMap("EcsQuota")]
            [Validation(Required=false)]
            public List<ListAccountEcsQuotasResponseBodyEcsQuotasEcsQuota> EcsQuota { get; set; }
            public class ListAccountEcsQuotasResponseBodyEcsQuotasEcsQuota : TeaModel {
                [NameInMap("ApplicationStatus")]
                [Validation(Required=false)]
                public string ApplicationStatus { get; set; }

                [NameInMap("BaseQuota")]
                [Validation(Required=false)]
                public long? BaseQuota { get; set; }

                [NameInMap("BaseQuotaUsage")]
                [Validation(Required=false)]
                public long? BaseQuotaUsage { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("QuotaResourceName")]
                [Validation(Required=false)]
                public string QuotaResourceName { get; set; }

                [NameInMap("QuotaResourceType")]
                [Validation(Required=false)]
                public string QuotaResourceType { get; set; }

                [NameInMap("QuotaUnit")]
                [Validation(Required=false)]
                public string QuotaUnit { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservedQuota")]
                [Validation(Required=false)]
                public long? ReservedQuota { get; set; }

                [NameInMap("ReservedQuotaUsage")]
                [Validation(Required=false)]
                public long? ReservedQuotaUsage { get; set; }

                [NameInMap("TotalQuota")]
                [Validation(Required=false)]
                public long? TotalQuota { get; set; }

                [NameInMap("TotalQuotaUsage")]
                [Validation(Required=false)]
                public long? TotalQuotaUsage { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
