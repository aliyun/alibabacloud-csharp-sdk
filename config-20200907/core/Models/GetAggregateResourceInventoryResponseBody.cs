// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceInventoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceInventory")]
        [Validation(Required=false)]
        public GetAggregateResourceInventoryResponseBodyResourceInventory ResourceInventory { get; set; }
        public class GetAggregateResourceInventoryResponseBodyResourceInventory : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
