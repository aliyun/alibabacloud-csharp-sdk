// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteTimeoutRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// - zh: Chinese
        /// - en: English
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
        /// The ID of the route.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The timeout period.
        /// </summary>
        [NameInMap("TimeoutJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteTimeoutRequestTimeoutJSON TimeoutJSON { get; set; }
        public class UpdateGatewayRouteTimeoutRequestTimeoutJSON : TeaModel {
            /// <summary>
            /// The status of the policy.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The unit of time. A value of s indicates seconds.
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// The value of the timeout period.
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public int? UnitNum { get; set; }

        }

    }

}
