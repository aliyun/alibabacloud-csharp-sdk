// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryDistributionBillDetailRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("BillPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        [NameInMap("BillStatus")]
        [Validation(Required=false)]
        public string BillStatus { get; set; }

        [NameInMap("DistributionMallId")]
        [Validation(Required=false)]
        public string DistributionMallId { get; set; }

        [NameInMap("DistributionMallName")]
        [Validation(Required=false)]
        public string DistributionMallName { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
