// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribePayAsYouGoPriceResponseBody : TeaModel {
        [NameInMap("CacheCloudEfficiencySizePrice")]
        [Validation(Required=false)]
        public float? CacheCloudEfficiencySizePrice { get; set; }

        [NameInMap("CacheCloudSSDSizePrice")]
        [Validation(Required=false)]
        public float? CacheCloudSSDSizePrice { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("GatewayClassPrice")]
        [Validation(Required=false)]
        public float? GatewayClassPrice { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
