// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CheckResourceStockResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceStockModels")]
        [Validation(Required=false)]
        public List<CheckResourceStockResponseBodyResourceStockModels> ResourceStockModels { get; set; }
        public class CheckResourceStockResponseBodyResourceStockModels : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("StockStatus")]
            [Validation(Required=false)]
            public string StockStatus { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
