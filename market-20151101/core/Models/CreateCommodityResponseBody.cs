// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CreateCommodityResponseBody : TeaModel {
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public CreateCommodityResponseBodyCommodity Commodity { get; set; }
        public class CreateCommodityResponseBodyCommodity : TeaModel {
            [NameInMap("CommodityId")]
            [Validation(Required=false)]
            public string CommodityId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
