// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryItemGuideRetailPriceShrinkRequest : TeaModel {
        [NameInMap("DistributionMallId")]
        [Validation(Required=false)]
        public string DistributionMallId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("LmItemIds")]
        [Validation(Required=false)]
        public string LmItemIdsShrink { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
