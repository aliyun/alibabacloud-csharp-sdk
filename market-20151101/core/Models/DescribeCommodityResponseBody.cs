// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCommodityResponseBody : TeaModel {
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public DescribeCommodityResponseBodyCommodity Commodity { get; set; }
        public class DescribeCommodityResponseBodyCommodity : TeaModel {
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }
            [NameInMap("CommodityId")]
            [Validation(Required=false)]
            public string CommodityId { get; set; }
            [NameInMap("CommoditySpecs")]
            [Validation(Required=false)]
            public string CommoditySpecs { get; set; }
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
