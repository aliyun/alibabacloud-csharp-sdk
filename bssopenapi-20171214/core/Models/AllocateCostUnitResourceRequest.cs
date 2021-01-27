/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceRequest : TeaModel {
        [NameInMap("FromUnitUserId")]
        [Validation(Required=false)]
        public long? FromUnitUserId { get; set; }

        [NameInMap("FromUnitId")]
        [Validation(Required=false)]
        public long? FromUnitId { get; set; }

        [NameInMap("ToUnitUserId")]
        [Validation(Required=false)]
        public long? ToUnitUserId { get; set; }

        [NameInMap("ToUnitId")]
        [Validation(Required=false)]
        public long? ToUnitId { get; set; }

        [NameInMap("ResourceInstanceList")]
        [Validation(Required=false)]
        public List<AllocateCostUnitResourceRequestResourceInstanceList> ResourceInstanceList { get; set; }
        public class AllocateCostUnitResourceRequestResourceInstanceList : TeaModel {
            [NameInMap("ApportionCode")]
            [Validation(Required=false)]
            public string ApportionCode { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

        }

    }

}
