// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteCORSRequest : TeaModel {
        /// <summary>
        /// The language of the response. In compliance with [RFC 7231](https://tools.ietf.org/html/rfc7231), the backend service must return a response based on the language used by the user.
        /// This parameter is empty by default. Valid values:
        /// * zh-CN: Chinese
        /// * en-US: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The information about the CORS policy.
        /// </summary>
        [NameInMap("CorsJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteCORSRequestCorsJSON CorsJSON { get; set; }
        public class UpdateGatewayRouteCORSRequestCorsJSON : TeaModel {
            /// <summary>
            /// The credentials allowed.
            /// </summary>
            [NameInMap("AllowCredentials")]
            [Validation(Required=false)]
            public bool? AllowCredentials { get; set; }

            /// <summary>
            /// The request headers allowed.
            /// </summary>
            [NameInMap("AllowHeaders")]
            [Validation(Required=false)]
            public string AllowHeaders { get; set; }

            /// <summary>
            /// The HTTP methods allowed.
            /// </summary>
            [NameInMap("AllowMethods")]
            [Validation(Required=false)]
            public string AllowMethods { get; set; }

            /// <summary>
            /// The origins from which access is allowed.
            /// </summary>
            [NameInMap("AllowOrigins")]
            [Validation(Required=false)]
            public string AllowOrigins { get; set; }

            /// <summary>
            /// The response headers allowed.
            /// </summary>
            [NameInMap("ExposeHeaders")]
            [Validation(Required=false)]
            public string ExposeHeaders { get; set; }

            /// <summary>
            /// The status of the policy.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The unit of time.
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// The value of time.
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

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

    }

}
