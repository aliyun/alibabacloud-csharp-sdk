// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ListDistributionItemWithoutCacheRequest : TeaModel {
        [NameInMap("DistributionMallId")]
        [Validation(Required=false)]
        public string DistributionMallId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("ItemStatus")]
        [Validation(Required=false)]
        public int? ItemStatus { get; set; }

        [NameInMap("LmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

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
