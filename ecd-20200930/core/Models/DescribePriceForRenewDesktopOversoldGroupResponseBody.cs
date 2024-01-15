// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceForRenewDesktopOversoldGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePriceForRenewDesktopOversoldGroupResponseBodyData Data { get; set; }
        public class DescribePriceForRenewDesktopOversoldGroupResponseBodyData : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
