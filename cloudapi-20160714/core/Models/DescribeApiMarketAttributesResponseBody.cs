// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiMarketAttributesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the API.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The billing method used by the Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("MarketChargingMode")]
        [Validation(Required=false)]
        public string MarketChargingMode { get; set; }

        /// <summary>
        /// Indicates whether fees are charged.
        /// </summary>
        [NameInMap("NeedCharging")]
        [Validation(Required=false)]
        public string NeedCharging { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
