// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class PurchaseResourcesRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("BuyNumber")]
        [Validation(Required=false)]
        public int? BuyNumber { get; set; }

        [NameInMap("IsDisplayPool")]
        [Validation(Required=false)]
        public bool? IsDisplayPool { get; set; }

        [NameInMap("NoLike")]
        [Validation(Required=false)]
        public string NoLike { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public int? ResType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

        [NameInMap("UsageScenarios")]
        [Validation(Required=false)]
        public string UsageScenarios { get; set; }

    }

}
