// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class InitApplyRefund4DistributionRequest : TeaModel {
        [NameInMap("BizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("GoodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        [NameInMap("SubDistributionOrderId")]
        [Validation(Required=false)]
        public string SubDistributionOrderId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
