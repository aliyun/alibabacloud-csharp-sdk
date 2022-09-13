// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ConfirmDisburse4DistributionRequest : TeaModel {
        [NameInMap("DistributionTradeId")]
        [Validation(Required=false)]
        public string DistributionTradeId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("MainDistributionOrderId")]
        [Validation(Required=false)]
        public string MainDistributionOrderId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
