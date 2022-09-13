// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryOrderList4DistributionRequest : TeaModel {
        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("FilterOption")]
        [Validation(Required=false)]
        public string FilterOption { get; set; }

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
