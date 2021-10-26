// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiMarketAttributesResponseBody : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MarketChargingMode")]
        [Validation(Required=false)]
        public string MarketChargingMode { get; set; }

        [NameInMap("NeedCharging")]
        [Validation(Required=false)]
        public string NeedCharging { get; set; }

    }

}
