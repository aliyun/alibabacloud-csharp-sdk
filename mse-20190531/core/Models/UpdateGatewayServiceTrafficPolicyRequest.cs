// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayServiceTrafficPolicyRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   **zh-CN** (default): Chinese
        /// *   **en-US**: English
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
        /// The traffic policy of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayTrafficPolicy")]
        [Validation(Required=false)]
        public TrafficPolicy GatewayTrafficPolicy { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The ID of the service.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

    }

}
