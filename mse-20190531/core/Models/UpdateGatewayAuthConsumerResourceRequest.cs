// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerResourceRequest : TeaModel {
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
        /// The gateway authentication consumer ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public long? ConsumerId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The gateway authentication consumer ID.
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<UpdateGatewayAuthConsumerResourceRequestResourceList> ResourceList { get; set; }
        public class UpdateGatewayAuthConsumerResourceRequestResourceList : TeaModel {
            /// <summary>
            /// The route ID.
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            /// <summary>
            /// The name of the route.
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

    }

}
