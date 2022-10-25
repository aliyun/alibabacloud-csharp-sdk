// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteRetryRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("RetryJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRetryRequestRetryJSON RetryJSON { get; set; }
        public class UpdateGatewayRouteRetryRequestRetryJSON : TeaModel {
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            [NameInMap("HttpCodes")]
            [Validation(Required=false)]
            public List<string> HttpCodes { get; set; }

            [NameInMap("RetryOn")]
            [Validation(Required=false)]
            public List<string> RetryOn { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
