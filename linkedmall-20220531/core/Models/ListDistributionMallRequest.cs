// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ListDistributionMallRequest : TeaModel {
        [NameInMap("ChannelSupplierId")]
        [Validation(Required=false)]
        public string ChannelSupplierId { get; set; }

        [NameInMap("DistributionMallId")]
        [Validation(Required=false)]
        public string DistributionMallId { get; set; }

        [NameInMap("DistributionMallName")]
        [Validation(Required=false)]
        public string DistributionMallName { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
