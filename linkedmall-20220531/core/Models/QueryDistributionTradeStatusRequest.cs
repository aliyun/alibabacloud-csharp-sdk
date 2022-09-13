// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryDistributionTradeStatusRequest : TeaModel {
        [NameInMap("DistributionSupplierId")]
        [Validation(Required=false)]
        public string DistributionSupplierId { get; set; }

        [NameInMap("DistributionTradeId")]
        [Validation(Required=false)]
        public string DistributionTradeId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
