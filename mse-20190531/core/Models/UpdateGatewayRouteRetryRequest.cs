// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteRetryRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The ID of the associated record.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The information about the retry policy.
        /// </summary>
        [NameInMap("RetryJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteRetryRequestRetryJSON RetryJSON { get; set; }
        public class UpdateGatewayRouteRetryRequestRetryJSON : TeaModel {
            /// <summary>
            /// The number of retries.
            /// </summary>
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            /// <summary>
            /// The HTTP status codes.
            /// </summary>
            [NameInMap("HttpCodes")]
            [Validation(Required=false)]
            public List<string> HttpCodes { get; set; }

            /// <summary>
            /// The retry conditions.
            /// </summary>
            [NameInMap("RetryOn")]
            [Validation(Required=false)]
            public List<string> RetryOn { get; set; }

            /// <summary>
            /// The status of the policy.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
